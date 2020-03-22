using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarioKartWeb.ViewModel
{
    public class DriverInfoIndexViewModel
    {
        public DriverInfoIndexViewModel(IEnumerable<DriverInfoViewModel> driversInfo)
        {
            this.DriversInfo = driversInfo;
        }

        public IEnumerable<DriverInfoViewModel> DriversInfo { get; private set; }
    }
}