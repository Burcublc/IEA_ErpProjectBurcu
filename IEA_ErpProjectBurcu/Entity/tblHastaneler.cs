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
    
    public partial class tblHastaneler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHastaneler()
        {
            this.tblHastaneDetaylar = new HashSet<tblHastaneDetaylar>();
            this.tblDoktorlar = new HashSet<tblDoktorlar>();
            this.tblDoktorlar1 = new HashSet<tblDoktorlar>();
            this.tblDoktorlar2 = new HashSet<tblDoktorlar>();
        }
    
        public int Id { get; set; }
        public string Adi { get; set; }
        public Nullable<int> TipId { get; set; }
        public string Adres { get; set; }
        public Nullable<int> SehirId { get; set; }
        public string Telefon { get; set; }
        public string CariAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
    
        public virtual Sehirler Sehirler { get; set; }
        public virtual tblHastaneTipleri tblHastaneTipleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHastaneDetaylar> tblHastaneDetaylar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDoktorlar> tblDoktorlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDoktorlar> tblDoktorlar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDoktorlar> tblDoktorlar2 { get; set; }
    }
}
