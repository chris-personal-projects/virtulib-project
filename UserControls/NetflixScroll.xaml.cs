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
        double scrollItemOffset = 0;

        public NetflixScroll()
        {
            InitializeComponent();
            DataContext = Parent;

        }

        private void Book_Summary_Click(object sender, RoutedEventArgs e)
        {
            if (bookSummaryCustomEvent != null)
            {
                bookSummaryCustomEvent(sender, new BookSummaryEventArgs(customEventText));
            }
        }

        private void NetflixScrollPanel_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // Prevent NetflixScroller from capturing scroll behaviour: scroll behaviour on main ScrollView should be smooth
            if (!e.Handled)
            {
                e.Handled = true;
                var scrollEventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);

                scrollEventArg.RoutedEvent = UIElement.MouseWheelEvent;
                scrollEventArg.Source = sender;
                var parentScroll = ((Control)sender).Parent as UIElement;
                parentScroll.RaiseEvent(scrollEventArg);
            }
        }

        private void Netflix_Left_Scroll(object sender, RoutedEventArgs e)
        {
            NetflixScrollPanel.ScrollToHorizontalOffset(NetflixScrollPanel.HorizontalOffset - scrollItemOffset);
        }

        private void Netflix_Right_Scroll(object sender, RoutedEventArgs e)
        {
            NetflixScrollPanel.ScrollToHorizontalOffset(NetflixScrollPanel.HorizontalOffset + scrollItemOffset);

        }

        private void onNetflixStackPanelLoad(object sender, RoutedEventArgs e)
        {
            int numChildren = NetflixStackPanel.Children.Count;
            if (numChildren == 0) return;

            if (scrollItemOffset == 0)
            {
                NetflixStackPanel.Children[0].Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
                scrollItemOffset = NetflixStackPanel.Children[0].DesiredSize.Width;
            }
        }
    }
}
