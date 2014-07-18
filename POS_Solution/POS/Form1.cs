using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmMasterBarang : Form
    {

        SqlConnection Sc;
        SqlDataAdapter Sda ;
        DataSet Ds;
        private void koneksiServer()
        {
            Sc = new SqlConnection("Data source=.; Initial Catalog = DbToko ; Integrated Security = true; user id=sa; password =12345678");
            Sc.Open();
            Sda = new SqlDataAdapter();
            Ds = new DataSet();
            //MessageBox.Show(Sc.State.ToString());
        }

        public frmMasterBarang()
        {
            InitializeComponent();
            btnKondisiAwal(true);
            fieldKondisiAwal();
            koneksiServer();
            preview();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtHargaJual.Text = "";
            chkStock.Checked = false;
            txtNama.Focus() ;
            btnKondisiAwal( false );
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose( );
        }

        private void btnKondisiAwal(Boolean kondisi )
        {                        
            btnTambah.Enabled = kondisi;
            btnUbah.Enabled = kondisi;
            btnSimpan.Enabled = !kondisi;
            btnBatal.Enabled = !kondisi;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnKondisiAwal(true);
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            btnKondisiAwal(false);
            txtNama.Focus();
        }

        private void fieldKondisiAwal()
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtHargaJual.Text = "";
            chkStock.Checked=false;
            txtNama.Focus() ;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            Sda.InsertCommand = new SqlCommand("insert into tb_barang values(@nama,@jumlah,@satuan) ", Sc);
            Sda.InsertCommand.Parameters.Add("@nama", SqlDbType.VarChar).Value = "test 1";
            Sda.InsertCommand.Parameters.Add("@jumlah", SqlDbType.Float).Value = 0;
            Sda.InsertCommand.Parameters.Add("@satuan", SqlDbType.VarChar).Value = "pc";
            Sda.InsertCommand.ExecuteNonQuery();
            preview();
        }

        private void preview()
        {
            Sda.SelectCommand = new SqlCommand("select * from tb_barang",Sc);
            Ds.Clear();
            Sda.Fill(Ds);
            dGV.DataSource = Ds.Tables[0];
        }

        private void dGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }

        private void chkStock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHargaJual_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelIsi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
