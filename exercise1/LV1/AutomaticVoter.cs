using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    /// <summary>
    /// Class used for automated voting on quotes. Serves as abot for
    /// testing and demonstration purposes. Utilises a random generator
    /// to decide how many and which type of votes (up / down) to cast.
    /// </summary>
    public class AutomaticVoter
    {
        const double baseProbability = 0.5;
        private Random generator; 
                         
        public AutomaticVoter(Random generator)
        {
            this.generator = generator;
        }
        
        public void HandleQuote(Quote newQuote)
        {
            double upvoteProbability = baseProbability;
            if (newQuote.Text.Length > 140) 
                upvoteProbability += 0.1;
            if (newQuote.GetTags().Count < 3) 
                upvoteProbability += newQuote.GetTags().Count * 0.1;

            int totalVotes = generator.Next(0, 101); 
            for ( int i = 0; i < totalVotes; i++)
            {
                if (this.generator.NextDouble() < upvoteProbability)
                {
                    newQuote.Upvote();
                }
                else
                    newQuote.Downvote();
            }
        }


    }
}
