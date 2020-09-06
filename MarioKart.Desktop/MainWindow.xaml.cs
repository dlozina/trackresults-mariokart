using Client.API.API;
using Client.API.Data.Standings;
using MarioKart.Desktop.ViewModels;
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

namespace MarioKart.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StandingsButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new StandingsViewModel();
        }

        private void DriversButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new DriversViewModel();
        }

        private void RacesButtonClicked(object sender, RoutedEventArgs e)
        {
            DataContext = new RacesViewModel();
        }
    }
}
