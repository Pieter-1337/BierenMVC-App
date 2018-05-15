using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCBierenApplication.Models
{
    public class Bier
    {
        //[DisplayFormat (DataFormatString = "{0:000}")]// -> Heb format string gebruikt in bieren.csHtml zelf
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve een naam voor het bier in te vullen")]
        [StringLength(20, ErrorMessage = "De naam van het bier mag maximum 20 tekens lang zijn")]
        public string Naam { get; set; }

        //[DisplayFormat (DataFormatString = "{0:0.00}%")] -> heb de percenten via de UIHint meegegeven
        [UIHint ("KleurBierPercent")]
        [Range(0, 15, ErrorMessage = "Het alcohol percentage van het bier moet tussen de 0 en de 15% liggen")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Gelieve een alcohol percentage in te vullen")]
        public float Alcohol { get; set; }
    }
}