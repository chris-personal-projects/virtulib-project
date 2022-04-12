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
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using virtulib_project.Pages;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using virtulib_project.UserControls;
using virtulib_project.Models;
using System.Timers;
using System.Windows.Threading;
using MaterialDesignThemes.Wpf;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class MyItems : Page
    {
        
        private MainViewModel _mainViewModel = new MainViewModel();
        private VirtulibBookModel[] BookList;
        public MyItems(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _mainViewModel = mainViewModel;
            DataContext = _mainViewModel;
        }

        private void RenewBook1(object sender, MouseButtonEventArgs e)
        {
            Book1Date.Text = "Expires in: 30 days";

        }

        private void RenewBook3(object sender, MouseButtonEventArgs e)
        {
            Book3Date.Text = "Due in: 30 days";

        }

        private void return1Event(object sender, MouseButtonEventArgs e)
        {
            object ReturnControl = new ReturnControl(_mainViewModel);
            _mainViewModel.SetDialog(ReturnControl);
        }

        private void return3Event(object sender, MouseButtonEventArgs e)
        {
            object ReturnControl = new ReturnControl(_mainViewModel);
            _mainViewModel.SetDialog(ReturnControl);
        }

    }
}
