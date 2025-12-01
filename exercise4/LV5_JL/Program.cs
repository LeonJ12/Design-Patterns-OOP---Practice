using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    public class Program
    {
        static void Main(string[] args)
        {
            RunTask7();
            Console.ReadKey();
        }
        public static void RunTask12()
        {
            ShippingService service = new ShippingService(2.0);
            Product ball = new Product("Football ball", 5.5, 0.5);
            Product watch = new Product("Rolex Day-Date", 5000.0, 0.2);
            Box BigBox = new Box("BigBox");
            BigBox.Add(ball);
            BigBox.Add(watch);
            Console.WriteLine(BigBox.Description(1));
            Console.WriteLine(service.CalculateShippingCost(BigBox));
        }
        public static void RunTask3()
        {
            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("C:/Users/student/Desktop/primjer.csv");
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.PrintData(virtualProxy);
         

            ProtectionProxyDataset protectionProxyAllowed = new ProtectionProxyDataset(User.GenerateUser("Leon"));
            ProtectionProxyDataset protectionProxyDenied = new ProtectionProxyDataset(User.GenerateUser("Marko"));

            Console.WriteLine("Dozvoljeni pristup adminu");
            printer.PrintData(protectionProxyAllowed);

            Console.WriteLine("Gost-nema pristupa");
            printer.PrintData(protectionProxyDenied);


        }
        public static void RunTask4()
        {
            LoggingProxy loggingProxy = new LoggingProxy("C:/Users/student/Desktop/primjer.csv");
            DataConsolePrinter printer = new DataConsolePrinter();
            printer.PrintData(loggingProxy);

        }
        public static void RunTask5()
        {
            ITheme darktheme = new DarkTheme();
            ReminderNote note = new ReminderNote("Message", darktheme);
            note.Show();
        }
        public static void RunTask6()
        {
            ITheme darktheme = new DarkTheme();
            GroupNote groupnote = new GroupNote("Message", darktheme);
            groupnote.AddAuthor("Leon");
            groupnote.AddAuthor("Marko");
            groupnote.RemoveAuthor("Marko");
            groupnote.Show();
        }
        public static void RunTask7()
        {
            ITheme LightTheme = new LightTheme();
            ITheme darktheme = new DarkTheme();
            GroupNote groupnote = new GroupNote("Message", darktheme);
            ReminderNote note = new ReminderNote("Message", LightTheme);
            Notebook notes = new Notebook(darktheme);
            notes.AddNote(groupnote);
            notes.AddNote(note);
            notes.Display();

        }

    }
}

