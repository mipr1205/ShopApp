using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Files
{
    public class FileStoreJSON:IFileLocator
    {
        private readonly DirectoryInfo workingDirectory;

        
        public FileStoreJSON(DirectoryInfo workingDirectory)
        {
            if (workingDirectory == null)
                throw new ArgumentNullException();
            if (!workingDirectory.Exists)
                throw new ArgumentException("Directory dosn't exist", "workingDirectory");
            this.workingDirectory = workingDirectory;
        }

        public FileInfo GetFileInfo(string fileName)
        {
            return new FileInfo(
                Path.Combine(this.workingDirectory.FullName, fileName + ".json"));
        }
    }
}
