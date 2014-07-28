using POS.Context;
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
    public partial class FormHelpBarang : Form
    {
        int jumlahItem = 5;
        int halamanSekarang = 1;
        int jumlahMaxHalaman = 0;
        public string hasil;

        public FormHelpBarang()
        {
            InitializeComponent();
        }

        private void FormHelpBarang_Load(object sender, EventArgs e)
        {
            PreviewGrid();
        }

        private void PreviewGrid()
        {

            //dGVBarang.AllowDrop = false;
            //dGVBarang.AllowUserToAddRows = false;
            //dGVBarang.AllowUserToDeleteRows = false;
            //dGVBarang.AllowUserToResizeRows = false;
            //dGVBarang.RowHeadersVisible = false;
            //dGVBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dGVBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dGVBarang.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            //dGVBarang.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.IndianRed;
            //dGVBarang.ForeColor = Color.Navy;
            //dGVBarang.BackgroundColor = Color.WhiteSmoke;

            showPage();           

             //Header
            dGVBarang.Columns[0].HeaderText = "Kode";
            dGVBarang.Columns[1].HeaderText = "Nama";
            dGVBarang.Columns[2].HeaderText = "Satuan";
            dGVBarang.Columns[3].HeaderText = "Isi";

             //Width
            dGVBarang.Columns[0].Width = 50;
            dGVBarang.Columns[2].Width = 100;
            dGVBarang.Columns[3].Width = 30;
        }

        private void showPage()
        {
            dGVBarang.DataSource = null;
            using (var context = new PosContext())
            {
                string cari = txtCariBarang.Text.Trim();
                var ListBarang = (from b in context.BarangContext
                                  where b.namaBarang.Contains("b")
                                  select new { b.BarangID, b.namaBarang, b.SatuanKecil.NamaSatuan, b.isi })
                                  //.Where(b=>b.namaBarang.Contains("buku"))
                                  .OrderBy(b => b.namaBarang);
                                  //.Skip(halamanSekarang * jumlahItem)
                                  //.Take(jumlahItem);

                //var  ListBarang = context.BarangContext
                //                .Where(b=>b.namaBarang.Contains(cari))
                //                .OrderBy(b => b.namaBarang)
                //                .Skip(halamanSekarang * jumlahItem)
                //                .Take(jumlahItem);


                jumlahMaxHalaman = ListBarang.Count();                

                dGVBarang.DataSource = ListBarang.ToList();
                
            }
        }

        private void txtCariBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            };
            if (e.KeyCode == Keys.Down)
            {
                dGVBarang.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                firstPage();
            }
            if (e.KeyCode == Keys.F2)
            {
                prevPage();
            }
            if (e.KeyCode == Keys.F3)
            {
                nextPage();
            }
            if (e.KeyCode == Keys.F4)
            {
                lastPage();
            }

        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            nextPage();
        }
        

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prevPage();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            firstPage();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            lastPage();
        }

        private void dGVBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtCariBarang.Focus();
            }
        }

        private void dGVBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                this.hasil = dGVBarang.SelectedCells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void nextPage()
        {
            halamanSekarang += 1;
            if (halamanSekarang > jumlahMaxHalaman)
            {
                halamanSekarang -= 1;
            }
            else
            {
                showPage();
            }
        }

        private void prevPage()
        {
            halamanSekarang -= 1;
            if (halamanSekarang < 1)
            {
                halamanSekarang += 1;
            }
            else
            {
                showPage();
            }
        }

        private void firstPage()
        {
            halamanSekarang = 1;
            showPage();
        }

        private void lastPage()
        {
            halamanSekarang = jumlahMaxHalaman;
            showPage();
        }

        private void txtCariBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (dGVBarang.RowCount > 0)
                {
                    this.hasil = dGVBarang.Rows[0].ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            showPage();            
        }


    }
}
