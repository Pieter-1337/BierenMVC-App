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
        public string Naam { get; set; }

        //[DisplayFormat (DataFormatString = "{0:0.00}%")] -> heb de percenten via de UIHint meegegeven
        [UIHint ("KleurBierPercent")]
        public float Alcohol { get; set; }
    }
}