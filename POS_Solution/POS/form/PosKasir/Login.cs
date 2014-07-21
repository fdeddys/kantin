using POS.Context;
using POS.Func;
using POS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POS.form.PosKasir
{
    public partial class Login : Form
    {
        Lokasi lokasi = null;
        public Login()
        {
            InitializeComponent();
            //animForm();
            
            try
            {
                string pathExe = AppDomain.CurrentDomain.BaseDirectory.ToString();
                //MessageBox.Show(pathExe);
                IniFile iniFile = new IniFile(pathExe +  "setting.ini");                
                string hasil = iniFile.IniReadValue("config","lokasi");
                if (hasil != "")
                {
                    lblPOS.Text = hasil;
                    Int32 hasilInt = Int32.Parse(hasil);

                    using (var context = new PosContext())
                    {
                        lokasi = (from l in context.LokasiContext
                                         where l.LokasiID == hasilInt
                                         select l).FirstOrDefault();
                        if (lokasi != null)
                        {
                            lblPOS.Text = lokasi.NamaLokasi.Trim();
                        }
                    };
                }                
            }
            catch (Exception e)
            {                
                //throw e;
                MessageBox.Show(e.Message.ToString());
            }
            

        }

        private void animForm(){
            System.Drawing.Drawing2D.GraphicsPath shape = new System.Drawing.Drawing2D.GraphicsPath();
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new System.Drawing.Region(shape);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtTanggal.Text = DateTime.Now.ToString("d - MMM - yyyy");
            lblTanggal.Text = " [  " + DateTime.Now.ToString("d - MMM - yyyy") + " ] ";
            lblJAM.Text = " [  " + DateTime.Now.ToString("hh : mm : ss") + " ] ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginValid = false;
            Kasir kasir = null;
            using (var context = new PosContext())
            {
                kasir = (from k in context.KasirContext
                               where k.KodeKasir == txtUserId.Text.Trim()
                               select k).FirstOrDefault();
                if (kasir != null)
                {
                    loginValid = true;
                }
                else
                {
                    MessageBox.Show("User not found", "kasir is null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (loginValid) {
                Func.VarGlobal.UserNameLogin = kasir.NamaKasir;
                Func.VarGlobal.idKasir = kasir.KasirID;
                Func.VarGlobal.idLokasi = lokasi.LokasiID;
                POS_sales PosSales = new POS_sales();
                PosSales.Show();
                //this.Hide();
            }
            
        }
    }
}
