using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatedFileFinder
{
    internal class DuplicatedCriteria
    {
        public bool Content { get; set; }
        public bool Name { get; set; }
        public bool Size { get; set; }
        public bool Attributes { get; set; }
        public bool ModifiedDate { get; set; }

        public DuplicatedCriteria(bool content = false, bool name=false, bool size=false, bool attrs=false, bool modifieddate = false)
        {
            Content = content;
            Name = name;
            Size = size;
            Attributes = attrs;
            ModifiedDate = modifieddate;
        }
    }
}
