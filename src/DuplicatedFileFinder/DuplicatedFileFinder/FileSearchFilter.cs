using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatedFileFinder
{
    internal class FileSearchFilter
    {
        public string Extensions { get; set; }
        public FileAttributes Attributes { get; set; }
        public FileSizeFilter Size { get; set; }
        public FileSearchFilter()
        {
            Extensions = string.Empty;
            Attributes = FileAttributes.Normal 
                        | FileAttributes.Archive 
                        | FileAttributes.Temporary
                        | FileAttributes.ReadOnly
                        | FileAttributes.System 
                        | FileAttributes.Hidden;
            Size = new FileSizeFilter();
        }
    }
}
