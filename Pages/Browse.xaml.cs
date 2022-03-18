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

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class Browse : Page
    {
        private MainViewModel _mainViewModel;

        public Browse(MainViewModel mainViewModel)
        {
            InitializeComponent();
            // DataContext = this;
            BrowseRoot.DataContext = mainViewModel;
            _mainViewModel = mainViewModel;

            // Dynamically create Netflix scrolls here 
            NetflixScroll netflixScroll = new NetflixScroll();
            netflixScroll.bookSummaryCustomEvent += new EventHandler<BookSummaryEventArgs>(Book_Summary);
            Grid.SetRow(netflixScroll, 0);
            BrowseRoot.Children.Add(netflixScroll);
        }

        private void Book_Summary(object sender, BookSummaryEventArgs e)
        {
            // Console.WriteLine("Chris Control");
            object bookSumControl = new BookInfo();
            _mainViewModel.SetDialog(bookSumControl);
        }
    }
}
