using MahApps.Metro.Controls;
using PresentationLayer.Models;
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
using System.Windows.Shapes;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : MetroWindow
    {
        bool logHasErr;
        bool passHasErr;
        bool cpassHasErr;
        public string Log { get; set; }
        public string Pass { get; set; }
        public UserModel User;
        public Authorization()
        {
            logHasErr = true;
            passHasErr = true;
          
            InitializeComponent();
            User = new UserModel();
            Log_in_up.IsEnabled = false;
            LoginError.Visibility = Visibility.Collapsed;
            PassError.Visibility = Visibility.Collapsed;
            CPassError.Visibility = Visibility.Collapsed;
            Help.Visibility = Visibility.Collapsed;
            ConfirmPass.Visibility = Visibility.Collapsed;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                User.Email = Log;
                User.Sha256Password = Pass;
                DialogResult = true;
                Close();
            }
            catch (Exception exc)
            {
                LoginError.Text = exc.Message;
             }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 0)
            {
                LoginError.Text = "Empty login";
                logHasErr = true;
            }
            else if (((sender as TextBox).Text).IndexOf('@') <= 0)
            {
                LoginError.Text = @"The email must contain '@' symbol";
                logHasErr = true;
            }
            else
            {
                logHasErr = false;
                Log = (sender as TextBox).Text;
            }

            LoginError.Visibility = (logHasErr) ? Visibility.Visible : Visibility.Collapsed;
            ButtonTrigger();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as PasswordBox).Password.Length == 0)
            {
                PassError.Text = "Empty password";
                passHasErr = true;
            }
            else if (((sender as PasswordBox).Password).IndexOf(' ') >= 0)
            {
                PassError.Text = @"Delete spaces from password field";
                passHasErr = true;
            }
            else
            {
                //PassError.Text = (sender as PasswordBox).Password.ToString();
                passHasErr = false;
                Pass = (sender as PasswordBox).Password;
            }

            PassError.Visibility = (passHasErr) ? Visibility.Visible : Visibility.Collapsed;
            ButtonTrigger();
        }

        void ButtonTrigger()
        {
            Log_in_up.IsEnabled = (logHasErr || passHasErr || cpassHasErr) ? false : true;
        }

        private void ConfirmPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if ((sender as PasswordBox).Password.Length == 0)
            {
                CPassError.Text = "Empty confirm password";
                cpassHasErr = true;
            }
            else if (((sender as PasswordBox).Password).IndexOf(' ') >= 0)
            {
                CPassError.Text = @"Delete spaces from password field";
                cpassHasErr = true;
            }
            else if (((sender as PasswordBox).Password) != Password.Password)
            {
                CPassError.Text = @"Repeat the password";
                cpassHasErr = true;
            }
            else
            {
                cpassHasErr = false;
                //Pass = (sender as PasswordBox).Password;
            }

            CPassError.Visibility = (passHasErr) ? Visibility.Visible : Visibility.Collapsed;
            ButtonTrigger();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true)
            {
                Help.Visibility = Visibility.Visible;
                ConfirmPass.Visibility = Visibility.Visible;
            }
            else
            {
                Help.Visibility = Visibility.Collapsed;
                ConfirmPass.Visibility = Visibility.Collapsed;
            }
        }
    }
}
