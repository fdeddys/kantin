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
        private Barang barang = null;
        
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
            //if (e.KeyChar.Equals((Char)13))
            if (e.KeyChar == (char)Keys.Enter)
            {   
                if (TxtCari.Text.Equals(""))
                {

                }
                else
                {
                    string cari = TxtCari.Text.Trim();
                    using (var context = new PosContext())
                    {
                        Barcode barcode = (from b in context.BarcodeContext
                                           where b.barcodeIsi == cari
                                           select b).FirstOrDefault();
                        if (barcode == null )
                        {                        
                            MessageBox.Show("not ketemu");                        
                        }
                        else 
                        {
                            barang = new Barang();
                            barang = barcode.Barang;
                            LblNamaBarang.Text = "[ " + barang.namaBarang.Trim() + " ]";
                            lblHarga.Text = " Rp. " + barang.hargaJual.ToString("#,###");
                            lblSatuan.Text = barang.SatuanKecil.NamaSatuan.Trim();
                        
                            TxtJumlah.Focus();                        
                        }
                    } // End Using ( )
                }                                                
            }
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.Equals((char)13))
            {
                // cek barang is null
                // cek qty is valid
                // cek apakah id penjualan sudah ada, jika iya langsung nambah di detil, jika tidak create header
                // refresh grid
                bool isBarangValid = false;
                bool isQtyValid = false;
                double jumlah =0;

                if (barang == null)
                {
                    MessageBox.Show("Barang belum di pilih", "Barang is null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    isBarangValid = true;
                }

                if (double.TryParse(TxtJumlah.Text, out jumlah))
                {
                    
                    if (jumlah > 1000)
                    {
                        MessageBox.Show("Barang tidak boleh lebih dari 1000 pcs", "Jumlah > 1000", MessageBoxButtons.OK);
                        TxtJumlah.SelectAll();
                    }
                    else
                    {
                        isQtyValid = true;
                    }
                }
                else
                {
                    MessageBox.Show("Qty bukan angka", "Error parse", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtJumlah.SelectAll();
                }

            };
            if (e.KeyChar == (char)Keys.Escape)
            {
                lblHarga.Text = "";
                LblNamaBarang.Text = "";
                lblSatuan.Text = "";
                barang = null;
                TxtJumlah.Text = "";                
                TxtCari.Focus();
                TxtCari.SelectAll();
            };
        }
    }
}
