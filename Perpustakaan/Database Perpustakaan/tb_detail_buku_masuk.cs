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
    
    public partial class tb_detail_buku_masuk
    {
        public int id_detail_buku_masuk { get; set; }
        public int id_buku_masuk { get; set; }
        public int isbn { get; set; }
        public int id_satuan { get; set; }
        public int jumlah_isi { get; set; }
    
        public virtual tb_buku tb_buku { get; set; }
        public virtual tb_buku_masuk tb_buku_masuk { get; set; }
        public virtual tb_satuan tb_satuan { get; set; }
    }
}
