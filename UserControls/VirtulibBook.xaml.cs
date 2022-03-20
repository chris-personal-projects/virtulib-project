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

namespace virtulib_project.UserControls
{
    /// <summary>
    /// Interaction logic for VirtulibBook.xaml
    /// </summary>
    public partial class VirtulibBook : UserControl
    {
        public string BookImage
        {
            get { return (String)GetValue(BookImageProperty); }
            set { SetValue(BookImageProperty, value); }
        }

        public static readonly DependencyProperty BookImageProperty =
            DependencyProperty.Register("BookImage", typeof(string),
                typeof(VirtulibBook), new PropertyMetadata(""));

        public VirtulibBook()
        {
            InitializeComponent();
            // BookImage = "/imgs/bookImgs/hungry-caterpillar-small.jpg";
            // _bookImage = "/imgs/bookImgs/hungry-caterpillar-small.jpg";
            // BookImage = GenBookImage("/imgs/bookImgs/hungry-caterpillar-small.jpg");
        }

        //private Image GenBookImage(string uriSource)
        //{
        //    BookImage = new Image();
        //    BitmapImage bitImg = new BitmapImage();
        //    bitImg.BeginInit();
        //    bitImg.UriSource = new Uri(uriSource, UriKind.Relative);
        //    bitImg.EndInit();

        //    BookImage.Stretch = Stretch.Fill;
        //    BookImage.Source = bitImg;
        //    return BookImage;
        //}

        private void Book_Summary_Click(object sender, RoutedEventArgs e)
        {
            //if (bookSummaryCustomEvent != null)
            //{
            //    bookSummaryCustomEvent(sender, new BookSummaryEventArgs(customEventText));
            //}
            Console.WriteLine($"Chris {BookImage}");
        }

    }
}
