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

namespace POS.form.master
{
    public partial class FrmMasterItemBarcode : Form
    {
        public FrmMasterItemBarcode()
        {
            InitializeComponent();
        }

        private void FrmMasterItemBarcode_Load(object sender, EventArgs e)
        {
            txtKode.Text = Func.VarGlobal.IdBarang;
            txtNama.Text = Func.VarGlobal.NamaBarang;

            Int32 idBarang = Int32.Parse(txtKode.Text);

            using (var context = new PosContext())
            {
                var barcode = (from b in context.BarcodeContext
                               where b.Barang.BarangID == idBarang
                               select new {b.BarcodeId, b.barcodeIsi } );

                lstBarcode.DataSource = barcode.ToList();
                lstBarcode.DisplayMember = "barcodeIsi";
                lstBarcode.ValueMember = "BarcodeId";
            }
            txtBarcode.Focus();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
