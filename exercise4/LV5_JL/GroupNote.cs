using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    internal class GroupNote : Note
    {
        private List<string> authors;
        public GroupNote(string message,ITheme theme) :base(message,theme)
        {
            authors = new List<string>();
        }
        public void AddAuthor(string author)
        {
            authors.Add(author);
        }
        public void RemoveAuthor(string author)
        {
            authors.Remove(author);

        }
        public override void Show() 
            {
            this.ChangeColor();
            Console.WriteLine("Group Note: ");
            Console.WriteLine(string.Join(",",authors));
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
           
            }
    }
}
