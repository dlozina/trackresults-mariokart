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
    /// Interaction logic for Drivers.xaml
    /// </summary>
    public partial class Drivers : UserControl
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadDrivers();
        }

        private async Task LoadDrivers()
        {
            //http://localhost:8080/api/standings
            List<Model.Driver> driversList = await ApiProcessor.LoadApiCall<List<Model.Driver>>("http://localhost:8080/api/drivers");
            // Famozni Data Grid
            dgDrivers.ItemsSource = driversList;
        }
    }
}
