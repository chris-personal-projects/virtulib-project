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
using virtulib_project.UserControls;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using virtulib_project.Models;
using virtulib_project.Events;
using MaterialDesignThemes.Wpf;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : Page
    {
        private MainViewModel _mainViewModel;
        private VirtulibBookModel[] BookList;
        private SnackbarMessageQueue bookMessageQueue;

        public SearchResult(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BookList = mainViewModel.BookList;
            DataContext = mainViewModel;
            _mainViewModel = mainViewModel;

            InitSearchResults();
            bookMessageQueue = _mainViewModel.BookMessageQueue;

        }

        private void InitSearchResults()
        {
            Border virtuBorder = null;
            VirtulibBook virtulibBook = null;
            foreach (VirtulibBookModel book in BookList)
            {
                virtulibBook = new VirtulibBook(book);

                virtulibBook.BookImage = book.Image_Location;
                virtulibBook.VirtulibBookSelected += Book_Summary;

                virtuBorder = new Border();
                virtuBorder.Child = virtulibBook;
                SearchBookShelf.Children.Add(virtuBorder);
            }
        }

        private void Book_Summary(object sender, RoutedEventArgs e)
        {
            VirtulibBookSelectedEventArgs args = (VirtulibBookSelectedEventArgs)e;
            BookInfoDialog bookInfoDialog = new BookInfoDialog(args);
            bookInfoDialog.SnackbarMessageInit += InitSnackbarMessage;
            _mainViewModel.SetDialog(bookInfoDialog);
        }

        private void InitSnackbarMessage(object sender, RoutedEventArgs e)
        {
            SnackbarMessageEventArg message = (SnackbarMessageEventArg)e;
            bookMessageQueue.Enqueue(message.SnackMessage);
        }
    }
}
