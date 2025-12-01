using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV1
{
    public class Quote
    {
       public Author Author;
        public string Text { get; private set; } 
        public int Votes { get; set; } 
        private IList<string> tags; 
        public Quote(Author author, string text)
        {
            Author = author;
            Text = text;
            Votes= 0;
            tags= new List<string>(); 
        }
        public void Upvote()
        {
            if (Votes < int.MaxValue)
            {
                Votes++;
            }
        }
        public void Downvote()
        {
           if(Votes > 0)
            {
                Votes--;
            }
        }
        public void AddTag(string newTag)
        {
            tags.Add(newTag.ToLower());
        }
        public IList<string> GetTags()
        {
            return tags.ToList().AsReadOnly();
        }
        public override string ToString()
        {
            return $"{Author} - {Text}, Votes : {Votes} , Tags : {string.Join(",",tags)} \n";
        }
    }

}
