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
using System.Runtime.CompilerServices;
using virtulib_project.Models;
using virtulib_project.Events;

namespace virtulib_project.UserControls
{
    public partial class NetflixScroll : UserControl
    {
        // private MainViewModel _mainViewModel;
        public event EventHandler<BookSummaryEventArgs> bookSummaryCustomEvent;
        private String customEventText = "Custom Events FTW!!!";

        public NetflixScroll()
        {
            InitializeComponent();
            DataContext = Parent;
            //_mainViewModel = mainViewModel;

        }

        private void Book_Summary_Click(object sender, RoutedEventArgs e)
        {
            if (bookSummaryCustomEvent != null)
            {
                bookSummaryCustomEvent(sender, new BookSummaryEventArgs(customEventText));
            }
        }

        //private void Book_Summary(object sender, RoutedEventArgs e)
        //{
        //    object bookSumControl = new BookInfo();
        //    // _browse.SetBookDialog(bookSumControl);
        //    _mainViewModel.SetDialog(bookSumControl);

        //}


    }
}
