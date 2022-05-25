using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Services
{
    internal class Starter
    {

        public void Run()
        {
            Random random = new Random();
            Actions actions = new Actions();
            Models.Logger log = new Models.Logger();
            Files.FileService file = new Files.FileService();
            Models.EnterString str = new Models.EnterString();

            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    int nxt = random.Next(1, 4);
                    if (nxt == 1)
                    {
                        actions.StartMethod();
                    }
                    else if (nxt == 2)
                    {
                        actions.SkippedLogicInMethod();
                    }
                    else if (nxt == 3)
                    {
                        actions.ErrorMethod();
                    }
                }
            }
            catch (Services.BussinesException exb)
            {
                file.Write(str.InfoString, "Warning");
            }
            catch (Exception ex)
            {
                file.Write(str.InfoString, "Error");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
