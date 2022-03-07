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
    public partial class SearchResult : Page, INotifyPropertyChanged
    {
        public SearchResult()
        {
            InitializeComponent();
            DataContext = this;
        }

        private bool m_isShow;
        private object m_dialogObject;


        public bool IsShow
        {
            get { return m_isShow; }
            set { m_isShow = value; OnPropertyChanged(); }
        }

        public object DialogObject
        {
            get { return m_dialogObject; }
            set
            {
                if (m_dialogObject == value) return;
                m_dialogObject = value; OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Book_Summary(object sender, RoutedEventArgs e)
        {
            DialogObject = new BookInfo();
            IsShow = !IsShow;
        }

        private void Open_Cart(object sender, RoutedEventArgs e)
        {
            DialogObject = new CheckoutControl();
            IsShow = !IsShow;
        }

    }
}
