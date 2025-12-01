using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    public class QuoteFilter
    {
        public IList<Quote> ExtractAboveAverageRated(IList<Quote> quotes)
        {
            IList<Quote> aboveAverageRatedQuotes = new List<Quote>();
            if (quotes is null || quotes.Count == 0)
                return aboveAverageRatedQuotes;
           double averageVotes = GetaverageVotes(quotes);
            foreach (Quote quote in quotes)
            {
                if (quote.Votes > averageVotes)
                {
                    aboveAverageRatedQuotes.Add(quote);
                }
            }
            return aboveAverageRatedQuotes;
        }
        public double GetaverageVotes(IList<Quote> quotes) 
            {
             double voteSum = 0.0;
            foreach (Quote quote in quotes)
            {
                voteSum += quote.Votes;
            }
            return voteSum / quotes.Count;
        }
        public IList<Quote> ExtractBestQuotesByAuthor(IList<Quote> quotes) 
            {
            var bestQuotes = quotes.GroupBy(x => x.Author);
             List<Quote> extractedQuotes = new List<Quote>();   
            if (quotes is null || quotes.Count == 0)
            {
                return new List<Quote>();
            }
            foreach(var quote in bestQuotes) 
                {
                extractedQuotes.Add(quote.OrderBy(x => x.Votes).Last());
                }
            return extractedQuotes;
            }
    }

}
