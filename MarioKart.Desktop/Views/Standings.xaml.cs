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
    /// Interaction logic for Standings.xaml
    /// </summary>
    public partial class Standings : UserControl
    {
        public Standings()
        {
            InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadStandings();
        }

        private async Task LoadStandings()
        {
            //http://localhost:8080/api/standings
            List<Client.API.Data.Standings.Standings> standingsList = await ApiProcessor.LoadApiCall<List<Client.API.Data.Standings.Standings>>("http://localhost:8080/api/standings");
            // Famozni Data Grid
            dgStandings.ItemsSource = standingsList;
        }
    }
}
