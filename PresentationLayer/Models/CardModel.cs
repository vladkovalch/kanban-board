using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PresentationLayer.Models
{
    public class CardModel : INotifyPropertyChanged
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
        public int BoardId { get; set; }
        public int ListId { get; set; }
        public DateTime CreationTime { get; set; }
        public Color Color { get; set; }
        public ListModel Lists { get; set; }
        public ObservableCollection<UserModel> Participants { get; set; }
        public CardModel()
        {
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
