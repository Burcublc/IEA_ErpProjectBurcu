using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProjectBurcu.BilgiGiris.Firmalar
{
    public enum FirmaTip
    {
        [Display(Name ="Müşteri")]
        Musteri,
        [Display(Name ="Tedarikçi")]
        Tedarikci,
        [Display(Name =("Distribütör"))]
        Distributor,
        Bayi,
        [Display(Name =("Ara Satıcı"))]
        AraSatici,
        [Display (Name =("Ana Satıcı"))]
        AnaSatici
    }
}
