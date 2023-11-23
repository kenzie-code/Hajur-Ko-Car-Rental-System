using Microsoft.AspNetCore.Http;
using RootLibrary.Common;
using System.ComponentModel.DataAnnotations;

namespace RootLibrary.ViewModels
{
    public class CarsOnlineVM
    {
        [Required]
        public string VehcileName { get; set; }
        [Required]
        public VehicleType VehcileType { get; set; }
        [Required]
        public string VehcileNo { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal CostPerDay { get; set; }
        [Required]
        public int TotalPassenger { get; set; }
        [Required]
        public IFormFile ImageFile { get; set; }

    }
}
