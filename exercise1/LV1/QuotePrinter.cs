using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    public class QuotePrinter
    {
        ConsoleColor PrimaryColor;
        ConsoleColor SecondaryColor;

        public QuotePrinter(ConsoleColor primaryColor, ConsoleColor secondaryColor)
        {
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
        public void ChangePrimaryColor(ConsoleColor primaryColor)
        {
            PrimaryColor = primaryColor;
        }
        public void ChangeSecondaryColor(ConsoleColor secondaryColor)
        {
            SecondaryColor =secondaryColor;
        }



        public void PrintQuote(Quote quote)
        {
            Console.ForegroundColor = PrimaryColor;
            Console.Write(quote);
            Console.ResetColor();
        }

        public void PrintQuotes(IList<Quote> quotes)
        {
           List<Quote> sortedQuotes = quotes.OrderByDescending(x => x.Votes).ToList();
            for(int i=0; i<quotes.Count; i++)
            {
                if (i < 3)
                {
                    Console.ForegroundColor = PrimaryColor;
                    Console.Write(sortedQuotes[i]);
                    Console.ResetColor();

                }
                else
                {
                    Console.ForegroundColor = SecondaryColor;
                    Console.WriteLine(sortedQuotes[i]);
                    Console.ResetColor();
                }
            }
        }
    }
}
