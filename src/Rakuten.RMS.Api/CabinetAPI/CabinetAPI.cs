using System;
using System.Collections.Specialized;
using System.Text;
using System.Xml.Serialization;
using Rakuten.RMS.Api.XML;

namespace Rakuten.RMS.Api.CabinetAPI
{
    public class CabinetAPI : RakutenApiXmlClientBase
    {
        public class FileModel
        {
            public int FolderId { get; set; }
            public string FolderName { get; set; }
            public int FolderNode { get; set; }
            public string FolderPath { get; set; }
            public int FileId { get; set; }
            public string FileName { get; set; }
            public string FileUrl { get; set; }
            public string FilePath { get; set; }
            public int FileType { get; set; }
            public decimal FileSize { get; set; }
            public int FileWidth { get; set; }
            public int FileHeight { get; set; }
            [XmlIgnore]
            public DateTime FileAccessDate
            {
                get
                {
                    DateTime _dt;
                    return DateTime.TryParse(_FileAccessDateRaw, out _dt) ? _dt : DateTime.MinValue;
                }
            }
            [XmlElement("FileAccessDate")]
            public string _FileAccessDateRaw { get; set; }
            [XmlIgnore]
            public DateTime TimeStamp { get { DateTime _dt; return DateTime.TryParse(_TimeStampRaw, out _dt) ? _dt : DateTime.MinValue; } }
            [XmlElement("TimeStamp")]
            public string _TimeStampRaw { get; set; }

        }

