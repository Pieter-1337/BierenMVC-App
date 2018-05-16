using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBierenApplication.Models
{
    public class BierProperties
    {
        [DisplayFormat(DataFormatString = "{0:000}")]
        public int BierNr { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve het naam veld in te vullen")]
        [StringLength(20, ErrorMessage = "De naam mag maximum 20 tekens lang zijn")]
        public string Naam { get; set; }
        public int BrouwerNr { get; set; }
        public int SoortNr { get; set; }

        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve het Alcohol veld in te vullen")]
        [Range(0, 15, ErrorMessage = "De alcohol waarde moet tussen de 0 en de 15 % liggen")]
        public float Alcohol { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve het Brouwer veld in te vullen")]
        public virtual Brouwer Brouwer { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve het Soort veld in te vullen")]
        public virtual Soort Soort { get; set; }

    }
}