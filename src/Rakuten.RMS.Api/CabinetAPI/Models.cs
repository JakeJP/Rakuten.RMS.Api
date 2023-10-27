using Rakuten.RMS.Api.XML;
using System;
using System.Xml.Serialization;

namespace Rakuten.RMS.Api.CabinetAPI
{

    [XmlRoot("result")]
    public class CabinetUsageGetResultModel
    {
        [XmlElement("resultCode")]
        public int ResultCode { get; set; }
        [XmlElement("MaxSpace")]
        public int MaxSpace { get; set; }
        [XmlElement("FolderMax")]
        public int FolderMax { get; set; }
        [XmlElement("FileMax")]
        public int FileMax { get; set; }
        [XmlElement("UseSpace")]
        public decimal UseSpace { get; set; }
        [XmlElement("AvailSpace")]
        public decimal AvailSpace { get; set; }
        [XmlElement("UseFolderCount")]
        public int UseFolderCount { get; set; }
        [XmlElement("AvailFolderCount")]
        public int AvailFolderCount { get; set; }
    }



    [XmlRoot("result")]
    public class GetUsageResponse
    {
        [XmlElement("status")]
        public XmlStatus Status { get; set; }
        [XmlElement("cabinetUsageGetResult")]
        public CabinetUsageGetResultModel Result { get; set; }
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
            public long FileId { get; set; }
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
                public long FileId { get; set; }
                [XmlElement("folderId")]
                public long FolderId { get; set; }
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
    [XmlRoot("request")]
    public class InsertFileRequest
    {
        [XmlElement("fileInsertRequest")]
        public fileInsertRequest Request { get; set; }

        public class fileInsertRequest
        {
            [XmlElement("file")]
            public file File { get; set; }
        }
        public class file
        {
            public string fileName { get; set; }
            public long? folderId { get; set; }
            public string filePath { get; set; }
            public bool? overWrite { get; set; }
        }
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
            public long fileId { get; set; }
            public string fileName { get; set; }
            public string filePath { get; set; }
        }
    }
    [XmlRoot("request")]
    public class CreateFolderRequest
    {
        [XmlElement("folderInsertRequest")]
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
                public long? UpperFolderId { get; set; }
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
            public int ResultCode { get; set; }
            [XmlElement("FolderId")]
            public long FolderId { get; set; }
        }

    }
}
