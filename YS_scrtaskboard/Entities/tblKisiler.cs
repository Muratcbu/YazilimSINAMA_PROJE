//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YS_scrtaskboard.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKisiler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKisiler()
        {
            this.tblGorevDurum = new HashSet<tblGorevDurum>();
            this.tblKullanicilar = new HashSet<tblKullanicilar>();
        }
    
        public int KisiID { get; set; }
        public string KisiAdSoyad { get; set; }
        public string KisiGorev { get; set; }
        public Nullable<int> Ort_Bitirme_Gün { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGorevDurum> tblGorevDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKullanicilar> tblKullanicilar { get; set; }
    }
}
