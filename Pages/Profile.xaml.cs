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

namespace virtulib_project.Pages
{
    /// <summary>
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PersonalEdit(object sender, RoutedEventArgs e)
        {

            if(Personal_Button.Content.ToString() == "Change?")
            {
                NameText.Visibility = Visibility.Hidden;
                NameBox.Visibility = Visibility.Visible;
                NameBox.IsReadOnly = false;

                EmailText.Visibility = Visibility.Hidden;
                EmailBox.Visibility = Visibility.Visible;
                EmailBox.IsReadOnly = false;

                PhoneText.Visibility = Visibility.Hidden;
                PhoneBox.Visibility = Visibility.Visible;
                PhoneBox.IsReadOnly = false;

                AddressText.Visibility = Visibility.Hidden;
                AddressBox.Visibility = Visibility.Visible;
                AddressBox.IsReadOnly = false;

                Personal_Button.Content = "Save?";
            }
            else if (Personal_Button.Content.ToString() == "Save?")
            {
                NameText.Visibility = Visibility.Visible;
                NameBox.Visibility = Visibility.Hidden;
                NameBox.IsReadOnly = true;
                NameText.Text = NameBox.Text;

                EmailText.Visibility = Visibility.Visible;
                EmailBox.Visibility = Visibility.Hidden;
                EmailBox.IsReadOnly = true;
                EmailText.Text = EmailBox.Text;

                PhoneText.Visibility = Visibility.Visible;
                PhoneBox.Visibility = Visibility.Hidden;
                PhoneBox.IsReadOnly = true;
                PhoneText.Text = PhoneBox.Text;

                AddressText.Visibility = Visibility.Visible;
                AddressBox.Visibility = Visibility.Hidden;
                AddressBox.IsReadOnly = true;
                AddressText.Text = AddressBox.Text;

                Personal_Button.Content = "Change?";
            }

        }

        private void MembershipChange(object sender, RoutedEventArgs e)
        {
            if (Membership_Button.Content.ToString() == "Change?")
            {
                MembershipBox.IsEnabled = true;
                Membership_Button.Content = "Save?";
            }
            else if (Membership_Button.Content.ToString() == "Save?")
            {
                MembershipBox.IsEnabled = false;
                Membership_Button.Content = "Change?";
            }
        }

        private void PrivacyChange(object sender, RoutedEventArgs e)
        {
            if (Privacy_Button.Content.ToString() == "Change?")
            {
                TwoFactorBox.IsEnabled = true;
                Privacy_Button.Content = "Save?";
                PasswordBox.Visibility = Visibility.Hidden;
                PasswordText.Visibility = Visibility.Visible;

            }
            else if (Privacy_Button.Content.ToString() == "Save?")
            {
                TwoFactorBox.IsEnabled = false;

              
                PasswordBox.Visibility = Visibility.Visible;
                PasswordText.Visibility = Visibility.Hidden;
                PasswordBox.Password = PasswordText.Text;


                if (TwoFactorBox.Text == "ENABLED")
                {
                    TwoFactorBox.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF1B8B0A"));
                    
                }
                else if(TwoFactorBox.Text == "DISABLED")
                {
                    TwoFactorBox.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF0000"));
                }
                Privacy_Button.Content = "Change?";
            }
        }
    }
}
