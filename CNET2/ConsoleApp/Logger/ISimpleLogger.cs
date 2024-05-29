using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Logger
{
    internal interface ISimpleLogger
    {
        void Log(string message);

        void Log(Exception ex);
    }
}
