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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using virtulib_project.UserControls;
using virtulib_project.Models;
using virtulib_project.Events;
using MaterialDesignThemes.Wpf;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class Browse : Page
    {
        private MainViewModel _mainViewModel;
        private VirtulibBookModel[] BookList;

        private SnackbarMessageQueue bookMessageQueue;
        public Browse(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BrowseRoot.DataContext = mainViewModel;
            _mainViewModel = mainViewModel;
            BookList = _mainViewModel.BookList;

            string[] categoryList = { "Best Sellers", "Staff Picks", "Virtulib Picks", "Fiction", "Non-Fiction" };

            generateNetflixScrolls(categoryList);

            bookMessageQueue = _mainViewModel.BookMessageQueue;
            bookMessageQueue.Enqueue("Caker 2 testing!");
        }

        private void generateNetflixScrolls(string[] categoryList)
        {
            NetflixScroll netflixScroll;
            VirtulibBook virtulibBook;

            int numBooks = _mainViewModel.BookList.Length;
            int shelf_num = 5;
            int book_index = 0;
            int max_shelf_books = 10;

            for (int j = 0; j < shelf_num; j++) 
            {
                netflixScroll = new NetflixScroll();
                netflixScroll.CategoryName = categoryList[j];

                for (int i = 0; i < max_shelf_books; i++, book_index++)
                {
                    virtulibBook = new VirtulibBook(BookList[book_index]);
                    virtulibBook.BookImage = BookList[book_index].Image_Location;

                    virtulibBook.VirtulibBookSelected += Book_Summary;
                    netflixScroll.NetflixStackPanel.Children.Add(virtulibBook);
                
                }

                netflixScroll.InitNetflixScrollOffsets();
                Grid.SetRow(netflixScroll, j);
                BrowseRootPanel.Children.Add(netflixScroll);
            }
        }

        private void Book_Summary(object sender, RoutedEventArgs e)
        {
            VirtulibBookSelectedEventArgs args = (VirtulibBookSelectedEventArgs)e;
            BookInfoDialog bookInfoDialog = new BookInfoDialog(args);
            _mainViewModel.SetDialog(bookInfoDialog);
        }
    }
}
