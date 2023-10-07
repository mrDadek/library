using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace library
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<User> users = new List<User>()
            {
                new User(1,"Иван","Иванов"), 
                new User(2,"Пётр","Сидоров")
            };
            User_List.ItemsSource= users;
            User_List.FontSize = 10;

            List<Book> books = new List<Book>()
            {
                new Book("Пинигин", 241, 2012,3,6,12),
                new Book("Метельский", 244, 2015,7,3,9),
                new Book("Роулинг", 223, 1993,4,1,14),
                new Book("Толкин", 531, 2020,9,20,40),
                new Book("Толстой", 123, 2077,9,12,1)
                
            };
            Book_List.ItemsSource= books;
            Book_List.FontSize = 10;
        }
    }
}
