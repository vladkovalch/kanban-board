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

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public int id = 0;
        CardModel card = new CardModel();
        ListModel list = new ListModel();
        BoardModel board = new BoardModel();
        public MainWindow()
        {
            Authorization authorization = new Authorization();
            authorization.ShowDialog();
            if (authorization.DialogResult != true)
                Close();
            InitializeComponent();
            DataContext = this;
        }

        private void NewTask_Click(object sender, RoutedEventArgs e)
        {

            New_task new_Task = new New_task();
            new_Task.ShowDialog();
            if (new_Task.DialogResult == true)
            {
                id++;
                card.Id = id;
                card.Name = new_Task.Text;
                card.CreationTime = DateTime.Now;
                card.Color = Color.FromArgb(1, 0, 0, 255);
                list.Cards.Add(card);
            }

        }
    }
}
