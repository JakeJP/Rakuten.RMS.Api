using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;
using static Rakuten.RMS.Api.CabinetAPI.GetFilesResponse;

namespace Rakuten.RMS.Api.CabinetAPI
{
    public class CabinetAPI : RakutenApiXmlClientBase
    {
        public CabinetAPI(ServiceProvider provider) : base(provider)
        {

        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/usage/get", EndpointHttpMethod.GET)]
        public CabinetUsageGetResultModel GetUsage()
        {
            var res = Get<GetUsageResponse>();
            if (res.Status.SystemStatus != "OK")
                throw new InvalidOperationException($"{res.Status.SystemStatus} {res.Status.Message}");
            return res.Result;
        } 


        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folders/get", EndpointHttpMethod.GET)]
        public GetFoldersResponse.ResultModel GetFolders(int? offset = null, int? limit = null)
        {
            var response = Get<GetFoldersResponse>(new NameValueCollection {
                { "offset", offset.ToString() },
                {"limit", limit.ToString() }
            });
            if (response.Status.SystemStatus != "OK")
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

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folder/files/get", EndpointHttpMethod.GET)]
        public GetFilesResponseModel GetFiles(int folderId, int? offset = null, int? limit = null)
        {
            var response = Get<GetFilesResponse>(new NameValueCollection {
                { "folderId", folderId.ToString() },
                { "offset", offset?.ToString() },
                { "limit", limit?.ToString() }
            });
            if (response.Status.SystemStatus != "OK")
                throw new XmlStatusException(response.Status);
            return response.Result;
        }
        /// <summary>
        /// ページング処理をラップしたバージョン。通常はこちらのメソッド利用を推奨。
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="pageSize">※値は100まで指定可能</param>
        /// <returns></returns>
        public IEnumerable<FileModel> GetAllFiles( int folderId, int pageSize = 20 )
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
            if (res.Status.SystemStatus != "OK")
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
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/delete", EndpointHttpMethod.POST)]
        public CabinetFileDeleteResultModel DeleteFile(int fileId)
        {
            return Post<CabinetFileDeleteResultModel>(
                new CabinetFileDeleteRequestModel
                {
                    FileDeleteRequest = new CabinetFileDeleteRequestModel.fileDeleteRequest
                    {
                        File = new CabinetFileDeleteRequestModel.file { FileId = fileId }
                    }
                });
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/trashbox/files/get", EndpointHttpMethod.GET)]
        public GetFilesIntrashboxResponse GetFilesIntrashbox(int? offset = null, int? limit = null)
        {
            return Get<GetFilesIntrashboxResponse>(new NameValueCollection
            {
                { "offset", offset?.ToString() }, {"limit",limit?.ToString() }
            });
        }

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/trashbox/file/revert", EndpointHttpMethod.POST)]
        public RevertFileInTrashboxResponse RevertFileInTrashbox(int fileId, int folderId)
        {
            return Post<RevertFileInTrashboxResponse>(
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
        }

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/insert", EndpointHttpMethod.POST)]
        public UpdateFileResponse InsertFile(int? folderId, string fileName = null, string filePath = null, bool? overWrite = null, System.IO.FileStream file = null)
        {
            var req = new InsertFileRequest
            {
                Request = new InsertFileRequest.fileInsertRequest
                {
                    File = new InsertFileRequest.file { folderId = folderId, fileName = fileName, overWrite = overWrite }
                }
            };
            var sb = new StringBuilder();
            var sz = new XmlSerializer(typeof(UpdateFileRequest));
            var sw = new System.IO.StringWriter(sb);
            sz.Serialize(sw, req);

            string contentType = "image/jpeg";
            return PostFile<UpdateFileResponse>("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/insert", file, "file", contentType,
                new System.Collections.Specialized.NameValueCollection {
                    //{"file", "file.jpg"},
                    {"xml", sb.ToString() }
                });

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
        /// <returns></returns>
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/update", EndpointHttpMethod.POST)]
        public UpdateFileResponse UpdateFile(int fileId, string fileName = null, string filePath = null, System.IO.FileStream file = null)
        {
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
            return PostFile<UpdateFileResponse>("https://api.rms.rakuten.co.jp/es/1.0/cabinet/file/update", file, "file", contentType,
                new System.Collections.Specialized.NameValueCollection {
                    {"file", "file.jpg"},
                    {"xml", sb.ToString() }
                });

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
            if( result.Status.SystemStatus != "OK" )
                throw new XmlStatusException(result.Status);

            return result.Result.FolderId;
        }

    }
}
