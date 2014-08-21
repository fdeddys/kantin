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
    public partial class POS_Restaurant : Form
    {
        string[] isiMenu = new string[20];
        Int32[] idMenu = new Int32[20];

        // untuk variabel Global ID atas yang sedang di pilih
        Int32 idPilihAtas = 0;

        Int32 halamanSekarang, jumlahMaxHalaman;

        // simpan data penjualan
        PenjualanHdr penjualanHdr = null;
        double jumlahBelanja = 0;

                
        public POS_Restaurant()
        {
            InitializeComponent();
            halamanSekarang = 1;
        }

        private void lblMakanan_Click(object sender, EventArgs e)
        {
            idPilihAtas = 1;
            pilihAtas();            
            // isi
            halamanSekarang = 1;
            layoutBawahFilter(1);
        }

        private void pilihAtas()
        {
            menuAtasAwal();

            switch (idPilihAtas)
            {
                case 1:
                    lblMakanan.ForeColor = Color.Lime;
                    lblMakanan.BackColor = Color.DimGray;
                break;
                case 2:
                    lblMinuman.ForeColor = Color.Lime;
                    lblMinuman.BackColor = Color.DimGray;
                break;
                case 3:
                    lblPaket.ForeColor = Color.Lime;   
                    lblPaket.BackColor = Color.DimGray;
                break;
                case 4:
                    lblLainnya.ForeColor = Color.Lime;
                    lblLainnya.BackColor = Color.DimGray;
                break;
            }
        }

        private void menuAtasAwal()
        {
            lblMakanan.ForeColor = Color.FromArgb(224, 224, 224);
            lblMakanan.BackColor = Color.FromArgb(64, 64, 64);
            
            lblMinuman.ForeColor = Color.FromArgb(224, 224, 224);
            lblMinuman.BackColor = Color.FromArgb(64, 64, 64);

            lblPaket.ForeColor = Color.FromArgb(224, 224, 224);
            lblPaket.BackColor = Color.FromArgb(64, 64, 64);

            lblLainnya.ForeColor = Color.FromArgb(224, 224, 224);
            lblLainnya.BackColor = Color.FromArgb(64, 64, 64);

            lblKosong.ForeColor = Color.FromArgb(224, 224, 224);
            lblKosong.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void kondisiAwalLayoutAtas()
        {
            lblMakanan.ForeColor = Color.FromArgb ( 224, 224, 224);
            lblMinuman.ForeColor  = Color.FromArgb(224, 224, 224);
            lblPaket.ForeColor= Color.FromArgb(224, 224, 224);
            lblLainnya.ForeColor= Color.FromArgb(224, 224, 224);
            lblKosong.ForeColor= Color.FromArgb(224, 224, 224);
        }

        private void kondisiAwalLayoutBawah()
        {
            //panelMenu1.Visible = false;
            //panelMenu2.Visible = false;
            //panelMenu3.Visible = false;
            //panelMenu4.Visible = false;

            foreach (var item in   layoutBawah.Controls )
            {
                if(item is Panel)
                {
                    //if (((Panel)item).Width == 164)
                    //{
                    ((Panel)item).Visible = false;
                    //}
                    //MessageBox.Show(((Panel)item).Size.Width.ToString(), ((Panel)item).Name);
                };

                //if(item is PictureBox)
                //{
                //    ((PictureBox)item).BackColor = Color.FromArgb(64, 64, 64);
                //    //MessageBox.Show(((Panel)item).Size.Width.ToString(), ((Panel)item).Name);
                //}
            }
        }

        private void layoutBawahFilter(Int32 pilihanAtas)
        {
            kondisiAwalLayoutBawah();

            Int32 jumlah=0;
            // isi array dengan ID BARANG
            switch (pilihanAtas)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    using (var context = new PosContext())
                    {
                        var ListBarang = context
                            .BarangContext
                            .Select(b => new { b.BarangID, b.namaBarang })
                            .OrderBy(b => b.namaBarang)                            
                            .ToList();

                        double jumlahRec = ListBarang.Count();

                        jumlahMaxHalaman = Int32.Parse((Math.Ceiling(jumlahRec / 16)).ToString());

                        foreach (var item in ListBarang.Skip((halamanSekarang - 1) * 16).Take(16))
                        {
                            jumlah += 1;
                            isiMenu[jumlah] = item.namaBarang.Trim();
                            idMenu[jumlah] = item.BarangID;
                        }                            
                    }                        
                    break;
            }


            for (int i = 1; i <= jumlah; i++)
            {                
                switch (i)
                {
                    case 1: 
                        setIsiMenu(panelMenu1,isiMenu[i],labelNamaMenu1,pictMenu1);
                        break;
                    case 2:
                        setIsiMenu(panelMenu2, isiMenu[i], labelNamaMenu2, pictMenu2);
                        break;
                    case 3:
                        setIsiMenu(panelMenu3, isiMenu[i], labelNamaMenu3, pictMenu3);
                        break;
                    case 4:
                        setIsiMenu(panelMenu4, isiMenu[i], labelNamaMenu4, pictMenu4);
                        break;
                    case 5:
                        setIsiMenu(panelMenu5, isiMenu[i], labelNamaMenu5, pictMenu5);
                        break;
                    case 6:
                        setIsiMenu(panelMenu6, isiMenu[i], labelNamaMenu6, pictMenu6);
                        break;
                    case 7:
                        setIsiMenu(panelMenu7, isiMenu[i], labelNamaMenu7, pictMenu7);
                        break;
                    case 8:
                        setIsiMenu(panelMenu8, isiMenu[i], labelNamaMenu8, pictMenu8);
                        break;
                    case 9:
                        setIsiMenu(panelMenu9, isiMenu[i], labelNamaMenu9, pictMenu9);
                        break;
                    case 10:
                        setIsiMenu(panelMenu10, isiMenu[i], labelNamaMenu10, pictMenu10);
                        break;
                    case 11:
                        setIsiMenu(panelMenu11, isiMenu[i], labelNamaMenu11, pictMenu11);
                        break;
                    case 12:
                        setIsiMenu(panelMenu12, isiMenu[i], labelNamaMenu12, pictMenu12);
                        break;
                    case 13:
                        setIsiMenu(panelMenu13, isiMenu[i], labelNamaMenu13, pictMenu13);
                        break;
                    case 14:
                        setIsiMenu(panelMenu14, isiMenu[i], labelNamaMenu14, pictMenu14);
                        break;
                    case 15:
                        setIsiMenu(panelMenu15, isiMenu[i], labelNamaMenu15, pictMenu15);
                        break;
                    case 16:
                        setIsiMenu(panelMenu16, isiMenu[i], labelNamaMenu16, pictMenu16);
                        break;                    
                }
            };
        }

        private void setIsiMenu(Panel panel, string isiMenu, Label label,PictureBox pictureBox)
        {
            panel.Visible = true;
            label.Text = isiMenu;
            pictureBox.BackColor = Color.FromArgb(64, 64, 64);
            //pictMenu1.Load("");
        }

        private void POS_Restaurant_Load(object sender, EventArgs e)
        {
            kondisiAwalLayoutAtas();
            kondisiAwalLayoutBawah();
            menuAtasAwal();
        }

        private void lblMinuman_Click(object sender, EventArgs e)
        {
            idPilihAtas = 2;
            halamanSekarang = 1;
            pilihAtas();
            layoutBawahFilter(2);
        }

        private void lblPaket_Click(object sender, EventArgs e)
        {
            idPilihAtas = 3;
            halamanSekarang = 1;
            pilihAtas();
            layoutBawahFilter(3);
        }

        private void lblLainnya_Click(object sender, EventArgs e)
        {
            idPilihAtas = 4;
            halamanSekarang = 1;
            pilihAtas();
            layoutBawahFilter(4);
        }

        private void pictMenu1_Click(object sender, EventArgs e)
        {            
            menuClick(1);
        }

        private void menuClick(int no)
        {
            //foreach (var item in layoutBawah.Controls)
            //{
            //    if (item is PictureBox)
            //    {
            //        ((PictureBox)item).BackColor = Color.FromArgb(64, 64, 64);
            //    }
            //}


            pictMenu1.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu2.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu3.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu4.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu5.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu6.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu7.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu8.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu9.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu10.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu11.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu12.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu13.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu14.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu15.BackColor = Color.FromArgb(64, 64, 64);
            pictMenu16.BackColor = Color.FromArgb(64, 64, 64);

            switch (no)
            {
                case 1 :
                    pictMenu1.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 2:
                    pictMenu2.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 3:
                    pictMenu3.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 4:
                    pictMenu4.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 5:
                    pictMenu5.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 6:
                    pictMenu6.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 7:
                    pictMenu7.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 8:
                    pictMenu8.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 9:
                    pictMenu9.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 10:
                    pictMenu10.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 11:
                    pictMenu11.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 12:
                    pictMenu12.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 13:
                    pictMenu13.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 14:
                    pictMenu14.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 15:
                    pictMenu15.BackColor = Color.FromArgb(255, 255, 255);
                    break;
                case 16:
                    pictMenu16.BackColor = Color.FromArgb(255, 255, 255);
                    break;
            }

            using(var context = new PosContext())
            {

                Int32 cari = idMenu[no];
                Barang barang = context.BarangContext
                    .Where(b => b.BarangID == cari)
                    .SingleOrDefault();                          

                if (barang == null)
                {
                    MessageBox.Show("Barang tidak ada !!", "barang is null");
                }
                else
                {
                    if (penjualanHdr == null)
                    {
                        // jika hdr belum ada, CREATE HDR
                        penjualanHdr = new PenjualanHdr();
                        penjualanHdr.batal = false;
                        penjualanHdr.isBayar = false;
                        penjualanHdr.jumlahBayar = 0;
                        penjualanHdr.KasirID = Func.VarGlobal.idKasir;
                        penjualanHdr.lastUpdate = DateTime.Now;
                        penjualanHdr.LokasiID = Func.VarGlobal.idLokasi;
                        penjualanHdr.noFaktur = "";
                        penjualanHdr.tanggalJual = DateTime.Now;
                        context.PenjualanHdrContext.Add(penjualanHdr);
                        context.SaveChanges();
                        jumlahBelanja = 0;
                    }

                    // simpan data detil Penjualan
                    PenjualanDtl penjualanDtl = new PenjualanDtl();
                    penjualanDtl.BarangID = barang.BarangID;
                    penjualanDtl.batal = false;
                    penjualanDtl.harga = barang.hargaJual;
                    penjualanDtl.jumlah = 1;
                    penjualanDtl.PenjualanHdrID = penjualanHdr.PenjualanHdrID;
                    context.PenjualanDtlContext.Add(penjualanDtl);
                    context.SaveChanges();

                    // update total Belanja
                    jumlahBelanja += barang.hargaJual;
                    PenjualanHdr updateHdr = context.PenjualanHdrContext
                        .Single(p => p.PenjualanHdrID == penjualanHdr.PenjualanHdrID);
                    updateHdr.totalBelanja = jumlahBelanja;
                    context.SaveChanges();

                    PreviewGrid();
                }

            };
            
        }

        private void PreviewGrid()
        {
            {
                using (var context = new PosContext())
                {
                    var ListBarang = from b in context.PenjualanDtlContext
                                     where b.batal == false && b.PenjualanHdrID == penjualanHdr.PenjualanHdrID
                                     select new { b.Barang.namaBarang, b.harga, b.jumlah, b.penjualanDtlID };
                    dGV.DataSource = ListBarang.ToList();
                    if (ListBarang.ToList().Count >0)
                    {
                        setHeaderGrid();
                    }
                }
            }
        }

        private void setHeaderGrid()
        {

            //dgvListBarang.ColumnCount = 4;
            // Header
            dGV.Columns[0].HeaderText = "Barang";
            dGV.Columns[1].HeaderText = "Harga";
            dGV.Columns[2].HeaderText = "Jumlah";
            dGV.Columns[3].HeaderText = "Harga";

            dGV.Columns[3].Visible = false;

            // Width
            dGV.Columns[0].Width = 300;
            dGV.Columns[1].Width = 100;
            dGV.Columns[2].Width = 50;            

            dGV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dGV.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            dGV.Columns[1].DefaultCellStyle.Format = "#,###";
            
        }
        private void pictMenu2_Click(object sender, EventArgs e)
        {
            menuClick(2);
        }

        private void pictMenu3_Click(object sender, EventArgs e)
        {
            menuClick(3);
        }

        private void pictMenu4_Click(object sender, EventArgs e)
        {
            menuClick(4);
        }

        private void pictMenu5_Click(object sender, EventArgs e)
        {
            menuClick(5);
        }

        private void pictMenu6_Click(object sender, EventArgs e)
        {
            menuClick(6);
        }

        private void pictMenu7_Click(object sender, EventArgs e)
        {
            menuClick(7);
        }

        private void pictMenu8_Click(object sender, EventArgs e)
        {
            menuClick(8);
        }

        private void pictMenu9_Click(object sender, EventArgs e)
        {
            menuClick(9);
        }

        private void pictMenu11_Click(object sender, EventArgs e)
        {
            menuClick(11);
        }

        private void pictMenu10_Click(object sender, EventArgs e)
        {
            menuClick(10);
        }

        private void pictMenu12_Click(object sender, EventArgs e)
        {
            menuClick(12);
        }

        private void pictMenu13_Click(object sender, EventArgs e)
        {
            menuClick(13);
        }

        private void pictMenu14_Click(object sender, EventArgs e)
        {
            menuClick(14);
        }

        private void pictMenu15_Click(object sender, EventArgs e)
        {
            menuClick(15);
        }

        private void pictMenu16_Click(object sender, EventArgs e)
        {
            menuClick(16);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            halamanSekarang += 1;
            if (halamanSekarang > jumlahMaxHalaman)
            {
                halamanSekarang -= 1;
            }
            else
            {
                layoutBawahFilter(idPilihAtas);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            halamanSekarang -= 1;
            if (halamanSekarang < 1)
            {
                halamanSekarang += 1;
            }
            else
            {
                layoutBawahFilter(idPilihAtas);
            }
        }

    }


   
}
