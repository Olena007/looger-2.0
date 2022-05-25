using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Services
{
    internal class CheckUp
    {
        public string Checking(string type)
        {
            Models.Logger info = new Models.Logger("Info");
            Models.Logger warning = new Models.Logger("Warning");
            Models.Logger error = new Models.Logger("Error");
            Models.Logger log = new Models.Logger();

            string str = string.Empty;

            if (type == "Info")
            {
                str = $"{DateTime.Now:H:mm:ss} {info} {Environment.NewLine}";
            }
            else if (type == "Warning")
            {
                str = $"{DateTime.Now:H:mm:ss} {warning}  {log.LoggerWarning} {Environment.NewLine}";
            }
            else if (type == "Error")
            {
                str = $"{DateTime.Now:H:mm:ss} {error}  {log.LoggerError} {Environment.NewLine}";
            }

            Models.EnterString enter = new Models.EnterString(str);

            return str;
        }
    }
}
