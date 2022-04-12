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
using virtulib_project.Pages;
using virtulib_project.Models;

namespace virtulib_project.UserControls
{
    /// <summary>
    /// Interaction logic for CheckoutControl.xaml
    /// </summary>
    public partial class ReturnControl : UserControl
    {
        MainViewModel viewModel;
        public ReturnControl(MainViewModel mainViewModel)
        {
            InitializeComponent();
            DataContext = this;
            viewModel = mainViewModel;
        }

        private void ReturnRedirect(object sender, RoutedEventArgs e)
        {
            MainViewModel mainViewModel = new MainViewModel();
            ((MainWindow)App.Current.MainWindow).Main.Navigate(new ReturnPage(viewModel));
        }

        private void Check1Click(object sender, RoutedEventArgs e)
        {
            if (Check1.Visibility.Equals(Visibility.Visible))
            {
                Check1.Visibility = Visibility.Hidden;

            }
            else if (Check1.Visibility.Equals(Visibility.Hidden))
            {
                Check1.Visibility = Visibility.Visible;

            }
        }

        private void Check2Click(object sender, RoutedEventArgs e)
        {
            if (Check2.Visibility.Equals(Visibility.Visible))
            {
                Check2.Visibility = Visibility.Hidden;

            }
            else if (Check2.Visibility.Equals(Visibility.Hidden))
            {
                Check2.Visibility = Visibility.Visible;

            }
        }

        private void Check3Click(object sender, RoutedEventArgs e)
        {
            if (Check3.Visibility.Equals(Visibility.Visible))
            {
                Check3.Visibility = Visibility.Hidden;

            }
            else if (Check3.Visibility.Equals(Visibility.Hidden))
            {
                Check3.Visibility = Visibility.Visible;

            }
        }

        private void Check4Click(object sender, RoutedEventArgs e)
        {
            if (Check4.Visibility.Equals(Visibility.Visible))
            {
                Check4.Visibility = Visibility.Hidden;

            }
            else if (Check4.Visibility.Equals(Visibility.Hidden))
            {
                Check4.Visibility = Visibility.Visible;

            }
        }

        private void removeAllClick(object sender, RoutedEventArgs e)
        {
            Check1.Visibility = Visibility.Hidden;
            Check2.Visibility = Visibility.Hidden;
            Check3.Visibility = Visibility.Hidden;
            Check4.Visibility = Visibility.Hidden;
        }

    }
}
