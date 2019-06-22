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
    public class NewTaskViewModel: INotifyPropertyChanged
    {
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






        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
