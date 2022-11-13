using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI_MobileApp
{
    public class DistributorModel
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name is too long.")]
        public string DistributorName { get; set; }
        [Required]
        [Phone]
        public string DistributorPhone { get; set; }
        [Required]
        public string DistributorStreetName { get; set; }
        [Required]
        [DisallowNull]
        public int? DistributorStreetNumber { get; set; }
        [Required]
        public string DistributorCityName { get; set; }
    }
}
