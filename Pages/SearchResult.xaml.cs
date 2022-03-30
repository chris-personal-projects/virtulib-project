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
using virtulib_project.UserControls;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for SearchResult.xaml
    /// </summary>
    public partial class SearchResult : Page
    {
        public SearchResult()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Book_Summary(object sender, RoutedEventArgs e)
        {

        }
    }
}
