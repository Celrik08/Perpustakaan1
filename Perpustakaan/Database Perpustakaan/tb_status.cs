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
    
    public partial class tb_status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_status()
        {
            this.tb_kembali = new HashSet<tb_kembali>();
            this.tb_pinjam = new HashSet<tb_pinjam>();
            this.tb_riwayat_kembali = new HashSet<tb_riwayat_kembali>();
            this.tb_riwayat_pinjam = new HashSet<tb_riwayat_pinjam>();
        }
    
        public int id_status { get; set; }
        public string nama_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_kembali> tb_kembali { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_pinjam> tb_pinjam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_riwayat_kembali> tb_riwayat_kembali { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_riwayat_pinjam> tb_riwayat_pinjam { get; set; }
    }
}
