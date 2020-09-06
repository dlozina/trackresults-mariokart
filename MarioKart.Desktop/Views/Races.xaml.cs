using Client.API.API;
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

namespace MarioKart.Desktop.Views
{
    /// <summary>
    /// Interaction logic for Races.xaml
    /// </summary>
    public partial class Races : UserControl
    {
        public Races()
        {
            InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadRaces();
        }

        private async Task LoadRaces()
        {
            //http://localhost:8080/api/standings
            List<Model.Race> raceList = await ApiProcessor.LoadApiCall<List<Model.Race>>("http://localhost:8080/api/races");
            // Famozni Data Grid
            dgRaces.ItemsSource = raceList;
        }
    }
}
