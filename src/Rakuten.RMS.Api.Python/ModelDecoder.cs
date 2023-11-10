using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;
using Python.Runtime.Codecs;
using Rakuten.RMS.Api.ItemAPI20;

namespace Rakuten.RMS.Api.Python
{
    public class ModelDecoder : IPyObjectDecoder
    {
        public bool CanDecode(PyType objectType, Type targetType)
        {
            return targetType.GetCustomAttributes(typeof(DecodableObjectAttribute), true).Any()
                || targetType == typeof(DateTime)
                || ( targetType.IsGenericType && typeof(List<>).IsAssignableFrom( targetType.GetGenericTypeDefinition()) );
        }
        public bool TryDecode<T>(PyObject pyObj, out T value)
        {
            T instance = default(T);
            if( typeof(T) == typeof(DateTime))
            {
                if(pyObj.IsNone())
                {
                    value = (T)(object)null;
                    return true;
                }
                var timestamp =
                    /*datetime*/ pyObj.HasAttr("timestamp") ? pyObj.InvokeMethod("timestamp").As<float>() :
                    /*date*/ pyObj.HasAttr("year") && pyObj.HasAttr("month") && pyObj.HasAttr("day") ?
                        ((DateTimeOffset)new DateTime(pyObj.GetAttr("year").As<int>(), pyObj.GetAttr("month").As<int>(), pyObj.GetAttr("day").As<int>()))
                        .ToUnixTimeSeconds():
                    default(double) ;
                var unixTimeStamp = timestamp;
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
                value = (T)(object)dateTime;
                return true;
            }
            if(typeof(T).IsGenericType && typeof(List<>).IsAssignableFrom( typeof(T).GetGenericTypeDefinition()) )
            {
                dynamic list = Activator.CreateInstance(typeof(T));
                var itemType = typeof(T).GetGenericArguments()[0];
                var iter = PyIter.GetIter(pyObj);
                while (iter.MoveNext())
                {
                    var mitem = iter.Current.AsManagedObject(itemType);
                    list.Add( (dynamic)mitem );
                }
                value = (T)(object)list;
                return true;
            }
            else if (PyDict.IsDictType(pyObj) && typeof(T).GetConstructor(Type.EmptyTypes) != null)
            {
                instance = Activator.CreateInstance<T>();
                value = (T)instance;
                var dict = new PyDict(pyObj);
                foreach (var i in dict)
                {
                    var pi = typeof(T).GetProperty(i.ToString(), System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance );
                    if (pi == null)
                        throw new InvalidCastException(string.Format("{0} is not a property of {1}", i.ToString(), typeof(T)));
                    var actualType = pi.PropertyType;
                    if (pi.PropertyType.IsGenericType)
                        actualType = Nullable.GetUnderlyingType(pi.PropertyType) ?? pi.PropertyType;
                    var orgValue = dict.GetItem(i);
                    pi.SetValue(instance, orgValue.IsNone() ? null :
                        orgValue.AsManagedObject(actualType) , null);

                }
                return true;
            }
            value = instance;
            return false;
        }
        public static ModelDecoder Instance { get; } = new ModelDecoder();

        public static void Register()
        {
            PyObjectConversions.RegisterDecoder(Instance);
        }
    }
}
