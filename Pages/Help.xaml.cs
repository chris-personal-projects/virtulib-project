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
using virtulib_project.Models;

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Help.xaml
    /// </summary>
    public partial class Help : Page
    {
        private MainViewModel _mainViewModel;

        public Help(MainViewModel mainViewModel)
        {
            InitializeComponent();
            addHelpItems();
            _mainViewModel = mainViewModel;
        }

        public void addHelpItems() {
            HelpItem helpItem;
            Border helpBorder;
            string[] categoryList = { "How to Search", "How to Return", "How to Sign Up", "Getting Started", "How to Change Settings", "Keeping Track of Due Dates", "Placing Holds", "Using Filters", "Tracking Availability" };
            for (int i = 0; i < 10; i++) {
                if (i > 8)
                {
                    helpItem = new HelpItem(categoryList[i - 9]);
                    helpItem.HelpItsemSelectedSelected += Help_Item_Summary;
                }
                else {
                    helpItem = new HelpItem(categoryList[i]);
                    helpItem.HelpItsemSelectedSelected += Help_Item_Summary;
                }

                helpBorder = new Border();
                helpBorder.Child = helpItem;
                HelpArticleGrid.Children.Add(helpBorder);
            }
        }

        private void Help_Item_Summary(object sender, RoutedEventArgs e)
        {
            // VirtulibBookSelectedEventArgs args = (VirtulibBookSelectedEventArgs)e;
            // BookInfoDialog bookInfoDialog = new BookInfoDialog(args);
            // bookInfoDialog.SnackbarMessageInit += InitSnackbarMessage;

            HelpDialog helpDialog = new HelpDialog();
            _mainViewModel.SetDialog(helpDialog);
        }
    }
}
