using POS.Context;
using POS.form;
using POS.form.master;
using POS.form.PosKasir;
using POS.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    static class Program
    {

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var db = new PosContext())
            {

                Satuan satuanBaru = new Satuan();
                var satuan = (from s in db.SatuanContext
                              select s).FirstOrDefault();
                if(satuan==(null))
                {                    
                    satuanBaru.NamaSatuan="pc";                                            
                    db.SatuanContext.Add(satuanBaru);
                    db.SaveChanges();
                }


                GroupBarang groupBarangBaru = new GroupBarang();
                var groupBarang = (from g in db.GroupBarangContext
                                   select g).FirstOrDefault();
                if(groupBarang == null)
                {                    
                    groupBarangBaru.namaGroup = "ATK";
                    db.GroupBarangContext.Add(groupBarangBaru);
                    db.SaveChanges();
                }


                var barang = (from b in db.BarangContext
                              select b).FirstOrDefault();
                if(barang == null)
                {
                    Barang barangBaru = new Barang();
                    barangBaru.GroupBarang = groupBarangBaru;
                    barangBaru.hargaJual = 0;
                    barangBaru.namaBarang = "tes1";
                    barangBaru.SatuanKecil = satuanBaru;
                    barangBaru.SatuanBesar = satuanBaru;
                    barangBaru.isStock = true;
                    barangBaru.isi = 1;
                    db.BarangContext.Add(barangBaru);
                    //db.SaveChanges();

                }
            //    var group1 = new GroupBarang();
            //    group1.namaGroup = "tes";

            //    var nasi = new Barang();
            //    nasi.hargaJual = 1000;
            //    nasi.namaBarang = "nasi";
            //    nasi.satuan = "piring";
            //    nasi.stock = true;
            //    nasi.GroupBarang = group1;

            //    db.BarangContext.Add(nasi);
            //    db.SaveChanges();    
            }

            
            //Application.Run(new frmMasterBarang());
            //Application.Run(new FrmGroupBarang());
            //Application.Run(new FrmMasterItem());
            Application.Run(new Login());
            //Application.Run(new MenuUtama());

            
        }
    }
}
