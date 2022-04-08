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
    public partial class BookInfoDialog : UserControl
    {
        private const int MAX_REVIEW_SCORE = 5;
        private int _bookInfoDialogReviewScore;
        public int BookInfoDialogReviewScore { get => _bookInfoDialogReviewScore; set => _bookInfoDialogReviewScore = value; }

        private int _bookInfoDialogCopies = 0;
        public int BookInfoDialogCopies { get => _bookInfoDialogCopies; set => _bookInfoDialogCopies = value; }

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

        public string BookInfoDialogStockTag
        {
            get { return (String)GetValue(BookInfoDialogStockTagProperty); }
            set { SetValue(BookInfoDialogStockTagProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogStockTagProperty =
            DependencyProperty.Register("BookInfoDialogStockTag", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public Brush InStockColor
        {
            get { return (Brush)GetValue(InStockColorProperty); }
            set { SetValue(InStockColorProperty, value); }
        }

        public static readonly DependencyProperty InStockColorProperty =
            DependencyProperty.Register("InStockColor", typeof(Brush),
            typeof(BookInfoDialog), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

        public string BookInfoDialogDescription
        {
            get { return (String)GetValue(BookInfoDialogDescriptionProperty); }
            set { SetValue(BookInfoDialogDescriptionProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogDescriptionProperty =
            DependencyProperty.Register("BookInfoDialogDescription", typeof(string),
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
            BookInfoDialogCopies = args.VirtulibBook.Copies;
            BookInfoDialogDescription = generateDescription(args.VirtulibBook.Description);

            List<StackPanel> reviewPanels = new List<StackPanel>();
            reviewPanels.Add(ReviewPanel);
            reviewPanels.Add(BotReviewsPanel);
            generateReviewStars(reviewPanels);

            generateInStockTag();
        }



        private string generateDescription(string bookDescription)
        {
            string bookDetails = bookDescription;

            if (bookDescription == null)
            {
                bookDetails = "No description for this book at the moment.";
            }
            
            return bookDetails;
        }

        private void generateInStockTag()
        {
            if (BookInfoDialogCopies > 0)
            {
                BookInfoDialogStockTag  = "Available - Arrives in 2-3 Days";
                InStockColor = (Brush)Application.Current.Resources["PrimaryHueDarkBrush"];

            }
            else 
            {
                BookInfoDialogStockTag = "No Copies Available";
                InStockColor = new SolidColorBrush(Colors.Red);

                AddCartButton.Visibility = Visibility.Hidden;
                AddCartButton.IsEnabled = false;
            } 
        }

        private void generateReviewStars(List<StackPanel> reviewPanels)
        {
            PackIcon fullStar;
            PackIcon emptyStar;
            int starCount;

            foreach (StackPanel panel in reviewPanels)
            {
                starCount = 0;
                for (; starCount < BookInfoDialogReviewScore; starCount++)
                {
                    fullStar = initReviewStar(false);
                    panel.Children.Add(fullStar);
                }

                for (; starCount < MAX_REVIEW_SCORE; starCount++)
                {
                    emptyStar = initReviewStar(true);
                    panel.Children.Add(emptyStar);
                }
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

        private void CloseAndNotify(object sender, RoutedEventArgs e)
        {
            DialogHost.CloseDialogCommand.Execute(null, null);
            RaiseSnackbarMessageInitEvent();
        }

        private void RaiseSnackbarMessageInitEvent()
        {
            string snackMessage = $"\"{BookInfoDialogTitle}\" has been added to your cart.";

            RoutedEventArgs newEventArg = new SnackbarMessageEventArg(BookInfoDialog.SnackbarMessageInitEvent, snackMessage);
            RaiseEvent(newEventArg);
            // throw new NotImplementedException();
        }

        public event RoutedEventHandler SnackbarMessageInit
        {
            add { AddHandler(SnackbarMessageInitEvent, value); }
            remove { RemoveHandler(SnackbarMessageInitEvent, value); }
        }

        public static readonly RoutedEvent SnackbarMessageInitEvent =
            EventManager.RegisterRoutedEvent("SnackbarMessageInit",
                RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                typeof(string));
    }
}
