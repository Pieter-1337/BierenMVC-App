//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCBierenApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Brouwer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brouwer()
        {
            this.Bieren = new HashSet<Bier>();
        }
    
        public int BrouwerNr { get; set; }
        public string BrNaam { get; set; }
        public string Adres { get; set; }
        public short PostCode { get; set; }
        public string Gemeente { get; set; }
        public Nullable<int> Omzet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bier> Bieren { get; set; }
    }
}