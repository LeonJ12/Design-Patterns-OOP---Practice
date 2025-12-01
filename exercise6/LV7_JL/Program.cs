using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace LV7_JL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZD12();
        }
        static void ZD12()
        {
            
            NumberSequence numberSequence = new NumberSequence(5);
            numberSequence.InsertAt(0, 1);
            numberSequence.InsertAt(1, 5);
            numberSequence.InsertAt(2, 2);
            numberSequence.InsertAt(3, 7);
            numberSequence.InsertAt(4, 0);
            Console.WriteLine(numberSequence.ToString());
            SortStrategy sequentialSort = new SequentialSort();
            SortStrategy combSort = new CombSort();
            SortStrategy bubbleSort = new BubbleSort();

            numberSequence.SetSortStrategy(sequentialSort);
            numberSequence.Sort();
           Console.WriteLine( numberSequence.ToString());
            numberSequence.SetSortStrategy(combSort);
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());
            numberSequence.SetSortStrategy(bubbleSort);
            numberSequence.Sort();
            Console.WriteLine(numberSequence.ToString());
          

            ISearchStrategy LinearSearch = new LinearSearch();
            numberSequence.SetSearchStrategy(LinearSearch);
            
            if(numberSequence.Search(2))
            {
                Console.WriteLine("Pronadjen");
            }
            else
            {
                Console.WriteLine(" Nije Pronadjen");
            }

            if (numberSequence.Search(3))
            {
                Console.WriteLine("Pronadjen");
            }
            else
            {
                Console.WriteLine(" Nije Pronadjen");
            }

        }
        static void ZD3()
        {
            SystemDataProvider provider = new SystemDataProvider();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FileLogger filelogger = new FileLogger("file.txt");
            provider.Attach(consoleLogger);
            provider.Attach(filelogger);
            while(true)
                {
                provider.GetAvailableRAM();
                provider.GetCPULoad();
                Thread.Sleep(1000);
            }
        }
        static void zd5()
        {
            Book book = new Book("knjiga", 15.0);
            BuyVisitor buyVisitor = new BuyVisitor();
            book.Accept(buyVisitor);
        }



    }
    
}
