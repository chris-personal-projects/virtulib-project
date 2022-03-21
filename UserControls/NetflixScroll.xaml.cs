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
        // public event EventHandler<BookSummaryEventArgs> BookSummaryCustomEvent;
        // public VirtulibBookModel virtulibBookData = new VirtulibBookModel();
        double scrollItemOffset = 0;

        //private string _imgSourceUrl;        
        //public string ImageSourceUrl 
        //{ 
        //    get { return _imgSourceUrl; }
        //    set { _imgSourceUrl = value; }
        //}

        public NetflixScroll()
        {
            InitializeComponent();

            // Dynamically create Virtulib books to insert to Netflix Scroller
            //int numBooks = 8;
            //VirtulibBook virtulibBook;
            //for (int i = 0; i < numBooks; i++)
            //{
            //    if (i % 2 == 0)
            //        virtulibBook = new VirtulibBook(virtulibBookData);
            //    else
            //        virtulibBook = new VirtulibBook(virtulibBookData2);
            //    virtulibBook.BookImage = "/imgs/bookImgs/hungry-caterpillar-small.jpg";
            //    // virtulibBook.VirtulibBookSelected += Book_Summary_Click;
            //    NetflixStackPanel.Children.Add(virtulibBook);
            //}
            // InitNetflixScrollOffsets();
        }

        //public void Book_Summary_Click(object sender, RoutedEventArgs e)
        //{
        //    if (BookSummaryCustomEvent != null)
        //    {
        //        BookSummaryCustomEvent(sender, new BookSummaryEventArgs("Cake"));
        //    }
        //}

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

        public void InitNetflixScrollOffsets()
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
