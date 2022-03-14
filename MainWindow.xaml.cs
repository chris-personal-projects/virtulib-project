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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using virtulib_project.UserControls;
using virtulib_project.Models;

namespace virtulib_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _main = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            Main.Navigate(new Browse());
            DataContext = _main;

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Open_Cart(object sender, RoutedEventArgs e)
        {
            object checkoutControl = new CheckoutControl();
            _main.SetDialog(checkoutControl);
        }

    }
}
