using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    internal class LoggingProxy : IDataset
    {
        private Dataset dataset;
        private string filePath;
        private ConsoleLogger logger;
        public LoggingProxy(string filePath)
        {
            this.filePath = filePath;
            this.logger = ConsoleLogger.GetInstance();
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }

            string logMessage = $"Time : {DateTime.Now}";
            logger.Log(logMessage);
            logger.Log("Pristup metodi GetData()");
            return dataset.GetData();
        }
    }
}
