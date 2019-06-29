using BusinessLogicLayer.DTO;
using GalaSoft.MvvmLight.Command;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PresentationLayer.ViewModels
{
    public class RegistrationWindowViewModel : INotifyPropertyChanged
    {
        Window _window;
        UserModel _user;
        public UserModel User { get => _user; }
        public RegistrationWindowViewModel(Window window)
        {
            _window = window;
            _user = new UserModel();
        }

        private bool _loaderVisible;
        public bool LoaderVisible
        {
            get => _loaderVisible;
            set
            {
                _loaderVisible = value;
                OnPropertyChanged(nameof(LoaderVisible));
            }
        }

        private RelayCommand _signUpCmd;
        public RelayCommand SignUpCmd
        {
            get
            {
                return _signUpCmd ?? (_signUpCmd = new RelayCommand(() =>
                {
                    LoaderVisible = true;
                    Task.Run(() => {
                        try
                        {
                            if (true)//NetProxy.RegProxy.RegisterUser(new UserDTO { Email = User.Email }, User.Sha256Password))
                            {
                               // Token = NetProxy.AuthProxy.Login(User.Email, User.Sha256Password);
                                _window.Dispatcher.Invoke(() =>
                                {
                                    _window.DialogResult = true;
                                    _window.Close();
                                });
                            }
                            else
                                MessageBox.Show("User is alredy exist!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        LoaderVisible = false;
                    });
                }));
            }
        }

        //COMMANDS
        private RelayCommand _loginCmd;
        public RelayCommand LoginCmd
        {
            get
            {
                return _loginCmd ?? (_loginCmd = new RelayCommand(() =>
                {
                    LoaderVisible = true;
                    Task.Run(() => {
                        try
                        {
                           //
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        LoaderVisible = false;
                    });
                }));
            }
        }

        private RelayCommand _cancelCmd;
        public RelayCommand CancelCmd
        {
            get
            {
                return _cancelCmd ?? (_cancelCmd = new RelayCommand(() =>
                {
                    _window.DialogResult = false;
                    _window.Close();
                }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
