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
        private bool autoSalesQty = false;
        private PenjualanHdr penjualanHdr = null;
        private Kasir kasir = null;
        private Lokasi lokasi = null;

        public POS_sales()
        {
            InitializeComponent();
            using (var context = new PosContext())
            {
                
                
                Parameter parameter = (from p in context.ParameterContext
                                  select p).FirstOrDefault();
                if (parameter != null)
                {
                    autoSalesQty = parameter.autoQtySales;
                }
                
                kasir = (from k in context.KasirContext
                         where k.IdKasir == Func.VarGlobal.idKasir
                         select k).FirstOrDefault();
                
                lokasi = (from l in context.LokasiContext
                          where l.idLokasi == Func.VarGlobal.idLokasi
                          select l).FirstOrDefault();

            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = " [  " + DateTime.Now.ToString("d - MMM - yyyy") + " ] ";
            lblJAM.Text = " [  " + DateTime.Now.ToString("hh : mm : ss") + " ] ";
        }

        private void POS_sales_Load(object sender, EventArgs e)
        {
            lblUser.Text = Func.VarGlobal.UserNameLogin;
            //this.TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar.Equals((Char)13))
            if (e.KeyChar == (char)Keys.Enter)
            {   
                if (TxtCari.Text.Equals(""))
                {
                    // tidak ada action saat txt cari = kosong
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
                            if (autoSalesQty)
                            {
                                if (penjualanHdr == null)
                                {
                                    LblNoFaktur.Text = generateNoFaktur(DateTime.Now);
                                    penjualanHdr = new PenjualanHdr();
                                    penjualanHdr.isBayar = false;
                                    penjualanHdr.kasir = kasir;
                                    penjualanHdr.lastUpdate = DateTime.Now;
                                    penjualanHdr.lokasi = lokasi;
                                    penjualanHdr.noFaktur = LblNoFaktur.Text.Trim();
                                    penjualanHdr.batal = false;
                                    penjualanHdr.tanggalJual = DateTime.Now;
                                    penjualanHdr.totalBelanja = 0;
                                    context.PenjualanHdrContext.Add(penjualanHdr);
                                    context.SaveChanges();
                                }                                

                                // save penjualan dtl
                                PenjualanDtl penjualanDtl = new PenjualanDtl();
                                penjualanDtl.barang = barang;
                                penjualanDtl.harga = barang.hargaJual;
                                penjualanDtl.jumlah = 1;
                                penjualanDtl.penjualanHdr = penjualanHdr;                                
                                context.PenjualanDtlContext.Add(penjualanDtl);
                                context.SaveChanges();

                                // update total belanja di HDR
                                penjualanHdr.totalBelanja = penjualanHdr.totalBelanja + (barang.hargaJual);                                
                                context.PenjualanHdrContext.Find(penjualanHdr.idPenjualanHd);
                                context.SaveChanges();
                                LblGrandTotal.Text = " Rp. " + penjualanHdr.totalBelanja.ToString("#,###");

                                // kosongkan text cari
                                barang = null;
                                TxtCari.Text = "";
                            }
                            else
                            {                               
                                LblNamaBarang.Text = "[ " + barang.namaBarang.Trim() + " ]";
                                lblHarga.Text = " Rp. " + barang.hargaJual.ToString("#,###");
                                lblSatuan.Text = barang.SatuanKecil.NamaSatuan.Trim();
                                TxtJumlah.Focus();                        
                            }                                                        
                        }
                    } // End Using ( )
                }                                                
            }
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

        private string  generateNoFaktur(DateTime tgl)
        {
            string hasil="";
            using (var context = new PosContext())
            {
                PenjualanHdr penjualanHdr = (from p in context.PenjualanHdrContext
                                             where (p.tanggalJual.Month == tgl.Month && p.tanggalJual.Year == tgl.Year)
                                             orderby p.idPenjualanHd descending
                                             select p).FirstOrDefault();
                if (penjualanHdr == null)
                {
                    hasil = "F" +  DateTime.Now.ToString("yyMM") + "00001";
                }
                else
                {
                    string noFakturTerakhir = penjualanHdr.noFaktur.Substring(5,5);
                    Int32 noFakturTerakhirInt = Int32.Parse( noFakturTerakhir) +1;
                    hasil = "F" + DateTime.Now.ToString("yyMM") + ("0000" + noFakturTerakhirInt).Right(5);
                }                
            }
            return hasil;
        }
    
    }

    static class Extensions
    {
        /// <summary>
        /// Get substring of specified number of characters on the right.
        /// </summary>
        public static string Right(this string value, int length)
        {
            return value.Substring(value.Length - length);
        }
    }
}
