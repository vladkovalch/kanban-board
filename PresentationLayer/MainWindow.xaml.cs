using MahApps.Metro.Controls;
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
using PresentationLayer.Models;
using PresentationLayer.ViewModels;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        //public int id = 0;
        //CardModel card = new CardModel();
        //ListModel list = new ListModel();
        //BoardModel board = new BoardModel();
        public MainWindow()
        {
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            if (authorization.DialogResult != true)
                Close();
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }

        
    }
}
