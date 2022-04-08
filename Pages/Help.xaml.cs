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

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Page
    {
        public Help()
        {
            InitializeComponent();
            addHelpItems();
        }

        public void addHelpItems() {
            HelpItem helpItem;
            Border helpBorder;
            string[] categoryList = { "How to Search", "How to Return", "How to Sign Up", "Getting Started", "How to Change Settings", "Keeping Track of Due Dates", "Placing Holds", "Using Filters", "Tracking Availability" };
            for (int i = 0; i < 10; i++) {
                if (i > 8)
                {
                    helpItem = new HelpItem(categoryList[i - 9]);
                }
                else {
                    helpItem = new HelpItem(categoryList[i]);
                }
                
                helpBorder = new Border();
                helpBorder.Child = helpItem;
                HelpArticleGrid.Children.Add(helpBorder);
            }
        }
    }
}
