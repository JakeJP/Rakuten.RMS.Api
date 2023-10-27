using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;
using static Rakuten.RMS.Api.CabinetAPI.GetFilesResponse;
using System.IO;

namespace Rakuten.RMS.Api.CabinetAPI
{
    /// <summary>
    /// R-CabinetAPI（CabinetAPI）
    /// </summary>
    public class CabinetAPI : RakutenApiXmlClientBase
    {
        internal CabinetAPI(ServiceProvider provider) : base(provider)
        {
        }
        /// <summary>
        /// R-Cabinetの利用状況を取得
        /// </summary>
        /// <returns>CabinetUsageGetResultModel</returns>
        /// <exception cref="InvalidOperationException"></exception>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/usage/get", EndpointHttpMethod.GET)]
        public CabinetUsageGetResultModel GetUsage()
        {
            var res = Get<GetUsageResponse>();
            if (res.Status.SystemStatus != SystemStatus.OK)
                throw new InvalidOperationException($"{res.Status.SystemStatus} {res.Status.Message}");
            return res.Result;
        }
        /// <summary>
        /// フォルダの一覧を取得.ページングを内蔵した GetAllFolders を推奨。
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        /// <exception cref="XmlStatusException"></exception>

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folders/get", EndpointHttpMethod.GET)]
        public GetFoldersResponse.ResultModel GetFolders(int? offset = null, int? limit = null)
        {
            var response = Get<GetFoldersResponse>(new NameValueCollection {
                { "offset", offset.ToString() },
                {"limit", limit.ToString() }
            });
            if (response.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(response.Status);
            return response.Result;
        }
        /// <summary>
        /// ページング処理をラップしたバージョン。通常はこちらのメソッド利用を推奨。
        /// </summary>
        /// <param name="pageSize">※値は100まで指定可能</param>
        /// <returns></returns>
        public IEnumerable<FolderModel> GetAllFolders( int pageSize = 20)
        {
            int currentPage = 1;
            while (true)
            {
                var res = GetFolders(currentPage, pageSize);
                if (res.FolderCount == 0 || res.Folders == null)
                    yield break;
                foreach (var f in res.Folders)
                    yield return f;
                if (res.FolderCount < pageSize || currentPage * pageSize >= res.FolderAllCount)
                    yield break;
                currentPage++;
            }
        }
        /// <summary>
        /// 指定したフォルダ内の画像一覧を取得.ページングを内蔵した GetAllFiles を推奨.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        /// <exception cref="XmlStatusException"></exception>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folder/files/get", EndpointHttpMethod.GET)]
        public GetFilesResponseModel GetFiles(long folderId, int? offset = null, int? limit = null)
        {
            var response = Get<GetFilesResponse>(new NameValueCollection {
                { "folderId", folderId.ToString() },
                { "offset", offset?.ToString() },
                { "limit", limit?.ToString() }
            });
            if (response.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(response.Status);
            return response.Result;
        }
        /// <summary>
        /// ページング処理を内蔵したバージョン。通常はこちらのメソッド利用を推奨。
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="pageSize">※値は100まで指定可能</param>
        /// <returns></returns>
        public IEnumerable<FileModel> GetAllFiles( long folderId, int pageSize = 20 )
        {
            int currentPage = 1;
            while (true)
            {
                var res = GetFiles(folderId, currentPage, pageSize);
                if ( res.FileCount == 0 || res.Files == null)
                    yield break;
                foreach (var f in res.Files)
                    yield return f;
                if( res.FileCount < pageSize || currentPage * pageSize  >= res.FileAllCount )
                    yield break;
                currentPage++;
            }
        }

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/files/search", EndpointHttpMethod.GET)]
        public SearchFileResponse.CabinetFilesSearchResultModel SearchFile(int? fileId, string filePath, string fileName, int? folderId, string folderPath, int? offset = null, int? limit = null)
        {
            var res = Get<SearchFileResponse>(new NameValueCollection {
                { "fileId", fileId?.ToString() }, { "filePath", filePath?.ToString() }, { "fileName", fileName?.ToString() },
                { "folderId", folderId?.ToString() }, { "folderpath", folderPath },{ "offset", offset?.ToString() }, {"limit", limit?.ToString() }
            });
            if (res.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(res.Status);
            return res.CabinetFilesSearchResult;
        }
        /// <summary>
        /// ページング処理を内蔵してすべての FileModel を列挙します。
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="filePath"></param>
        /// <param name="fileName"></param>
        /// <param name="folderId"></param>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public IEnumerable<FileModel> SearchAllFiles(int? fileId, string filePath, string fileName, int? folderId, string folderPath)
        {
            int page = 1;
            int pageSize = 20;
            while (true)
            {
                var res = SearchFile(fileId, filePath, fileName, folderId, folderPath, page, pageSize);
                if (res.fileCount == 0 || res.Files == null)
                    yield break;
                foreach (var f in res.Files)
                    yield return f;
                if (res.fileCount < pageSize || page * pageSize >= res.fileAllCount)
                    yield break;
                page++;
            }
        }
        /// <summary>
        /// ファイル削除
        /// 成功時はステータスコードを返し、エラー　は例外が発生。
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns>ステータスコード</returns>
        /// <exception cref="XmlStatusException"></exception>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/delete", EndpointHttpMethod.POST)]
        public int DeleteFile(long fileId)
        {
            var res = Post<CabinetFileDeleteResultModel>(
                new CabinetFileDeleteRequestModel
                {
                    FileDeleteRequest = new CabinetFileDeleteRequestModel.fileDeleteRequest
                    {
                        File = new CabinetFileDeleteRequestModel.file { FileId = fileId }
                    }
                });
            if (res.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(res.Status);
            return res.CabinetFileDeleteResult.ResultCode;
        }
        /// <summary>
        /// 削除フォルダ内にある画像の一覧を取得
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/trashbox/files/get", EndpointHttpMethod.GET)]
        public GetFilesIntrashboxResponse GetFilesInTrashbox(int? offset = null, int? limit = null)
        {
            return Get<GetFilesIntrashboxResponse>(new NameValueCollection
            {
                { "offset", offset?.ToString() },
                { "limit", limit?.ToString() }
            });
        }
        /// <summary>
        /// ページングを内蔵したバージョン。
        /// </summary>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public IEnumerable<FileModel> GetAllFilesInTrashbox( int pageSize = 20)
        {
            int offset = 1;
            while (true)
            {
                var res = GetFilesInTrashbox(offset, pageSize);
                foreach( var f in res.Result.Files )
                    yield return f;
                if (res.Result.FileAllCount <= offset * pageSize)
                    break;
                offset++;
            }
        }
        /// <summary>
        /// 削除フォルダ内にある画像を指定したフォルダに戻す
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="folderId"></param>
        /// <returns>ResultCode</returns>
        /// <exception cref="XmlStatusException"></exception>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/trashbox/file/revert", EndpointHttpMethod.POST)]
        public int RevertFileInTrashbox(long fileId, int folderId)
        {
            var res = Post<RevertFileInTrashboxResponse>(
                new RevertFileInTrashboxRequest
                {
                    FileRevertRequest = new RevertFileInTrashboxRequest.fileRevertRequest
                    {
                        File = new RevertFileInTrashboxRequest.fileRevertRequest.FileModel
                        {
                            FileId = fileId,
                            FolderId = folderId
                        }
                    }
                });
            if (res.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(res.Status);
            return res.Result.ResultCode;
        }
        /// <summary>
        /// 画像ファイルを指定して画像を登録
        /// </summary>
        /// <param name="folderId">登録先フォルダID</param>
        /// <param name="fileName">登録画像名
        /// 50バイト以内（全角25文字以内/半角50文字以内）
        /// 使用禁止文字 ： 機種依存文字（コントロールコード除く）、半角カタカナ
        /// 全角スペース → 半角スペースに変換
        /// スペースのみは不可
        /// 前後にスペースがある場合は、スペースを自動削除
        /// タグは無効（入力した場合は、タグと判断されたものを削除して表示）
        /// </param>
        /// <param name="filePath">登録file名<br/>
        /// 20バイト以内（半角20文字以内）<br/>
        /// デフォルト値 ： img[数字8桁].gif / jpg or imgrc[数字10桁].gif / jpg<br/>
        /// 入力可能文字 ： 半角英数字（小文字）/記号は「-」「_」のみ<br/>
        /// 使用禁止文字 ： 機種依存文字（コントロールコード含む）、img+8桁の数字、imgrc+10桁の数字<br/>
        /// スペースのみ/字間にスペースは不可<br/>
        /// 前後にスペースがある場合は、スペースは自動削除<br/>
        /// タグは無効（入力した場合はタグと判断されたものを削除して表示）<br/>
        /// </param>
        /// <param name="overWrite">上書きフラグ デフォルト値 ： false</param>
        /// <param name="file"></param>
        /// <returns></returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/insert", EndpointHttpMethod.POST)]
        public long InsertFile(int folderId, string fileName, Stream file, string filePath = null, bool? overWrite = null )
        {
            if( string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException(nameof(fileName));
            if (file == null )
                throw new ArgumentNullException(nameof(file));
            var req = new InsertFileRequest
            {
                Request = new InsertFileRequest.fileInsertRequest
                {
                    File = new InsertFileRequest.file { folderId = folderId, fileName = fileName, filePath = filePath, overWrite = overWrite }
                }
            };
            var sb = new StringBuilder();
            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            var sz = new XmlSerializer(typeof(InsertFileRequest));
            var sw = new Utf8StringWriter(sb);
            sz.Serialize(sw, req, ns);
            sb.Append("\r\n");
            string contentType = "image/png";
            var response = PostFile<InsertFileResponse>(
                "https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/insert", file, "file", contentType,
                new NameValueCollection {
                    {"file", "file.png"},
                    {"xml", sb.ToString() }
                });
            if (response.Status.SystemStatus == SystemStatus.OK)
                return response.cabinetFileInsertResult.FileId;
            throw new XmlStatusException(response.Status);
        }
        private class Utf8StringWriter : StringWriter
        {
            public Utf8StringWriter( StringBuilder sb) : base(sb) { }
            public override Encoding Encoding => Encoding.UTF8;
        }
        /// <summary>
        /// 画像IDを指定して画像情報を更新
        /// </summary>
        /// <param name="fileId">画像ID</param>
        /// <param name="fileName">更新画像名
        /// 50バイト以内（全角25文字以内/半角50文字以内）
        ///         使用禁止文字：機種依存文字（コントロールコード除く）、半角カタカナ
        ///         全角スペース → 半角スペースに変換
        ///         スペースのみは不可
        ///         前後にスペースがある場合は、スペースを自動削除
        ///         タグは無効（入力した場合は、タグと判断されたものを削除して更新）</param>
        /// <param name="filePath">更新ファイル名
        /// 20バイト以内（半角20文字以内）
        /// renameのみmoveはしない
        ///         登録時にdefaultで設定した場合、img + 別数字,imgrc + 別数字の形式へは変更不可
        ///         登録時と同じ値は指定不可
        ///         入力可能な文字は、半角英数字（小文字）/記号は「-」「_」のみ
        ///         使用禁止文字：機種依存文字（コントロールコード含む）、img+8桁の数字、imgrc+10桁の数字
        ///         スペースのみ/字間にスペースは不可(スペースのみの場合は更新しない)
        ///         前後にスペースがある場合は、スペースは自動削除
        ///         タグは無効（入力した場合はタグと判断されたものを削除して更新）
        ///         </param>
        /// <param name="file"></param>
        /// <returns>ResultCode</returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/update", EndpointHttpMethod.POST)]
        public int UpdateFile(int fileId, string fileName = null, Stream file = null, string filePath = null )
        {
            if (fileName == null && file == null && filePath == null)
                throw new ArgumentNullException("Any of parameters must be specified.");

            var req = new UpdateFileRequest
            {
                Request = new UpdateFileRequest.fileUpdateRequest
                {
                    File = new UpdateFileRequest.file { fileId = fileId, fileName = fileName, filePath = filePath }
                }
            };
            var sb = new StringBuilder();
            var sz = new XmlSerializer(typeof(UpdateFileRequest));
            var sw = new System.IO.StringWriter(sb);
            sz.Serialize(sw, req);

            string contentType = "image/jpeg";
            var res = PostFile<UpdateFileResponse>("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/update", file, "file", contentType,
                new System.Collections.Specialized.NameValueCollection {
                    {"file", "file.jpg"},
                    {"xml", sb.ToString() }
                });
            if (res.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(res.Status);
            return res.cabinetFileUpdateResult.ResultCode;
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folder/insert", EndpointHttpMethod.POST)]
        public long CreateFolder(string folderName, string directoryName = null, int? upperFolderId = null)
        {
            var result = Post<CreateFolderResponse>(
                new CreateFolderRequest
                {
                    FolderInsertRequest = new CreateFolderRequest.folderInsertRequest
                    {
                        Folder = new CreateFolderRequest.folderInsertRequest.folder
                        {
                            FolderName = folderName,
                            DirectoryName = directoryName,
                            UpperFolderId = upperFolderId
                        }
                    }
                });
            if( result.Status.SystemStatus != SystemStatus.OK)
                throw new XmlStatusException(result.Status);

            return result.Result.FolderId;
        }

    }
}
