using RootLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RootLibrary.ViewModels
{
    public class StaffVM
    {
        [Required]
        [MaxLength(250), MinLength(3)]
        [Display(Name = "Staff Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(250), MinLength(3)]
        [Display(Name = "Staff Address")]
        public string Email { get; set; }

        [Required]
        [MaxLength(250), MinLength(3)]
        [Display(Name = "Staff Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Staff's position")]
        public StaffPosition Position { get; set; }

        [Required]
        [MaxLength(250), MinLength(3)]
        public string Password { get; set; }
    }
}
