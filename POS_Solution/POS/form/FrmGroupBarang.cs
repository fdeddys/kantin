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

namespace POS.form
{
    public partial class FrmGroupBarang : Form
    {
        public FrmGroupBarang()
        {
            InitializeComponent();
            
            btnKondisiAwal(true);
            fieldKondisiAwal();
            setGridView();
            previewList();
        }

        private void FrmGroupBarang_Load(object sender, EventArgs e)
        {
            dgvGroupBarang.Columns[0].HeaderText = "ID";
            dgvGroupBarang.Columns[1].HeaderText = "Nama";
            dgvGroupBarang.Columns[0].Width = 100;
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
            txtNamaGroup.ReadOnly = kondisi;
        }

        private void fieldKondisiAwal()
        {
            txtKodeGroup.Text = "";
            txtNamaGroup.Text = "";            
            txtNamaGroup.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            fieldKondisiAwal();
            btnKondisiAwal(false);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            btnKondisiAwal(false);
            txtNamaGroup.Focus();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnKondisiAwal(true);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah data akan disimpan ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (hasil.Equals(DialogResult.OK ))
            {
                try
                {
                    using(var Context = new PosContext() )
                    {
                        // NEW
                        if (txtKodeGroup.Text.Equals(""))
                        {
                            GroupBarang groupBarang = new GroupBarang();
                            groupBarang.namaGroup = txtNamaGroup.Text.Trim();
                            Context.GroupBarangContext.Add(groupBarang);
                            Context.SaveChanges();
                            txtKodeGroup.Text = groupBarang.idGroup.ToString();
                        }
                        else
                        {
                            // EDIT
                            Int32 id;                            
                            Int32.TryParse( txtKodeGroup.Text, out id);
                            var editGroup = (from g in Context.GroupBarangContext
                                             where g.idGroup == id
                                             select g).FirstOrDefault();
                            editGroup.namaGroup = txtNamaGroup.Text.Trim();
                            Context.SaveChanges();
                        }                                                                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString(), "error");
                    
                }
                btnKondisiAwal(true);
                previewList();
            }
            
        }

        private void previewList()
        {
            
            using (var context = new PosContext())
            {
                var listGroup = (from g in context.GroupBarangContext
                                 select new { g.idGroup, g.namaGroup });
                dgvGroupBarang.DataSource = listGroup.ToList();                
            }
        }

        private void setGridView()
        {

            dgvGroupBarang.AllowDrop = false;
            dgvGroupBarang.AllowUserToAddRows = false;
            dgvGroupBarang.AllowUserToDeleteRows = false;
            dgvGroupBarang.AllowUserToResizeRows = false;
            dgvGroupBarang.RowHeadersVisible = false;
            dgvGroupBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGroupBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroupBarang.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            dgvGroupBarang.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.IndianRed;
            dgvGroupBarang.ForeColor = Color.Navy;
            dgvGroupBarang.BackgroundColor = Color.WhiteSmoke;

        }

        private void dgvGroupBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnUbah.Enabled == true)
            {
                Int32 pilih = e.RowIndex;
                Int32 idCari = Int32.Parse(dgvGroupBarang.Rows[pilih].Cells[0].Value.ToString());
                using (var context = new PosContext())
                {
                    var groupBarang = (from g in context.GroupBarangContext
                                       where g.idGroup == idCari
                                       select g).FirstOrDefault();
                    txtKodeGroup.Text = groupBarang.idGroup.ToString();
                    txtNamaGroup.Text = groupBarang.namaGroup.ToString();
                }
            }
            
        }

        private void dgvGroupBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }
}
