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
using virtulib_project.Models;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for CheckoutConfirm.xaml
    /// </summary>
    public partial class CheckoutConfirm : Page
    {
        private MainViewModel _main = new MainViewModel();
        public CheckoutConfirm(MainViewModel mainViewModel)
        {

            InitializeComponent();
            _main = mainViewModel;
            CheckoutConfirmRoot.DataContext = mainViewModel;
        }

        private void BackToHome(object sender, RoutedEventArgs e)
        {
            //Main.Navigate(new Browse(_main));
            NavigationService.Navigate(new Browse(_main));
        }

    }
}
