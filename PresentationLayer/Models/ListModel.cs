using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace PresentationLayer.Models
{
    public class ListModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ObservableCollection<CardModel> Cards { get; set; }
        public Window MainWindow { get; set; }

        #region  InProgress
        //bool _canSave;
        //public bool CanSave
        //{
        //    get => _canSave;
        //    set
        //    {
        //        _canSave = value;
        //        OnPropertyChanged(nameof(CanSave));
        //    }
        //}
        //COMMANDS
        //private RelayCommand _addCardCmd;
        //public RelayCommand AddCardCmd
        //{
        //    get
        //    {
        //        return _addCardCmd ?? (_addCardCmd = new RelayCommand(() =>
        //        {
        //            New_task addCardWind = new New_task(Id);
        //            addCardWind.ShowDialog();
        //        }));
        //    }
        //}

        //private RelayCommand _editColumnCmd;
        //public RelayCommand EditColumnCmd
        //{
        //    get
        //    {
        //        return _editColumnCmd ?? (_editColumnCmd = new RelayCommand(() =>
        //        {
        //            AddEditColumnWindow editColWin = new AddEditColumnWindow(
        //                 (MainWindow.DataContext as MainWindowViewModel).CurBoard.Id,
        //                 this);
        //            editColWin.ShowDialog();
        //        }));
        //    }
        //}

        //private RelayCommand _delColumnCmd;
        //public RelayCommand DeleteColumnCmd
        //{
        //    get
        //    {
        //        return _delColumnCmd ?? (_delColumnCmd = new RelayCommand(() =>
        //        {
        //            MessageBoxResult res = MessageBox.Show(
        //                "Adre you sure? Delete column?", "Delete column", MessageBoxButton.YesNo,
        //                MessageBoxImage.Question);

        //            if (res != MessageBoxResult.Yes)
        //                return;

        //            (MainWindow.DataContext as MainWindowViewModel).LoaderVisible = true;
        //            Task.Run(() =>
        //            {
        //                try
        //                {
        //                    if (!true) //proxy delete column
        //                        MessageBox.Show("Column not deleted!");
        //                }
        //                catch (Exception e)
        //                {
        //                    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!",
        //                               MessageBoxButton.OK, MessageBoxImage.Error);
        //                }
        //                finally
        //                {
        //                    (MainWindow.DataContext as MainWindowViewModel).LoaderVisible = false;
        //                }
        //            });
        //        }));
        //    }
        //}
        #endregion
        public ListModel()
        {
            Cards = new ObservableCollection<CardModel>();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
