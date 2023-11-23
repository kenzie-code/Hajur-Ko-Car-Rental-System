using Microsoft.AspNetCore.Http;
using RootLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootLibrary.ViewModels
{
    public class MyPersonalVehicleForRentVM
    {
        public string VehicleName { get; set; }
        public string VehicleNo{ get; set; }
        public VehicleType VehicleType { get; set; }
        public string Description { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public IFormFile VehicleImage { get; set; }
        public int TotalPassenger { get; set; }
    }
}
