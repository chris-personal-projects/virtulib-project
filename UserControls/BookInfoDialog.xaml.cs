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

namespace virtulib_project.UserControls
{
    /// <summary>
    /// Interaction logic for BookInfo.xaml
    /// </summary>
    public partial class BookInfoDialog : UserControl
    {

        public string BookInfoDialogImage
        {
            get { return (String)GetValue(BookInfoDialogImageProperty); }
            set { SetValue(BookInfoDialogImageProperty, value); }
        }

        public static readonly DependencyProperty BookInfoDialogImageProperty =
            DependencyProperty.Register("BookInfoDialogImage", typeof(string),
            typeof(BookInfoDialog), new PropertyMetadata(""));

        public BookInfoDialog()
        {
            InitializeComponent();
            DataContext = this;
        }

    }
}
