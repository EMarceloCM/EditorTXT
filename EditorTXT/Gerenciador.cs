using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTXT
{
    internal static class Gerenciador
    {
        public static string DefaultFolderPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static string DefaultFileName => "arquivo";
        public static string DefaultFileExt => ".txt";

        public static string FolderPath { get; set; } = DefaultFolderPath;
        public static string FileName { get; set; } = DefaultFileName;
        public static string FileExt { get; set; } = DefaultFileExt;
        public static string FilePath => Path.Combine(FolderPath, FileName) + FileExt;

        public static void setFileSettings(FileInfo file)
        {
            Gerenciador.FolderPath = file.DirectoryName + "\\";
            Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
            Gerenciador.FileExt = file.Extension;
        }
    }
}
