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
using virtulib_project.Events;

namespace virtulib_project.UserControls
{
    /// <summary>
    /// Interaction logic for VirtulibBook.xaml
    /// </summary>
    public partial class VirtulibBook : UserControl
    {
        private VirtulibBookModel virtulibBookData;

        public string BookImage
        {
            get { return (String)GetValue(BookImageProperty); }
            set { SetValue(BookImageProperty, value); }
        }

        public static readonly DependencyProperty BookImageProperty =
            DependencyProperty.Register("BookImage", typeof(string),
                typeof(VirtulibBook), new PropertyMetadata(""));

        public event RoutedEventHandler VirtulibBookSelected
        {
            add { AddHandler(VirtulibBookSelectedEvent, value); }
            remove { RemoveHandler(VirtulibBookSelectedEvent, value); }
        }

        public static readonly RoutedEvent VirtulibBookSelectedEvent =
            EventManager.RegisterRoutedEvent("VirtulibBookSelected",
                RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                typeof(VirtulibBook));

        public VirtulibBook()
        {
            InitializeComponent();
        }

        public VirtulibBook(VirtulibBookModel virtulibBook)
        {
            InitializeComponent();
            virtulibBookData = virtulibBook;

            // SetValue(BookImageProperty, virtulibBook.Image_Location);
        }

        void RaiseVirtulibBookSelectedEvent(VirtulibBookModel virtulibBook)
        {
            RoutedEventArgs newEventArgs = new VirtulibBookSelectedEventArgs(VirtulibBook.VirtulibBookSelectedEvent, virtulibBook);
            RaiseEvent(newEventArgs);
        }

        private void Book_Summary_Click(object sender, RoutedEventArgs e)
        {
            RaiseVirtulibBookSelectedEvent(virtulibBookData);
        }

    }
}
