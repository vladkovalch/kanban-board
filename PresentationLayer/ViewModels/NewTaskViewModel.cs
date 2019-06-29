using AutoMapper;
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
    public class NewTaskViewModel: INotifyPropertyChanged
    {
        int _colId;
        Window _window;
        CardModel _card;
        public CardModel Card
        {
            get => _card;
            set
            {
                _card = value;
                OnPropertyChanged(nameof(Card));
            }
        }
        bool _loaderVisible;
        public bool LoaderVisible
        {
            get => _loaderVisible;
            set
            {
                _loaderVisible = value;
                OnPropertyChanged(nameof(LoaderVisible));
            }
        }

        public NewTaskViewModel(int colId, Window window)
        {
            _colId = colId;
            _window = window;
            _card = new CardModel();
        }

        private RelayCommand _saveCmd;
        public RelayCommand SaveCmd
        {
            get
            {
                return _saveCmd ?? (_saveCmd = new RelayCommand(() =>
                {
                    _card.CreationTime = DateTime.Now;
                    CardDTO card = Mapper.Map<CardDTO>(_card);
                    LoaderVisible = true;
                    Task.Run(() =>
                    {
                        try
                        {
                            if (!true)//proxy add
                                MessageBox.Show("No card added!");
                            else
                                App.Current.Dispatcher.Invoke(() => { _window.Close(); });
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!",
                                       MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        finally
                        {
                            LoaderVisible = false;
                        }
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
                    App.Current.Dispatcher.Invoke(() => { _window.Close(); });
                }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
