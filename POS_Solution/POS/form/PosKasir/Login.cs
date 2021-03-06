﻿using POS.Context;
using POS.Func;
using POS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
                Func.VarGlobal.NamaPrinter = iniFile.IniReadValue("config", "namaPrinter");
                Func.VarGlobal.isPosSwalayan = byte.Parse( iniFile.IniReadValue("config", "posSwalayan"));
                Func.VarGlobal.isPosRestaurant = byte.Parse(iniFile.IniReadValue("config", "posRestaurant"));

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
                            Func.VarGlobal.Header1 = lokasi.namaStore.Trim();
                            Func.VarGlobal.Header2 = lokasi.alamat1.Trim();
                            Func.VarGlobal.Header3 = lokasi.alamat2.Trim();
                            
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
                    string hasil = Enkripsi(txtPassword.Text.Trim(), txtUserId.Text.ToString().Length);
                    if (hasil == kasir.Password && kasir.Aktif == true)
                    {
                        loginValid = true;
                    }                    
                }
                else
                {
                    //MessageBox.Show("User not found", "kasir is null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            //loginValid = true;

            if (loginValid) {
                txtUserId.Focus();
                Func.VarGlobal.UserNameLogin = kasir.NamaKasir;
                Func.VarGlobal.namaLokasi = lblPOS.Text;
                Func.VarGlobal.idKasir = kasir.KasirID;
                Func.VarGlobal.idLokasi = lokasi.LokasiID;

                if (Func.VarGlobal.isPosSwalayan == 1)
                {
                    POS_sales PosSales = new POS_sales();
                    PosSales.Show();
                }
                else
                {
                    if (Func.VarGlobal.isPosRestaurant == 1)
                    {
                        POS_Restaurant posRestaurant = new POS_Restaurant();
                        posRestaurant.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kesalahan setting file config, silahkan hubungi admin !!! ", "Error setting.ini", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                    
                }                
                txtUserId.Text = "";
                txtPassword.Text = "";
                
                //this.Hide();
            }
            else
            {
                MessageBox.Show("User name atau password tidak ditemukan atau user tidak aktif !! ", "User is null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserId.Focus();
            }
            
        }
    
        private string Enkripsi(string cText , Int32 nPjg )
        {
            string  Output, Inputan ;
            Int32 Panjang_Input ;
          
            Output = "";            
            Inputan = cText;
            Panjang_Input = cText.Length ;

            Int32 hasil;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(cText);
            foreach (byte b in asciiBytes)
            {
                //txtUserId.Text = txtUserId.Text + " " + b;
                hasil = Int32.Parse( b.ToString()) + 30 - nPjg;
                //txtPassword.Text = txtPassword.Text + " " + (char)(hasil);
                Output = Output + (Char)(hasil);
            }
            //for (i=1; i <= Panjang_Input;i++)
            //{
            //    Enkrip = Inputan.Substring(i-1, 1);
            //    txtUserId.Text = txtUserId.Text + "  " + Convert.ToInt32(Enkrip).ToString("X");
                    
            //        //(int.Parse(Enkrip)).ToString("X");

            //    Enkrip = (int.Parse(Enkrip) + 30 - nPjg ).ToString() ;
            //    //txtUserId.Text = txtUserId.Text + "  " + Enkrip;
            //    //txtUserId.Text = txtUserId.Text + "  " + Convert.ToChar(int.Parse(Enkrip));
            //    //Enkrip = (Enkrip + 30) - nPjg ;
            //    //Enkrip = ((Char)Enkrip) ;
            //    //Output = Output + (char)(Enkrip).ToString();
            //}
            //MessageBox.Show(Output, "a");                             
            return Output ;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtUserId.Text.Equals(""))
                {
                    txtUserId.Focus();
                }
                else
                {
                    btnLogin_Click(sender, e);
                };

            };
        }        
     
    }
}
