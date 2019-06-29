using MahApps.Metro.Controls;
using PresentationLayer.ViewModels;
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
    /// Interaction logic for New_task.xaml
    /// </summary>
    public partial class New_task : MetroWindow
    {
        public New_task(int colId)
        {
            DataContext = new NewTaskViewModel(colId, this);
            InitializeComponent();
        }
    }
}
