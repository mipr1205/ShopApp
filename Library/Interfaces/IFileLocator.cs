using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Interfaces
{
    interface IFileLocator
    {
        FileInfo GetFileInfo(string fileName);
    }
}
