using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Logger_2._0.Files
{
    internal class FileService : Interfaces.IFile
    {
        public void Write(string str, string type)
        {
            Models.LoggerConfigs logger = new Models.LoggerConfigs();
            Services.CheckUp checkUp = new Services.CheckUp();

            str = checkUp.Checking(type);

            var line = DateTime.Now.ToString("hh:mm:ss dd:MM:yyyy");
            string path = logger.DirectoryPath + line + ".txt";

            using (FileStream fs = File.Create(path))
            {
                byte[] input = Encoding.Default.GetBytes(str);
                fs.Write(input, 0, input.Length);
            }

            var config = new Models.LoggerConfigs
            {
                Time = line,
                Name = str,
                Path = path
            };

            string jsonString = JsonSerializer.Serialize(config);
            File.WriteAllText(@"D:\C# A level\Logger-2.0\Logger-2.0\file.json", jsonString);
        }
    }
}
