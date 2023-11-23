using Microsoft.AspNetCore.Http;
using RootLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RootLibrary.ViewModels
{
    public class RequestVM
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime RequestedDT { get; set; }
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
