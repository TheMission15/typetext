using System;
using System.Xml.Linq;

namespace typetext.Logic
{
    public class BoolInt
    {
        public bool Result { get; set; }
        public int Value { get; set; }
        public BoolInt(bool result, int value)
        {
            Result = result; Value = value;
        }
    }
}
