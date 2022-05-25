using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Models
{
    internal class LoggerConfigs
    {
        public string DirectoryPath { get; } = @"D:\C# A level\Logger-2.0\Logger-2.0\bin\";

        public string Time { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public LoggerConfigs() { }
    }
}
