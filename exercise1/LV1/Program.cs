namespace LV1
{
    public class Program
    {
        static void Main(string[] args)
        {
            zd4();
        }
        public static void zd5()
        {
            QuoteFilter filter = new QuoteFilter();
        }
        public static void zd4()
        {
            QuotePrinter printer = new QuotePrinter(ConsoleColor.Red, ConsoleColor.Green);
            Author author = new Author("Leon", "Jere", new DateOnly(1952, 12, 5));
            Quote quotefirst = new Quote(author, "Citat");
            Quote quotesecond = new Quote(author, "Citat drugi");
            Quote quotethird = new Quote(author, "Citat treci");
            Quote quotefourth = new Quote(author, "Citat cetvrti");
            printer.PrintQuote(quotefirst);
            List<Quote> quotes = new List<Quote>();
            quotes.Add(quotesecond);
            quotes.Add(quotethird);
            quotes.Add(quotefirst);
            quotes.Add(quotefourth);
            quotefirst.Upvote();
            quotesecond.Upvote();
            quotesecond.Upvote();
            quotethird.Upvote();
            quotethird.Upvote();
            quotethird.Upvote();
            printer.PrintQuotes(quotes);
        }

            public static void zd2()
        {
            Author author = new Author("Leon", "Jere", new DateOnly(1952, 12, 5));
            Quote quote = new Quote(author, "Citat");
            quote.Upvote();
            quote.Downvote();
            quote.Upvote();
            quote.AddTag("Leon");
            Console.WriteLine(quote);

        }
        public static void zd3()
        {
            QuotesDatabase quotes = new QuotesDatabase();
            IList<Quote> quotesbyauthor = new List<Quote>();
            quotesbyauthor = quotes.GetQuotesByAuthor("robert", "martin");
            foreach(Quote quote in quotesbyauthor) 
                {
                Console.WriteLine(quote);
                }
            quotesbyauthor = quotes.GetQuotesByAuthor("rob", "martin");
            foreach (Quote quote in quotesbyauthor)
            {
                Console.WriteLine(quote);
            }
        }
    }
}
