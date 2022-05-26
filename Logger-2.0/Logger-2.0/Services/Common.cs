using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_2._0.Services
{
    internal class Common : Interfaces.ICommon
    {
        public void GetWork(Interfaces.IFile file)
        {
            file.Write()
        }
    }
}
