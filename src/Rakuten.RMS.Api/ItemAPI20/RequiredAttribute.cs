using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakuten.RMS.Api.ItemAPI20
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class RequiredAttribute : Attribute
    {
        public RequiredAttribute(bool conditional = false)
        {
            Conditional = conditional;
        }

        public bool Conditional { get; set; }
    }
}
