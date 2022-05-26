using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Models
{
    internal class Logger
    {
        public string LoggerType { get; set; }

        public string LoggerWarning { get; } = "Action got this custom Exception";

        public string LoggerError { get; } = "Action failed by a reason";
        public Logger() { }

        public Logger(string type)
        {
            LoggerType = type;
        }
    }
}
