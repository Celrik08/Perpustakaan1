//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Perpustakaan.Database_Perpustakaan
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_buku_masuk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_buku_masuk()
        {
            this.tb_detail_buku_masuk = new HashSet<tb_detail_buku_masuk>();
        }
    
        public int id_buku_masuk { get; set; }
        public int id_pengirim { get; set; }
        public int id_username { get; set; }
        public System.DateTime tanggal_masuk { get; set; }
    
        public virtual tb_pengirim tb_pengirim { get; set; }
        public virtual tb_user tb_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_detail_buku_masuk> tb_detail_buku_masuk { get; set; }
    }
}
