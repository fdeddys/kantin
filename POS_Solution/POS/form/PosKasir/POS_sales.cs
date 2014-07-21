﻿using POS.Context;
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
        private Double jumlahBelanja = 0;
        private bool editQtyMode = false;

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
                         where k.KasirID == Func.VarGlobal.idKasir
                         select k).FirstOrDefault();
                
                lokasi = (from l in context.LokasiContext
                          where l.LokasiID == Func.VarGlobal.idLokasi
                          select l).FirstOrDefault();

            };
            konfigDatagrid();
            //previewGrid();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = " [  " + DateTime.Now.ToString("d - MMM - yyyy") + " ] ";
            lblJAM.Text = " [  " + DateTime.Now.ToString("hh : mm : ss") + " ] ";
        }

        private void POS_sales_Load(object sender, EventArgs e)
        {
            lblUser.Text = Func.VarGlobal.UserNameLogin;
            //setHeaderGrid();
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
                    Barcode barcode;

                    PosContext context = new PosContext();

                    //using (var context = new PosContext() )
                    //{
                        var barcode1 = (from b in context.BarcodeContext
                                   where b.barcodeIsi == cari
                                   select b).FirstOrDefault();
                        barcode = barcode1;
                    //}

                        if (barcode == null)
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
                                    penjualanHdr.KasirID = kasir.KasirID;
                                    penjualanHdr.lastUpdate = DateTime.Now;
                                    penjualanHdr.LokasiID = lokasi.LokasiID;
                                    penjualanHdr.noFaktur = LblNoFaktur.Text.Trim();
                                    penjualanHdr.batal = false;
                                    penjualanHdr.tanggalJual = DateTime.Now;
                                    penjualanHdr.totalBelanja = 0;                                    
                                    //using (var context = new PosContext())
                                    //{
                                    context.PenjualanHdrContext.Add(penjualanHdr);
                                    context.SaveChanges();
                                    //}
                                    jumlahBelanja = 0;

                                }

                                // save penjualan dtl
                                PenjualanDtl penjualanDtl = new PenjualanDtl();
                                penjualanDtl.BarangID = barang.BarangID;
                                penjualanDtl.harga = barang.hargaJual;
                                penjualanDtl.jumlah = 1;
                                penjualanDtl.PenjualanHdrID = penjualanHdr.PenjualanHdrID;
                                //using (var context = new PosContext())
                                //{
                                context.PenjualanDtlContext.Add(penjualanDtl);
                                context.SaveChanges();

                                jumlahBelanja = jumlahBelanja + (barang.hargaJual);
                                //}

                                // update total belanja di HDR
                                //penjualanHdr.PenjualanDtl.Add(penjualanDtl);
                                //penjualanHdr.totalBelanja = penjualanHdr.totalBelanja + (barang.hargaJual);
                                //using (var context = new PosContext())
                                //{                                

                                PenjualanHdr updatePenjualanHdr = context.PenjualanHdrContext.Single(p=>p.PenjualanHdrID== penjualanHdr.PenjualanHdrID);
                                updatePenjualanHdr.totalBelanja = jumlahBelanja;
                                //updatePenjualanHdr.totalBelanja = updatePenjualanHdr.totalBelanja + (barang.hargaJual);
                                context.SaveChanges();
                                //context.Entry(penjualanHdr).State = System.Data.Entity.EntityState.Modified;
                                //context.SaveChanges();
                                //}
                                
                                //LblGrandTotal.Text = " Rp. " + updatePenjualanHdr.totalBelanja.ToString("#,###");
                                LblGrandTotal.Text = " Rp. " + jumlahBelanja.ToString("#,###");

                                // kosongkan text cari
                                barang = null;
                                TxtCari.Text = "";
                                previewGrid();
                            }
                            else
                            {
                                LblNamaBarang.Text = "[ " + barang.namaBarang.Trim() + " ]";
                                lblHarga.Text = " Rp. " + barang.hargaJual.ToString("#,###");
                                lblSatuan.Text = barang.SatuanKecil.NamaSatuan.Trim();
                                TxtJumlah.Focus();
                            }
                        }
                    //}// End context
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
                                             orderby p.PenjualanHdrID descending
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

        private void setHeaderGrid()
        {
            
            //dgvListBarang.ColumnCount = 4;
            // Header
            dgvListBarang.Columns[0].HeaderText = "Kode";
            dgvListBarang.Columns[1].HeaderText = "Nama";
            dgvListBarang.Columns[2].HeaderText = "Satuan";
            dgvListBarang.Columns[3].HeaderText = "Harga";
            dgvListBarang.Columns[4].HeaderText = "Jumlah";
            dgvListBarang.Columns[5].HeaderText = "Total";
            dgvListBarang.Columns[6].HeaderText = "idx";

            dgvListBarang.Columns[6].Visible = false;

            // Width
            dgvListBarang.Columns[0].Width = 100;
            dgvListBarang.Columns[1].Width = 300;
            dgvListBarang.Columns[2].Width = 100;
            dgvListBarang.Columns[3].Width = 200;
            dgvListBarang.Columns[4].Width = 100;


            dgvListBarang.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListBarang.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListBarang.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListBarang.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListBarang.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvListBarang.Columns[3].DefaultCellStyle.Format = "#,###";            
            dgvListBarang.Columns[5].DefaultCellStyle.Format = "#,###";

        }

        private void konfigDatagrid()
        {
            Font font = new Font("Courier New", 12.0f);
            dgvListBarang.AllowDrop = false;
            dgvListBarang.AllowUserToAddRows = false;
            dgvListBarang.AllowUserToDeleteRows = false;
            dgvListBarang.AllowUserToResizeRows = false;
            dgvListBarang.RowHeadersVisible = false;
            dgvListBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListBarang.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            dgvListBarang.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.IndianRed;
            dgvListBarang.ForeColor = Color.Navy;
            dgvListBarang.BackgroundColor = Color.WhiteSmoke;
            dgvListBarang.Font = font;
            
            //dGVBarang.Font.Name = "Courier New";
        }

        private void previewGrid()
        {
            {
                using(var context = new PosContext() )
                {
                    var ListBarang = from b in context.PenjualanDtlContext
                                     where b.batal == false && b.PenjualanHdrID == penjualanHdr.PenjualanHdrID                                      
                                     select new { b.Barang.kodeBarang, b.Barang.namaBarang, b.Barang.SatuanKecil.NamaSatuan , b.harga, b.jumlah, total = (b.jumlah * b.harga), b.penjualanDtlID };
                    dgvListBarang.DataSource = ListBarang.ToList();
                }
            }
            setHeaderGrid();
        }

        private void TxtCari_KeyUp(object sender, KeyEventArgs e)
        {
            // F2 - Pembayaran Barang 
            //      tampilkan panel Bayar
            if(e.KeyData == Keys.F2)
            {                
                using (var context = new PosContext())
                {
                    PenjualanHdr cari = (from h in context.PenjualanHdrContext
                                                 where h.PenjualanHdrID == penjualanHdr.PenjualanHdrID
                                                 select h).FirstOrDefault();
                    if (cari == null)
                    {
                        MessageBox.Show("Tidak ada data untuk pembayaran", "Penjualan null");
                    }
                    else
                    {
                        jumlahBelanja = cari.totalBelanja;
                    }
                }
                panelBayar.Visible = true;
                panelBayar.Height = 313;
                panelBayar.Width = 559;
                lblBayarTotalBelanja.Text = jumlahBelanja.ToString("#,###");
                lblBayarTotalKembali.Text = "";                
                txtJumlahBayar.Focus();
            };

            // F4 - Ubah qty, hapus  
            //      focus pindah ke grid
            if (e.KeyCode == Keys.F4)
            {
                dgvListBarang.Focus();
            };
        }

        private void txtJumlahBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                // ENTER PEMBAYARAN 
                // proses Pembayaran
                //  1. cek apakah jumlah bayar angka
                //  2. cek apakah jumlah bayar cukup dg total belanja
                //
                // Update Pembayaran HDR
                //  1. bayar = true
                //  2. total belanja
                //  3. jumlah uang yang di input
                //  4. reset kondisi awal
                double jumlahBayar = 0;
                if (double.TryParse(txtJumlahBayar.Text, out jumlahBayar))
                {
                    if( jumlahBayar >= jumlahBelanja) 
                    {
                        using (var context = new PosContext())
                        {
                            var updatePenjualanHdr = context.PenjualanHdrContext.Single(h => h.PenjualanHdrID == penjualanHdr.PenjualanHdrID);
                            updatePenjualanHdr.isBayar = true;
                            updatePenjualanHdr.totalBelanja = jumlahBelanja;
                            updatePenjualanHdr.jumlahBayar = jumlahBayar;
                            context.SaveChanges();                                     
                        }                
                        penjualanHdr = null;
                        TxtCari.Focus();
                        panelBayar.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Jumlah pembayaran tidak mencukupi belanja !", "Jumlah Belanja lebih besar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                }
                else
                {
                    MessageBox.Show("INVALID Jumlah Bayar !! ", "bayar Not Numeric", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                              
            }
        }

        private void txtJumlahBayar_KeyUp(object sender, KeyEventArgs e)
        {
            // KEYPRESS pada jumlah bayar
            // saat pembayaran -> tombol ESC -> kembali ke cari  kode/barcode
            // SELAIN ESC -> hitung jumlah kembalian
            if (e.KeyCode == Keys.Escape)
            {
                TxtCari.Focus();
                panelBayar.Visible = false;
            }
            else
            {
                double totalBayar = 0;
                if (txtJumlahBayar.Text == "")
                {
                    lblBayarTotalKembali.Text = "0";
                }
                else
                {
                    if (double.TryParse(txtJumlahBayar.Text.ToString(), out totalBayar))
                    {
                        double hasil = 0;
                        hasil = totalBayar - jumlahBelanja;
                        lblBayarTotalKembali.Text = hasil.ToString("#,###");
                    }
                    else
                    {
                        lblBayarTotalKembali.Text = "INVALID BAYAR";
                    }
                }                
            }
        }

        private void dgvListBarang_KeyUp(object sender, KeyEventArgs e)
        {
            // tombol DELETE pada GRID
            // Konfirmasi apakah data akan di hapus
            //   1. Ubah Detil Penjualan, set BATAL = true
            //   2. update Hdr Penjualan, Total belanja dikurang jumlah pembatalan
            //   3. update tampilan  -> grid dan label total
            if (e.KeyData == Keys.Delete)
            {
                string hasil = dgvListBarang.SelectedCells[1].Value.ToString(); 
                Int32 idDetil= Int32.Parse(dgvListBarang.SelectedCells[6].Value.ToString()); 

                DialogResult hasilDialog;
                hasilDialog = MessageBox.Show("Apakah anda yakin akan menghapus data [ " + hasil + " ]", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if(hasilDialog == DialogResult.OK)
                {
                    using (var context = new PosContext())
                    {
                        double totalBatal = 0;
                        PenjualanDtl penjualanDtlEdit = context.PenjualanDtlContext.Single(p=>p.penjualanDtlID == idDetil);
                        penjualanDtlEdit.batal = true;
                        totalBatal = penjualanDtlEdit.jumlah * penjualanDtlEdit.harga;
                        context.SaveChanges();

                        PenjualanHdr penjualanHdrEdit = context.PenjualanHdrContext.Single(p => p.PenjualanHdrID == penjualanHdr.PenjualanHdrID);
                        penjualanHdrEdit.totalBelanja = penjualanHdrEdit.totalBelanja - totalBatal;
                        context.SaveChanges();

                        jumlahBelanja = jumlahBelanja - totalBatal;

                        LblGrandTotal.Text = " Rp. " + jumlahBelanja.ToString("#,###");
                        previewGrid();
                        TxtCari.Focus();                        
                    }// End Using

                }
            }

            // tombol ESC pada GRID
            // fokus ke kode/barcode
            if (e.KeyData == Keys.Escape)
            {
                TxtCari.Focus();                
            }

        }

        private void dgvListBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // tombol ENTER di GRID           
            //  1. cari di tabel detil Penjualan
            //  2. cari di tabel Barang
            //  3. tampilkan nama barang, jumlah, satuan
            if (e.KeyChar == (char)Keys.Space)
            {
                Int32 idDetilPenjualan = Int32.Parse( dgvListBarang.SelectedCells[6].Value.ToString() );

                PosContext context = new PosContext();

                editQtyMode = true;
                barang = new Barang();
                PenjualanDtl jualDetil = context.PenjualanDtlContext.Single(p=>p.penjualanDtlID == idDetilPenjualan) ;
                TxtJumlah.Text = jualDetil.jumlah.ToString();
                barang = context.BarangContext.Single(b => b.BarangID == jualDetil.BarangID);
                LblNamaBarang.Text = barang.namaBarang.Trim();
                lblSatuan.Text = barang.SatuanKecil.NamaSatuan.Trim();
                lblHarga.Text = barang.hargaJual.ToString("#,###");                
                TxtJumlah.Enabled = true;
                TxtJumlah.SelectAll();
                TxtJumlah.Focus();
            };
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
