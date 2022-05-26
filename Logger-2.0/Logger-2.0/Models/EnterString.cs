using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Models
{
    internal class EnterString
    {
        public string InfoString { get; set; }

        public EnterString() { }

        public EnterString(string str) : base()
        {
            InfoString = str;
        }
    }
}
