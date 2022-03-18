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
            //TODO ...
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

        
        public bool Delete()
        {
            return false;
        }

        public bool WriteText(string text) 
        { 
            return false; 
        }

        public string ReadText()
        {
            return "";
        }

        public bool CopyTo(string destFolder)
        {
            return false;
        }

        public bool MoveTo(string destFolder)
        {
            return false;
        }


    }
}
