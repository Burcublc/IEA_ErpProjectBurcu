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
    
    public partial class tblHastaneDetaylar
    {
        public int Id { get; set; }
        public Nullable<int> GirisId { get; set; }
        public string YetkiliAdi { get; set; }
        public Nullable<int> DepartmanId { get; set; }
        public string Tel { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
    
        public virtual tblDepartmanlar tblDepartmanlar { get; set; }
        public virtual tblHastaneler tblHastaneler { get; set; }
    }
}
