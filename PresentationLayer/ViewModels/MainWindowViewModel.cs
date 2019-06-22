using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        BoardModel _curBoard;
        public BoardModel CurBoard
        {
            get { return _curBoard; }
            set
            {
                _curBoard = value;
                OnPropertyChanged(nameof(CurBoard));
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
