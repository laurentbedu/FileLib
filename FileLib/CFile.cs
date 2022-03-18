using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLib
{
    public class CFile
    {
        public FileInfo Info { get; private set; }
        public bool Exists { get { return File.Exists(Info.FullName); } }

        public CFile(string fileName, string directoryPath = "")
        {
            //TODO Check fileName and directoryPath
            string fullFileName = Path.Combine(directoryPath, fileName);
            Info = new FileInfo(fullFileName);
        }

        public CFile? Create(bool overWrite = false)
        {
            try
            {
                if (!Info.Directory.Exists)
                {
                    Info.Directory.Create();
                }
                if (overWrite || !Exists)
                {
                    Info.Create().Close();
                }
            }
            catch (Exception)
            {
                return null;
            }
            return this;
        }

        
        public bool? Delete()
        {
            try
            {
                if (Exists)
                {
                    Info.Delete();
                }
            }
            catch (Exception)
            {
                return null;
            }
            return !Exists;
        }

        public bool? WriteText(string text, bool owerWrite = false)
        {
            try
            {
                Create(owerWrite);
                File.AppendAllText(Info.FullName, text);
            }
            catch (Exception)
            {
                return null;
            }
            return true;
        }

        public string? ReadText()
        {
            string? result;
            try
            {
                result = File.ReadAllText(Info.FullName);
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public bool CopyTo(string directoryPath, string renamedFileName = "", bool overWrite = false)
        {
            return false;
        }

        public bool MoveTo(string directoryPath, string renamedFileName = "", bool overWrite = false)
        {
            return false;
        }


    }
}
