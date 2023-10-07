using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace library
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public List<Book> Books{ get; set; }
        
        public User(int id, string firstName, string lastName) 
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            Books = new List<Book>();
        }
        public void BookShare (Book book)
        {
            if (book.Count >0)
            {
                Books.Add(book);
                book.Count--;
            }
            else
            {
                MessageBox.Show("Данной книги нет в наличии");
            }
        }
        public void BookReturn (Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
                book.Count++;
            }
        }
    }
}
