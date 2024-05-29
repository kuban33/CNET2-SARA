using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Logger
{
    internal class SimpleFileLogger : ISimpleLogger
    {
        private string _file;
        public SimpleFileLogger(string file)
        {
            _file = file;
        }
        public void Log(string message)
        {
            var line = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {message}";
            File.AppendAllText(_file, Environment.NewLine + line);
        }

        public void Log(Exception ex)
        {
            var line = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} {ex.Message}";
            File.AppendAllText(_file, Environment.NewLine + line);
        }
    }
}
