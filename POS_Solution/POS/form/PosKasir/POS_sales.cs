using POS.Context;
using POS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.form.PosKasir
{
    public partial class POS_sales : Form
    {
        public POS_sales()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = " [  " + DateTime.Now.ToString("d - MMM - yyyy") + " ] ";
            lblJAM.Text = " [  " + DateTime.Now.ToString("hh : mm : ss") + " ] ";
        }

        private void POS_sales_Load(object sender, EventArgs e)
        {
            lblUser.Text = Func.VarGlobal.UserNameLogin;
            this.TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void POS_sales_FormClosing(object sender, FormClosingEventArgs e)
        {
                        
        }

        private void TxtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((Char)13))
            {

                bool ketemu = false;
                string cari = TxtCari.Text.Trim();
                using (var context = new PosContext())
                {
                    Barcode barcode = (from b in context.BarcodeContext
                                       where b.barcodeIsi == cari
                                       select b).FirstOrDefault();
                    if (barcode == null )
                    {
                        ketemu = false;
                        MessageBox.Show("not ketemu");
                    }
                    else 
                    {
                        ketemu = true;
                        MessageBox.Show("ketemu");
                    }
                }
                
                
            }
        }
    }
}
