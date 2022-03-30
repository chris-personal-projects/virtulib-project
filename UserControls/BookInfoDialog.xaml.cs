using MaterialDesignThemes.Wpf;
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
using virtulib_project.Events;

namespace virtulib_project.UserControls
{
    /// <summary>
    /// Interaction logic for BookInfo.xaml
    /// </summary>
    public partial class BookInfoDialog : UserControl
    {
        private const int MAX_REVIEW_SCORE = 5;
        private int _bookInfoDialogReviewScore;
        public int BookInfoDialogReviewScore { get => _bookInfoDialogReviewScore; set => _bookInfoDialogReviewScore = value; }

        public string BookInfoDialogImage
        {
            get { return (String)GetValue(BookInfoDialogImageProperty); }
            set { SetValue(BookInfoDialogImageProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogImageProperty =
            DependencyProperty.Register("BookInfoDialogImage", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public string BookInfoDialogTitle
        {
            get { return (String)GetValue(BookInfoDialogTitleProperty); }
            set { SetValue(BookInfoDialogTitleProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogTitleProperty =
            DependencyProperty.Register("BookInfoDialogTitle", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public string BookInfoDialogItemType
        {
            get { return (String)GetValue(BookInfoDialogItemTypeProperty); }
            set { SetValue(BookInfoDialogItemTypeProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogItemTypeProperty =
            DependencyProperty.Register("BookInfoDialogItemType", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public string BookInfoDialogAuthor
        {
            get { return (String)GetValue(BookInfoDialogAuthorProperty); }
            set { SetValue(BookInfoDialogAuthorProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogAuthorProperty =
            DependencyProperty.Register("BookInfoDialogAuthor", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public string BookInfoDialogPublishDate
        {
            get { return (String)GetValue(BookInfoDialogPublishDateProperty); }
            set { SetValue(BookInfoDialogPublishDateProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogPublishDateProperty =
            DependencyProperty.Register("BookInfoDialogPublishDate", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public string BookInfoDialogMediaType
        {
            get { return (String)GetValue(BookInfoDialogMediaTypeProperty); }
            set { SetValue(BookInfoDialogMediaTypeProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogMediaTypeProperty =
            DependencyProperty.Register("BookInfoDialogMediaType", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));


        public BookInfoDialog(VirtulibBookSelectedEventArgs args)
        {
            InitializeComponent();
            DataContext = this;
            BookInfoDialogImage = args.VirtulibBook.Image_Location;
            BookInfoDialogTitle = args.VirtulibBook.Title;
            BookInfoDialogItemType = args.VirtulibBook.Item_Type;
            BookInfoDialogAuthor = args.VirtulibBook.Author;
            BookInfoDialogPublishDate = args.VirtulibBook.Publish_Date;
            BookInfoDialogMediaType = args.VirtulibBook.Media_Type;
            BookInfoDialogReviewScore = (int)args.VirtulibBook.Review_Score;

            generateReviewStars();
        }

        private void generateReviewStars()
        {
            int starCount = 0;
            for (; starCount < BookInfoDialogReviewScore; starCount++)
            {
                PackIcon fullStar = initReviewStar(false);
                ReviewPanel.Children.Add(fullStar);
            }

            for (; starCount < MAX_REVIEW_SCORE; starCount++)
            {
                PackIcon emptyStar = initReviewStar(true);
                ReviewPanel.Children.Add(emptyStar);
            }
        }

        private PackIcon initReviewStar(bool emptyStar = false) {
            PackIcon starIcon = new PackIcon();

            starIcon.Kind = emptyStar ? PackIconKind.StarOutline : PackIconKind.Star;
            starIcon.Width = 30;
            starIcon.Height = 30;
            starIcon.Foreground = (Brush)Application.Current.Resources["StarColor"];
            starIcon.VerticalAlignment = VerticalAlignment.Center;
            starIcon.HorizontalAlignment = HorizontalAlignment.Center;
            return starIcon;
        }
    }
}