        public CabinetAPI(ServiceProvider provider) : base(provider)
        {

        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/usage/get", EndpointHttpMethod.GET)]
        public GetUsageResponse GetUsage()
        {
            return Get<GetUsageResponse>();
        }


        [XmlRoot("result")]
        public class GetUsageResponse
        {
            [XmlElement("status")]
            public XmlStatus Status { get; set; }
            [XmlElement("cabinetUsageGetResult")]
            public CabinetUsageGetResultModel Result { get; set; }
        }

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folders/get", EndpointHttpMethod.GET)]
        public GetFoldersResponse GetFolders(int? offset = null, int? limit = null)
        {
            return Get<GetFoldersResponse>(new NameValueCollection {
                { "offset", offset.ToString() }, {"limit", limit.ToString() }
            });
        }
        [XmlRoot("result")]
        public class GetFoldersResponse : ResultBase
        {
            [XmlElement("cabinetFoldersGetResult")]
            public ResultModel Result { get; set; }

            public class ResultModel
            {
                [XmlElement("resultCode")]
                public int ResultCode { get; set; }
                [XmlElement("folderAllCount")]
                public int FolderAllCount { get; set; }
                [XmlElement("folderCount")]
                public int FolderCount { get; set; }
                [XmlArray("folders")]
                [XmlArrayItem("folder")]
                public FolderModel[] Folders { get; set; }
            }
            public class FolderModel
            {
                [XmlElement("FolderId")]
                public int FolderId { get; set; }
                [XmlElement("FolderName")]
                public string FolderName { get; set; }
                [XmlElement("FolderNode")]
                public int FolderNode { get; set; }
                [XmlElement("FolderPath")]
                public string FolderPath { get; set; }
                [XmlElement("FileCount")]
                public int FileCount { get; set; }
                [XmlElement("FileSize")]
                public decimal FileSize { get; set; }
                [XmlIgnore]
                public DateTime TimeStamp { get => DateTime.Parse(_TimeStampRaw); }
                [XmlElement("TimeStamp")]
                public string _TimeStampRaw { get; set; }

            }

        }

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folder/files/get", EndpointHttpMethod.GET)]
        public GetFilesResponse GetFiles(int folderId, int? offset = null, int? limit = null)
        {
            return Get<GetFilesResponse>(new NameValueCollection {
                { "folderId", folderId.ToString() }, {"offset", offset?.ToString() }, {"limit", limit?.ToString() }
            });
        }
        [XmlRoot("result")]
        public class GetFilesResponse : ResultBase
        {
            [XmlElement("cabinetFolderFilesGetResult")]
            public GetFilesResponseModel Result { get; set; }

            public class GetFilesResponseModel
            {
                [XmlElement("resultCode")]
                public int ResultCode { get; set; }
                [XmlElement("fileAllCount")]
                public int FileAllCount { get; set; }
                [XmlElement("fileCount")]
                public int FileCount { get; set; }
                [XmlArray("files")]
                [XmlArrayItem("file")]
                public FileModel[] Files { get; set; }
            }
        }

        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/files/search", EndpointHttpMethod.GET)]
        public SearchFileResponse SearchFile(int? fileId, string filePath, string fileName, int? folderId, string folderPath, int? offset = null, int? limit = null)
        {
            return Get<SearchFileResponse>(new NameValueCollection {
                { "fileId", fileId?.ToString() }, { "filePath", filePath?.ToString() }, { "fileName", fileName?.ToString() },
                { "folderId", folderId?.ToString() }, { "folderpath", folderPath },{ "offset", offset?.ToString() }, {"limit", limit?.ToString() }
            });
        }
        [XmlRoot("result")]
        public class SearchFileResponse : ResultBase
        {
            [XmlElement("cabinetFilesSearchResult")]
            public CabinetFilesSearchResultModel CabinetFilesSearchResult { get; set; }
            public class CabinetFilesSearchResultModel
            {
                [XmlElement("resultCode")]
                public int resultCode { get; set; }
                [XmlElement("fileAllCount")]
                public int fileAllCount { get; set; }
                [XmlElement("fileCount")]
                public int fileCount { get; set; }
                [XmlArray("files")]
                [XmlArrayItem("file")]
                public FileModel[] Files { get; set; }

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
        [XmlRoot("request")]
        public class CabinetFileDeleteRequestModel
        {
            [XmlElement("fileDeleteRequest")]
            public fileDeleteRequest FileDeleteRequest { get; set; }
            public class fileDeleteRequest
            {
                [XmlElement("file")]
                public file File { get; set; }
            }
            public class file
            {
                [XmlElement("fileId")]
                public int FileId { get; set; }
            }

        }
        [XmlRoot("result")]
        public class CabinetFileDeleteResultModel : ResultBase
        {
            [XmlElement("cabinetFileDeleteResult")]
            public cabinetFileDeleteResult CabinetFileDeleteResult { get; set; }
            public class cabinetFileDeleteResult
            {
                [XmlElement("resultCode")]
                public int ResultCode { get; set; }
            }
        }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/trashbox/files/get", EndpointHttpMethod.GET)]
        public GetFilesIntrashboxResponse GetFilesIntrashbox(int? offset = null, int? limit = null)
        {
            return Get<GetFilesIntrashboxResponse>(new NameValueCollection
            {
                { "offset", offset?.ToString() }, {"limit",limit?.ToString() }
            });
        }
        [XmlRoot("result")]
        public class GetFilesIntrashboxResponse : ResultBase
        {
            [XmlElement("cabinetTrashboxFilesGetResult")]
            public cabinetTrashboxFilesGetResult Result { get; set; }

            public class cabinetTrashboxFilesGetResult
            {
                [XmlElement("resultCode")]
                public int ResultCode { get; set; }
                [XmlElement("fileAllCount")]
                public int FileAllCount { get; set; }
                [XmlElement("fileCount")]
                public int FileCount { get; set; }

                [XmlArray("files")]
                [XmlArrayItem("file")]
                public FileModel[] Files { get; set; }
            }
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
        [XmlRoot("request")]
        public class RevertFileInTrashboxRequest
        {
            [XmlElement("fileRevertRequest")]
            public fileRevertRequest FileRevertRequest { get; set; }
            public class fileRevertRequest
            {
                [XmlElement("file")]
                public FileModel File { get; set; }
                public class FileModel
                {
                    [XmlElement("fileId")]
                    public int FileId { get; set; }
                    [XmlElement("folderId")]
                    public int FolderId { get; set; }
                }
            }
        }
        [XmlRoot("result")]
        public class RevertFileInTrashboxResponse : ResultBase
        {
            [XmlElement("cabinetTrashboxFileRevertResult")]
            public cabinetTrashboxFileRevertResult Result { get; set; }
            public class cabinetTrashboxFileRevertResult
            {
                [XmlElement("resultCode")]
                public int ResultCode { get; set; }
            }
        }

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
        [XmlRoot("request")]
        public class UpdateFileRequest
        {
            [XmlElement("fileUpdateRequest")]
            public fileUpdateRequest Request { get; set; }

            public class fileUpdateRequest
            {
                [XmlElement("file")]
                public file File { get; set; }
            }
            public class file
            {
                public int fileId { get; set; }
                public string fileName { get; set; }
                public string filePath { get; set; }
            }
        }
        [XmlRoot("result")]
        public class UpdateFileResponse : ResultBase { }
        [EndpointDefinition("https://api.rms.rakuten.co.jp/es/1.0/cabinet/folder/insert", EndpointHttpMethod.POST)]
        public CreateFolderResponse CreateFolder(string folderName, string directoryName = null, int? upperFolderId = null)
        {
            return Post<CreateFolderResponse>(
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
        }
        [XmlRoot("request")]
        public class CreateFolderRequest
        {
            public folderInsertRequest FolderInsertRequest { get; set; }
            public class folderInsertRequest
            {
                [XmlElement("folder")]
                public folder Folder { get; set; }
                public class folder
                {
                    [XmlElement("folderName")]
                    public string FolderName { get; set; }
                    [XmlElement("directoryName")]
                    public string DirectoryName { get; set; }
                    [XmlElement("upperFolderId")]
                    public int? UpperFolderId { get; set; }
                }
            }
        }
        [XmlRoot("result")]
        public class CreateFolderResponse : ResultBase
        {
            [XmlElement("cabinetFolderInsertResult")]
            public cabinetFolderInsertResult Result { get; set; }
            public class cabinetFolderInsertResult
            {
                [XmlElement("resultCode")]
                public int resultCode { get; set; }
                [XmlElement("FolderId")]
                public int FolderId { get; set; }
            }

        }
    }
}
