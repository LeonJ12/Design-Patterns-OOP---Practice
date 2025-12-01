using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2_JL
{
    class FileLogger : ILogger
    {
        private string FilePath;
        public void Log(ILogable data)
        {
            using (System.IO.StreamWriter writer =
new System.IO.StreamWriter(this.FilePath))
            {
                writer.WriteLine(data.GetStringRepresentation());
            }
        }
        public FileLogger(string filePath)
        {
            this.FilePath = filePath;
        }
    }
}

