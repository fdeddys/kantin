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

namespace POS.form.master
{
    public partial class FrmMasterItem : Form
    {

        Boolean dataBaru;

        public FrmMasterItem()
        {
            InitializeComponent();
            konfigForm();
            konfigDatagrid();
            btnKondisiAwal(true);
            fieldKondisiAwal();
            previewGrid();
        }

        private void FrmMasterItem_Load(object sender, EventArgs e)
        {
            // Header
            dGVBarang.Columns[0].HeaderText = "Kode";
            dGVBarang.Columns[1].HeaderText = "Nama";
            dGVBarang.Columns[2].HeaderText = "Satuan";
            dGVBarang.Columns[3].HeaderText = "Isi";

            // Width
            dGVBarang.Columns[0].Width = 50;
            dGVBarang.Columns[2].Width = 100;
            dGVBarang.Columns[3].Width = 30;

        }

        private void konfigForm()
        {
            this.BackColor = Color.LightSkyBlue;
            //this.ForeColor = Color.White;
            this.panelIsi.BackColor = Color.LightSkyBlue;
            this.StartPosition = FormStartPosition.CenterScreen;
            isiComboGroup();
        }

        private void konfigDatagrid()
        {
            dGVBarang.AllowDrop = false;
            dGVBarang.AllowUserToAddRows = false;
            dGVBarang.AllowUserToDeleteRows = false;
            dGVBarang.AllowUserToResizeRows = false;
            dGVBarang.RowHeadersVisible = false;
            dGVBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGVBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGVBarang.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            dGVBarang.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.IndianRed;
            dGVBarang.ForeColor = Color.Navy;
            dGVBarang.BackgroundColor = Color.WhiteSmoke;
            //dGVBarang.Font.Name = "Courier New";
        }

