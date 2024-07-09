using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Perpustakaan
{
    // Definisikan kelas User
    public class User
    {
        public int id_username { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int id_role { get; set; }

        // Definisikan properti lainnya jika diperlukan
        public virtual Role UserRole { get; set; } // Lengkapkan definisi properti
    }

    // Relasi Role
    public class Role
    {
        [Key]
        public int id_role { get; set; }
        // Tambahkan properti lain jika diperlukan
    }

    // Definisikan kelas Connect
    public class Connect : DbContext
    {
        public Connect() : base(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=perpustakaan;Integrated Security=True")
        {
        }

        // Tambahkan properti DbSet untuk setiap entitas yang akan Anda gunakan di aplikasi Anda
        public DbSet<User> tb_user { get; set; } // Ganti 'User' dengan nama entitas yang sesuai
        public DbSet<Role> tb_role { get; set; } // Tambahkan DbSet untuk Role
        // Tambahkan properti DbSet lainnya jika diperlukan
    }
}