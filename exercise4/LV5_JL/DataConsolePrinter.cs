using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
     class DataConsolePrinter
    {
        public void PrintData(IDataset dataset)
        {
            if (dataset == null)
            {
                Console.WriteLine("Dataset ne postoji.");
                return;
            }

            var data = dataset.GetData();
            if (data == null || data.Count == 0)
            {
                Console.WriteLine("nema podataka.");
                return;
            }

            foreach (var row in data)
            {
                Console.WriteLine(string.Join(", ", row));
            }
        }
    }
}
