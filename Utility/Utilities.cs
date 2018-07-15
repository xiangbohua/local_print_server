using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Utility
{
    public class Utilities
    {
        #region 无效文件字符
        private static readonly char[] InvalidFileNameChars = new[]
        {
        '"',

        '<',

        '>',

        '|',

        '\0',

        '\u0001',

        '\u0002',

        '\u0003',

        '\u0004',

        '\u0005',

        '\u0006',

        '\a',

        '\b',

        '\t',

        '\n',

        '\v',

        '\f',

        '\r',

        '\u000e',

        '\u000f',

        '\u0010',

        '\u0011',

        '\u0012',

        '\u0013',

        '\u0014',

        '\u0015',

        '\u0016',

        '\u0017',

        '\u0018',

        '\u0019',

        '\u001a',

        '\u001b',

        '\u001c',

        '\u001d',

        '\u001e',

        '\u001f',

        ':',

        '*',

        '?',

        '\\',

        '/'
        };
        #endregion

        //过滤方法

        public static string CleanInvalidFileName(string fileName)
        {
            fileName = fileName + "";

            fileName = InvalidFileNameChars.Aggregate(fileName, (current, c) => current.Replace(c + "", ""));
            if (fileName.Length > 1)

                if (fileName[0] == '.')
                    fileName = "dot" + fileName.TrimStart('.');

            return fileName;

        }

        


        public static bool IsSuffixMatchWithGivingIngnoreCase(string fileFullName, string suffixGiving)
        {
            if (Path.GetExtension(fileFullName) == null)
            {
                return false;
            }
            else
            {
                string extension = Path.GetExtension(fileFullName);
                return extension.ToLower() == "." + suffixGiving.ToLower() ? true : false;
            }
        }

        public static bool IsSuffixMatchWithGiving(string fileFullName, string suffixGiving)
        {
            if (Path.GetExtension(fileFullName) == null)
            {
                return false;
            }
            else
            {
                string extension = Path.GetExtension(fileFullName);
                return extension == "." + suffixGiving ? true : false;
            }
        }


        public static string ReplaceFileExtension(string fileName, string targateExtension)
        {
            string dic = Path.GetDirectoryName(fileName);
            if (String.IsNullOrEmpty(dic))
            {
                return Path.GetFileNameWithoutExtension(fileName) + "." + targateExtension;
            }
            return Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + "." + targateExtension;
        }

        public static void DeleteFilesInDir(string dir)
        {
            if (Directory.Exists(dir))
            {
                foreach (string fileName in Directory.GetFiles(dir))
                {
                    File.Delete(fileName);
                }
            }
        }

        public static void DeleteDir(string dir)
        {
            if (Directory.Exists(dir))
            {
                foreach (string fileName in Directory.GetFiles(dir))
                {
                    File.Delete(fileName);
                }
                Directory.Delete(dir);
            }
        }
        

        /// <summary>
        /// 判断文件名是否为图片，目前只识别PNG，JPEG，JPG
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static bool IsImageFile(string filePath)
        {
            return IsSuffixMatchWithGivingIngnoreCase(filePath, "PNG") ||
                   IsSuffixMatchWithGivingIngnoreCase(filePath, "JPG") || IsSuffixMatchWithGivingIngnoreCase(filePath, "JPEG") || IsSuffixMatchWithGivingIngnoreCase(filePath, "GIF");
        }

        /// <summary>
        /// 创建文件夹(没有就创建，有就不做处理)
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static string CreateDir(string dir)
        {
            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            catch (DirectoryNotFoundException exception)
            {
                throw;
            }
            return dir;
        }

        public static bool IsExtensionMatched(string fileName, string extensionGiving)
        {
            string extension = Path.GetExtension(fileName);
            if (extension == null)
            {
                return false;
            }
            else
            {
                return extension.ToLower() == "." + extensionGiving.ToLower() ? true : false;
            }
        }

        //public static void WriteFile(String dir, string fileName, string fileContent)

        //将字符写入文件,接受文件名用来标示输出的txt文件
        public static void WriteFile(String dir, string fileName, string fileContent)
        {
            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string filename = dir + "/" + fileName;
                if (File.Exists(fileName))
                {
                    File.Delete(filename);
                }

                using (FileStream saveFileStream = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    using (StreamWriter swr = new StreamWriter(saveFileStream, Encoding.Default))
                    {
                        swr.Write(fileContent);
                        swr.Close();
                    }
                }
            }
            catch (IOException e)
            {
                throw;
            }
        }
        
    }
}