        private void isiComboGroup()
        {
            using (var context = new PosContext())
            {
                // isi combo group
                var groupBarangs = (from c in context.GroupBarangContext
                                    select new {c.idGroup , c.namaGroup } ).ToList();                
                cmbGroup.DataSource = groupBarangs;
                cmbGroup.DisplayMember = "namaGroup";
                cmbGroup.ValueMember = "idGroup";

                // isi combo satuan
                var satuans = from s in context.SatuanContext
                              select new { s.IdSatuan, s.NamaSatuan };
                cmbSatuan.DataSource = satuans.ToList();
                cmbSatuan.DisplayMember = "namaSatuan";
                cmbSatuan.ValueMember = "idSatuan";

                cmbSatuanKecil.DataSource = satuans.ToList();
                cmbSatuanKecil.DisplayMember = "namaSatuan";
                cmbSatuanKecil.ValueMember = "idSatuan";

                // isi merk
                var merks = from m in context.MerkContext
                            select new { m.IdMerk, m.namaMerk };
                cmbMerk.DataSource = merks.ToList();
                cmbMerk.DisplayMember = "namaMerk";
                cmbMerk.ValueMember = "IdMerk";

                

            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnKondisiAwal(Boolean kondisi)
        {
            btnTambah.Enabled = kondisi;
            btnUbah.Enabled = kondisi;
            btnSimpan.Enabled = !kondisi;
            btnBatal.Enabled = !kondisi;
            panelIsi.Enabled = !kondisi;
        }

        private void fieldKondisiAwal()
        {
            txtKode.Text = String.Empty;
            txtNama.Text = String.Empty;
            txtHargaJual.Text = String.Empty;
            chkStock.Checked = true;
            txtNama.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnKondisiAwal(true);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtKode.Text == "")
            {
                MessageBox.Show("Double klik pada nama yang akan di edit", "Kode is empty", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                btnKondisiAwal(false);
                txtNama.Focus();
                dataBaru = false;
            }
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            fieldKondisiAwal();            
            btnKondisiAwal(false);
            txtNama.Focus();
            dataBaru = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            using(var context = new PosContext())
            {
                // ambil id combo group [selected]
                Int32 idGroupBarang = Int32.Parse(cmbGroup.SelectedValue.ToString());
                GroupBarang groupbarang = (from g in context.GroupBarangContext
                                          where g.idGroup == idGroupBarang
                                          select g).FirstOrDefault();

                // ambil id satuan [selected]
                Int32 idSatuan = Int32.Parse(cmbSatuan.SelectedValue.ToString());
                Satuan satuan = (from s in context.SatuanContext
                                 where s.IdSatuan == idSatuan
                                 select s).FirstOrDefault();

                // ambil id satuan kecil [selected]
                Int32 idSatuanKecil = Int32.Parse(cmbSatuanKecil.SelectedValue.ToString());
                Satuan satuanKecil = (from s in context.SatuanContext
                                      where s.IdSatuan == idSatuanKecil
                                      select s).FirstOrDefault();

                // ambil id merk
                Int32 idMerk = Int32.Parse(cmbMerk.SelectedValue.ToString());
                Merk merk = (from m in context.MerkContext
                             where m.IdMerk == idMerk
                             select m ).FirstOrDefault() ;

                Barang barang;
                Int32 kodeCari;
                // save barang
                if (dataBaru.Equals(true))
                {
                    barang = new Barang();
                }
                else
                {
                    kodeCari = Int32.Parse( txtKode.Text);
                    barang = (from b in context.BarangContext
                             where b.BarangID == kodeCari
                             select b).FirstOrDefault();
                };
                
                barang.namaBarang = txtNama.Text.Trim();
                barang.GroupBarang = groupbarang;
                barang.hargaJual = Double.Parse( txtHargaJual.Text);
                barang.SatuanKecil = satuan;
                barang.SatuanBesar= satuanKecil;
                barang.Merk = merk;
                barang.isi = Int32.Parse(txtIsi.Text); 
                if(chkStock.CheckState == CheckState.Checked ) 
                {
                    barang.isStock = true  ;
                } else {
                    barang.isStock = false;  
                }
                barang.UserUpdate = Func.VarGlobal.UserNameLogin.Trim();
                barang.lastUpdate = DateTime.Now.ToUniversalTime();
                context.BarangContext.Add(barang);
                context.SaveChanges();

                // create kode barang 1234567 dari identity yang di buat
                // update ke table barang
                txtKode.Text = ("0000000" + barang.BarangID.ToString().Trim()).Right(7);
                barang.kodeBarang = txtKode.Text.Trim();
                context.BarangContext.Find(barang.BarangID);
                context.SaveChanges();


                btnKondisiAwal(true);

                if (dataBaru.Equals(true))
                {
                    Barcode barcode = new Barcode();
                    barcode.Barang = barang;
                    barcode.barcodeIsi = txtKode.Text.Trim();
                    context.BarcodeContext.Add(barcode);
                    context.SaveChanges();
                }

                // Refresh grid
                previewGrid();

            }
                        
        }

        private void previewGrid()
        {
            using(var context = new PosContext() )
            {
                var ListBarang = from b in context.BarangContext
                                 select new { b.BarangID, b.namaBarang, b.SatuanKecil.NamaSatuan , b.isi };
                dGVBarang.DataSource = ListBarang.ToList();
            }
        }

        private void btnDaftarBarcode_Click(object sender, EventArgs e)
        {
            if (txtKode.Text.Equals(string.Empty))
            {
                MessageBox.Show("Kode Barang kosong, pilih dahulu pada grid ! ", "kode empty", MessageBoxButtons.OK, MessageBoxIcon.Question);
            } else
            {
                // Show form barcode, copy id barang ke form barcode
                Func.VarGlobal.IdBarang = txtKode.Text;
                Func.VarGlobal.NamaBarang = txtNama.Text;
                FrmMasterItemBarcode frmMasterBarcode = new FrmMasterItemBarcode();
                frmMasterBarcode.ShowDialog();
            }
            
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
