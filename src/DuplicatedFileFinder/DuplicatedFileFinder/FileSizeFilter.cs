using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatedFileFinder
{
    public enum SizeCondition
    { 
        LessThan = 0,
        Equal = 1,
        GreaterThan = 2,
    }
    public enum SizeUnit
    {
        Bi=0,
        KB,
        MB,
        GB,
        TB,
        PB
    }

    internal class FileSizeFilter
    { 
        public SizeCondition Condition  { get; set; }
        public long Value { get; set; }
        public SizeUnit Unit { get; set; }
        public FileSizeFilter()
        {
            Condition = SizeCondition.GreaterThan;
            Value = 0;
            Unit = SizeUnit.Bi;
        }
    }
}
