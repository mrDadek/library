using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Book
    {
        public string Author { get; set; }
        public short Art { get; set; }
        public string Age { get; set; }
        public int Count { get; set; }

        public Book (string author, short art, int year, int mouth, int day, int count)
        {
            Author = author;
            Art = art;
            Age = new DateTime(year, mouth, day).ToString("dd.MM.yyyy");
            Count = count;
        }   
    }
}
