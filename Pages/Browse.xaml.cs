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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using virtulib_project.UserControls;
using virtulib_project.Models;
using virtulib_project.Events;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class Browse : Page
    {
        private MainViewModel _mainViewModel;

        public Browse(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BrowseRoot.DataContext = mainViewModel;
            _mainViewModel = mainViewModel;

            VirtulibBookModel virtulibBookData = new VirtulibBookModel();
            VirtulibBookModel virtulibBookData2 = new VirtulibBookModel();

            virtulibBookData.Title = "Go Lucky, Chris";
            virtulibBookData.ItemType = "Novel";
            virtulibBookData.Author = "Chris Chen";
            virtulibBookData.ImageUrl = "/imgs/bookImgs/hungry-caterpillar-small.jpg";
            virtulibBookData.PublishDate = "Jan 2021, 2010";
            virtulibBookData.MediaType = "Physical";
            virtulibBookData.ReviewScore = 5;
            virtulibBookData.Copies = 25;
            virtulibBookData.Description = "The main character of Fantastic Mr. Fox is an extremely clever anthropomorphized fox named Mr.Fox.He lives with his wife and four little foxes.In order to feed his family, he steals food from the cruel, brutish farmers named Boggis, Bunce, and Bean every night.\r\n\r\nFinally tired of being constantly outwitted by Mr. Fox, the farmers attempt to capture and kill him. The foxes escape in time by burrowing deep into the ground.The farmers decide to wait outside the hole for the foxes to emerge.Unable to leave the hole and steal food, Mr.Fox and his family begin to starve.Mr.Fox devises a plan to steal food from the farmers by tunneling into the ground and borrowing into the farmer's houses.\r\n\r\nAided by a friendly Badger, the animals bring the stolen food back and Mrs. Fox prepares a great celebratory banquet attended by the other starving animals and their families. Mr. Fox invites all the animals to live with him underground and says that he will provide food for them daily thanks to his underground passages. All the animals live happily and safely, while the farmers remain waiting outside in vain for Mr. Fox to show up.";
            virtulibBookData.Category = "Fiction";

            virtulibBookData2.Title = "Happy Coconut";
            virtulibBookData2.ItemType = "Science Fiction";
            virtulibBookData2.Author = "Roger Papalic";
            virtulibBookData2.ImageUrl = "/imgs/bookImgs/harry-potter-3.jpg";
            virtulibBookData2.PublishDate = "Feb 2021, 2009";
            virtulibBookData2.MediaType = "Physical";
            virtulibBookData2.ReviewScore = 2;
            virtulibBookData2.Copies = 5;
            virtulibBookData2.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            virtulibBookData2.Category = "Fiction";

            // Dynamically create Netflix scrolls and the books to place inside them
            int numScrolls = 4;
            int numBooks = 10;
            NetflixScroll netflixScroll;
            VirtulibBook virtulibBook;

            for (int i = 0; i < numScrolls; i++)
            {
                netflixScroll = new NetflixScroll();

                for (int j = 0; j < numBooks; j++)
                {
                    if (j % 2 == 0)
                    {
                        virtulibBook = new VirtulibBook(virtulibBookData);
                        virtulibBook.BookImage = virtulibBookData.ImageUrl;
                    }
                    else
                    {
                        virtulibBook = new VirtulibBook(virtulibBookData2);
                        virtulibBook.BookImage = virtulibBookData2.ImageUrl;
                    }
                    // virtulibBook.BookImage = "/imgs/bookImgs/hungry-caterpillar-small.jpg";
                    // virtulibBook.BookImage = virtulibBookData2.ImageUrl;
                    virtulibBook.VirtulibBookSelected += Book_Summary;
                    netflixScroll.NetflixStackPanel.Children.Add(virtulibBook);
                }
                netflixScroll.InitNetflixScrollOffsets();

                // netflixScroll.BookSummaryCustomEvent += new EventHandler<BookSummaryEventArgs>(Book_Summary);
                Grid.SetRow(netflixScroll, i);
                BrowseRootPanel.Children.Add(netflixScroll);
            }

        }

        private void Book_Summary(object sender, RoutedEventArgs e)
        {
            // object bookSumControl = new BookInfo();
            // _mainViewModel.SetDialog(bookSumControl);
            // _mainViewModel.SetDialog(bookSumControl);

            BookInfoDialog bookInfoDialog = new BookInfoDialog();
            
            VirtulibBookSelectedEventArgs args = (VirtulibBookSelectedEventArgs)e;
            bookInfoDialog.BookInfoDialogImage = args.VirtulibBook.ImageUrl;
            // VirtulibBookModel selectedBook = args.VirtulibBook;
            _mainViewModel.SetDialog(bookInfoDialog);
        }
    }
}
