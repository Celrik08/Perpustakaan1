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
    public partial class FormLogin : Form
    {
        private Connect context; // Ganti Connect dengan nama konteks data anda
        public FormLogin()
        {
            InitializeComponent();
            context = new Connect(); // Ganti Connect dengan nama konteks data anda
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerfromLogin();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerfromLogin();
        }

        private void PerfromLogin()
        {
            string Username = TextUser.Text;
            string Password = TextPassword.Text;

            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query menggunakan LINQ to Entities
            var user = context.tb_user.FirstOrDefault(u => u.username == Username && u.password == Password);

            if (user != null)
            {
                int roleId = user.id_role; // Menggunakan properti id_role dari tb_user
                if (roleId >= 1 && roleId <= 4)
                {
                    MenuUtama menuUtama = new MenuUtama(roleId);
                    menuUtama.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Role ID tidak valid", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextUser.Text = "";
                TextPassword.Text = "";
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                TextPassword.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
            }
            else
            {
                TextPassword.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}