using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NER_Agile.Models
{
    public class InstallationModel
    {
        
        public int RegistrationNumber { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Postcode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Energy { get; set; }
        [Required]
        public string Integration { get; set; }
        [Required]
        public string PVCells { get; set; }
        [Range(0, 360)]
        [Required]
        public double FieldOrientation { get; set; }
        [Range(0, 360)]
        [Required]
        public double SlopRoof { get; set; }
        [Required]
        public double Length { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Area { get; set; }
    }
}
