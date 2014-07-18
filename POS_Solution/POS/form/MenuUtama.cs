using POS.form.master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.form
{
    public partial class MenuUtama : Form
    {
        public static string userLogin="-";
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = " - Waktu Sekarang : " + DateTime.Now.ToString("dd MMMM yyyy - hh : mm : ss");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuUtama_Activated(object sender, EventArgs e)
        {
            if (userLogin.Equals("-"))
            {
                LoginUtama loginUtama = new LoginUtama();
                loginUtama.ShowDialog();
                if (userLogin.Equals("x"))
                {
                    this.Close();
                }
                else
                {
                    toolStripStatusLabel1.Text = " Selamat Datang " + userLogin.ToUpper();
                    toolStripStatusLabel2.Text = " - Login : " + DateTime.Now.ToString("dd MMMM yyyy - hh : mm : ss");
                }
            };
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMasterItem frmMasterItem = new FrmMasterItem();
            frmMasterItem.Show();
        }

        private void btnMasterBarang_Click(object sender, EventArgs e)
        {
            if (barangToolStripMenuItem.Enabled == true)
            {
                barangToolStripMenuItem_Click(sender,e);
            }
        }
    }
}
