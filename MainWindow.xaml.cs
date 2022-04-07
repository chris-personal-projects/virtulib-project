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

namespace virtulib_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _main = new MainViewModel();
        private DispatcherTimer searchInputTimer;
        private const int TIMER_DELAY = 200;

        public MainWindow()
        {
            InitializeComponent();
            Main.Navigate(new Browse(_main));
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
            object checkoutControl = new CheckoutControl(_main);
            _main.SetDialog(checkoutControl);
            Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
            sb.Begin();
        }

        private void helpButtonClick(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Help());
            Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
            sb.Begin();
        }
        
        private void ProfilePanelClick(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Profile());
            Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
            sb.Begin();
        }

        private void myItemsClick(object sender, MouseButtonEventArgs e)
        {
            Main.Navigate(new MyItems());
            Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
            sb.Begin();
        }

        private void homePage(object sender, MouseButtonEventArgs e)
        {
            Main.Navigate(new Browse(_main));
            Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
            sb.Begin();
        }

        private void InitSearchResults(object sender, TextChangedEventArgs e)
        {
            InitSearchTimer(sender, e);
        }

        private void InitSearchTimer(object sender, TextChangedEventArgs e)
        {
            if (searchInputTimer == null)
            {
                searchInputTimer = new DispatcherTimer();
                searchInputTimer.Interval = TimeSpan.FromMilliseconds(TIMER_DELAY);
                searchInputTimer.Tick += new EventHandler(this.handleInitSearchResults);
            }
            searchInputTimer.Stop(); // Resets the timer
            searchInputTimer.Tag = (sender as TextBox).Text; // This should be done with EventArgs
            searchInputTimer.Start();
        }

        private void handleInitSearchResults(object sender, EventArgs e) 
        {
            var timer = sender as DispatcherTimer;
            if (timer == null)
            {
                return;
            }

            if (String.IsNullOrEmpty(mainSearch.Text))
            {
                // Console.WriteLine("Caker!");
                Main.Navigate(new Browse(_main));
            }
            else
            {
                // Console.WriteLine("Nada!");
                LoadSearchResults();
            }

            timer.Stop();
        }

        private void LoadSearchResults()
        {
            Main.Navigate(new SearchResult(_main));
            // throw new NotImplementedException();
        }
    }
}