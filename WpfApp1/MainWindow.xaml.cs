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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author="Ritcie",
                Genre="Programming",
                Pages=1100,
                Publisher="Baku inc",
                Title="C#",
                Imagepath="1.jpg"
            },
             new Book
            {
                Id=2,
                Author="Amin",
                Genre="Programming",
                Pages=1500,
                Publisher="Step inc",
                Title="C+",
                 Imagepath="2.jpg"
            },
              new Book
            {
                Id=3,
                Author="Ayxan",
                Genre="Programming",
                Pages=290,
                Publisher="Jord inc",
                Title="Java",
                Imagepath="3.jpg"
            },
        };

        public MainWindow()
        {
            //this.DataContext = this;
            InitializeComponent();
            //listview.ItemsSource = Books;
            listbox.ItemsSource = Books;
        }
    }
}
