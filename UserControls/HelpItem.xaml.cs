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
    /// Interaction logic for HelpItem.xaml
    /// </summary>
    public partial class HelpItem : UserControl
    {
        public HelpItem(String title)
        {
            InitializeComponent();
            DataContext = this;
            HelpSummaryDescription = title;
            
        }

        public string HelpSummaryDescription
        {
            get { return (String)GetValue(HelpSummaryDescriptionProperty); }
            set { SetValue(HelpSummaryDescriptionProperty, value); }
        }

        public static readonly DependencyProperty HelpSummaryDescriptionProperty =
            DependencyProperty.Register("HelpSummaryDescription", typeof(string),
            typeof(HelpItem), new PropertyMetadata(""));

        private void Help_Details_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
