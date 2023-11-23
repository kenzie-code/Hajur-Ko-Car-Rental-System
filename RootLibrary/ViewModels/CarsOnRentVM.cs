using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootLibrary.ViewModels
{
    public class CarsOnRentVM
    {
        [Required]
        public int VehicleId { get; set; }

        [Required]
        public string VehicleNo { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public bool DriverRequire { get; set; }

        [Required]
        public DateTime RentedOn { get; set; }

        [Required]
        public int DaysRentDuration { get; set; }

        [Required]
        public decimal RentCostPerDay { get; set; }
    }
}
