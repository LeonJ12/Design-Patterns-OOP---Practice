using System;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest3();
            RunTest4();
        }
        public static void RunTest1()
        {
            Dataset dataset = new Dataset("C:/Users/student/Desktop/Data.csv");
            Analyzer3rdParty thirdparty = new Analyzer3rdParty();
            Adapter adapter = new Adapter(thirdparty);
            double[] AveragePerRow = adapter.CalculateAveragePerRow(dataset);
            double[] AveragePerColumn = adapter.CalculateAveragePerColumn(dataset);
            Console.WriteLine(string.Join(", ", AveragePerRow));
            Console.WriteLine(string.Join(", ", AveragePerColumn));

            
        }
        public static void RunTest3()
        {
            List<IRentable> list = new List<IRentable>();
            Video movie = new Video("Run");
            Book book = new Book("History");
            

            RentingConsolePrinter printer = new RentingConsolePrinter();
            list.Add(book);
            list.Add(movie);

            printer.PrintTotalPrice(list);
            printer.DisplayItems(list);
        }
        public static void RunTest4()
        {
            List<IRentable> list = new List<IRentable>();
            Video movie = new Video("Run");
            Book book = new Book("History");
            HotItem hotbook = new HotItem(book);
            HotItem hotmovie = new HotItem(movie);


            RentingConsolePrinter printer = new RentingConsolePrinter();
            list.Add(book);
            list.Add(movie);
            list.Add(hotbook);
            list.Add(hotmovie);
            printer.PrintTotalPrice(list);
            printer.DisplayItems(list);
        }


    }
}
