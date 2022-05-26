using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Services
{
    internal class Actions
    {
        Files.FileService file = new Files.FileService();
        Models.EnterString str = new Models.EnterString();

        public bool StartMethod()
        {
            file.Write(str.InfoString, "Info");

            return true;
        }

        public bool SkippedLogicInMethod()
        {
            throw new Services.BussinesException("Skipped logic in method");
        }

        public void ErrorMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
