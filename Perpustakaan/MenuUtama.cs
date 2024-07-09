using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class MenuUtama : Form
    {
        private int roleId; // Tambahkan variabel roleId
        public MenuUtama(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;

            // Ganti pengecekan level dengan pengecekan roleId
            if (roleId == 1)
            {
                DataMaster.Visible = true;
                DataBuku2.Visible = true;
                DataPinjam.Visible = true;
                Peminjaman.Visible = false;
                DataPengembalian.Visible = true;
                Pengembalian.Visible = false;
                DataMasuk.Visible = true;
                TransaksiMasuk.Visible = false;
                RiwayatPinjam.Visible = false;
                Keranjang.Visible = false;
            }

            else if (roleId == 2)
            {
                DataMaster.Visible = false;
                DataBuku2.Visible = false;
                DataPinjam.Visible = false;
                Peminjaman.Visible = true;
                DataPengembalian.Visible = false;
                Pengembalian.Visible = true;
                DataPengirim.Visible = true;
                DataMasuk.Visible = false;
                TransaksiMasuk.Visible = true;
                RiwayatPinjam.Visible = false;
                Keranjang.Visible = false;
            }

            else if (roleId == 3)
            {
                DataMaster.Visible = false;
                DataBuku2.Visible = true;
                DataPinjam.Visible = false;
                Peminjaman.Visible = true;
                DataPengembalian.Visible = false;
                Pengembalian.Visible = true;
                DataPengirim.Visible = false;
                DataMasuk.Visible = false;
                TransaksiMasuk.Visible = false;
                RiwayatPinjam.Visible = true;
                Keranjang.Visible = true;

            }

            User.Text = GetRoleName(roleId);
        }

        private string GetRoleName(int roleId)
        {
            switch (roleId)
            {
                case 1:
                    return "Admin";
                case 2:
                    return "Petugas";
                case 3:
                    return "Siswa";
                default:
                    return "Unknown";
            }
        }
    }
}
