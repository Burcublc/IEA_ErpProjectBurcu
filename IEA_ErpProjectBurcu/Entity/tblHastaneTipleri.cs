//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_ErpProjectBurcu.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHastaneTipleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHastaneTipleri()
        {
            this.tblHastaneler = new HashSet<tblHastaneler>();
        }
    
        public int Id { get; set; }
        public string TipAdi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHastaneler> tblHastaneler { get; set; }
    }
}
