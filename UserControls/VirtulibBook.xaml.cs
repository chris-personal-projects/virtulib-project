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

        public string BookImage
        {
            get { return (String)GetValue(BookImageProperty); }
            set { SetValue(BookImageProperty, value); }
        }

        public static readonly DependencyProperty BookImageProperty =
            DependencyProperty.Register("BookImage", typeof(string),
                typeof(VirtulibBook), new PropertyMetadata(""));

        public event RoutedEventHandler VirtuLibBookSelected
        {
            add { AddHandler(VirtuLibBookSelectedEvent, value); }
            remove { RemoveHandler(VirtuLibBookSelectedEvent, value); }
        }

        public static readonly RoutedEvent VirtuLibBookSelectedEvent =
            EventManager.RegisterRoutedEvent("VirtuLibBookSelected",
                RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                typeof(VirtulibBook));

        public VirtulibBook()
        {
            InitializeComponent();
        }

        private void Book_Summary_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Pwned");
            RaiseVirtuLibBookSelectedEvent();
        }

        void RaiseVirtuLibBookSelectedEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(VirtulibBook.VirtuLibBookSelectedEvent);
            RaiseEvent(newEventArgs);
        }
    }
}
