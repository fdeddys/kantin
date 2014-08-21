using POS.Context;
using POS.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Func
{
    public class CetakStruk
    {
        public static void cetak(Int32 idPenjualan)
        {
            
            //Cetak Header
            string s = " " + Convert.ToString((char)10);
            s += Convert.ToString((char)27) + "a" + Convert.ToString((char)1); // rata tengah
            s += Convert.ToString((char)27) + "!" + Convert.ToString((char)16); // double High            
            s += Func.VarGlobal.Header1 + Convert.ToString((char)10);
            s += Func.VarGlobal.Header2 + Convert.ToString((char)10);
            s += Func.VarGlobal.Header3 + Convert.ToString((char)10);
            s += Convert.ToString((char)27) + "!" + Convert.ToString((char)0); // normal High
            s += Convert.ToString((char)27) + "a" + Convert.ToString((char)0);  // rata kiri
            s += "------------------------------------------------" + Convert.ToString((char)10);            
            using (var context = new PosContext())
            {
                PenjualanHdr penjualanHdr = context.PenjualanHdrContext
                    .Where(h => h.PenjualanHdrID == idPenjualan)
                    .Select(h => h)
                    .SingleOrDefault();
                double kembali = penjualanHdr.jumlahBayar - penjualanHdr.totalBelanja;

                s += "No Transaksi  : " + penjualanHdr.noFaktur.Trim() + Convert.ToString((char)10);
                s += "Tanggal       : " + penjualanHdr.tanggalJual.ToString("dd-MMM-yyyy hh:mm:ss") + Convert.ToString((char)10);
                s += "Kasir / POS   : " + penjualanHdr.Kasir.NamaKasir.Trim() + " / " + penjualanHdr.Lokasi.NamaLokasi + Convert.ToString((char)10);
                s += "------------------------------------------------" + Convert.ToString((char)10);
                s += "Nama                            Qty       Total" + Convert.ToString((char)10);
                s += "------------------------------------------------" + Convert.ToString((char)10);
                //    123456789 123456789 123456789 12  999  9,999,999
                //s += "123456789012345678901234567890123456789012345678" + Convert.ToString((char)10);
                

                List<PenjualanDtl> penjualanDetilList = context.PenjualanDtlContext
                                .Where(d => d.PenjualanHdrID == idPenjualan)
                                .Where(d=> d.batal == false)
                                .ToList();
                foreach (var penjualanDetil in penjualanDetilList)
                {
                    String cetak = String.Format("{0,-29}   {1,3}   {2,9}", penjualanDetil.Barang.namaBarang, penjualanDetil.jumlah.ToString(), (penjualanDetil.harga * penjualanDetil.jumlah).ToString("#,###")) ;
                    s += (cetak + Convert.ToString((char)10)) ;
                }                                
                s += "------------------------------------------------" + Convert.ToString((char)10);
                s += "                         Total   :   " + String.Format("{0, 10} ", penjualanHdr.totalBelanja.ToString("#,###")) + Convert.ToString((char)10);
                s += "                         Bayar   :   " + String.Format("{0, 10} ", penjualanHdr.jumlahBayar.ToString("#,###")) + Convert.ToString((char)10);
                s += "                         Kembali :   " + String.Format("{0, 10} ", kembali.ToString("#,###")) + Convert.ToString((char)10);
                s += "------------------------------------------------" + Convert.ToString((char)10);
            }

            // Cetak Footer
            s += Convert.ToString((char)27) + "a" + Convert.ToString((char)1); // rata tengah
            s += Convert.ToString((char)27) + "!" + Convert.ToString((char)8); // double High                                                       
            s += Func.VarGlobal.Footer1 + Convert.ToString((char)10);
            s += Func.VarGlobal.Footer2 + Convert.ToString((char)10);
            s += Func.VarGlobal.Footer3 + Convert.ToString((char)10); 
            s += Convert.ToString((char)27) + "!" + Convert.ToString((char)0); // normal High
            s += Convert.ToString((char)27) + "a" + Convert.ToString((char)0);  // rata kiri            
            s += " " + Convert.ToString((char)10);                        
            s += Convert.ToString((char)29) + Convert.ToString((char)86) + Convert.ToString((char)66) + Convert.ToString((char)0);

            // Cetakkkkkkkkkkkkkkkk
            //RawPrinterHelper.SendStringToPrinter("EPSON TM-T81 Receipt", s);  
            RawPrinterHelper.SendStringToPrinter(Func.VarGlobal.NamaPrinter, s);  

            //s += "(0XH1D)" + "V" + Convert.ToString((char)66) + Convert.ToString((char)0);

        }

        public static void cetakLaporanHarian(Int32 idKasir)
        {

            double approve = 0, nonApprove = 0;
            Int32 jmlApprove = 0, jmlNonApprove = 0;
            double total = 0;
                        
            //Cetak Header
            string s = " " + Convert.ToString((char)10);
            s += Convert.ToString((char)27) + "a" + Convert.ToString((char)1); // rata tengah
            s += Convert.ToString((char)27) + "!" + Convert.ToString((char)16); // double High            
            s += " " + Convert.ToString((char)10);
            s += "Laporan Pendapatan" + Convert.ToString((char)10);            
            s += Convert.ToString((char)27) + "!" + Convert.ToString((char)0); // normal High
            s += Convert.ToString((char)27) + "a" + Convert.ToString((char)0);  // rata kiri
            
            
            //Isi
            s += "------------------------------------------------" + Convert.ToString((char)10);
            s += "User         :  " + Func.VarGlobal.UserNameLogin + Convert.ToString((char)10);
            s += "Tanggal      :  " + DateTime.Now.ToString("dd-MMM-yyyy") + Convert.ToString((char)10);
            s += "------------------------------------------------" + Convert.ToString((char)10);
            using (var Context = new PosContext())
            {
                // Modal
                string tglTransaksi=DateTime.Now.ToString("yyyy-MM-dd");
                KasirLogin kasirLogin = Context.KasirLoginContext
                    .Where(k => k.KasirID == idKasir)
                    .Where(k => k.TglTransaksi == tglTransaksi)
                    .FirstOrDefault();
                if (kasirLogin == null)
                {
                    s += "Open         :  -" + Convert.ToString((char)10);
                    s += "Modal        :  0" + Convert.ToString((char)10);
                }
                else
                {
                    s += "Open         :  " + kasirLogin.WaktuOpenShift + Convert.ToString((char)10);
                    s += "Modal        :  " + String.Format("{0, 30} ", kasirLogin.SaldoAwal.ToString("#,###")) + Convert.ToString((char)10);
                    total += kasirLogin.SaldoAwal;
                };

                // Jumlah Bayar                
                Int32 tgl= Int32.Parse( DateTime.Now.ToString("dd"));
                Int32 bln = Int32.Parse(DateTime.Now.ToString("MM"));
                Int32 tahun =  Int32.Parse( DateTime.Now.ToString("yyyy"));
                DateTime tglAwal = new DateTime(tahun,bln,tgl,0,0,0);
                DateTime tglAkhir = new DateTime(tahun, bln, tgl, 23, 59, 59);

                var penjualanList = Context.PenjualanHdrContext
                    .Where(p => p.tanggalJual >= tglAwal && p.tanggalJual <= tglAkhir );

                foreach (var penjualanHdr in penjualanList)
                {
                    if (penjualanHdr.isBayar.Equals(true))
                    {
                        approve += penjualanHdr.totalBelanja;
                        jmlApprove += 1;                        
                    }
                    else
                    {
                        nonApprove += penjualanHdr.totalBelanja;
                        jmlNonApprove += 1;
                    };
                };
                total += approve;
                s += "Transaksi    :  " + String.Format("{0, 30} ", approve.ToString("#,###")) + Convert.ToString((char)10);
                s += "Jumlah Trns  :  " + String.Format("{0, 30} ", jmlApprove.ToString("#,###")) + Convert.ToString((char)10);
                s += "------------------------------------------------" + Convert.ToString((char)10);
                s += "Total        :  " + String.Format("{0, 30} ", total.ToString("#,###")) + Convert.ToString((char)10);

                // jika ada BELUM BAYAR -> tampilkan
                if (jmlNonApprove > 0)
                {
                    s += "------------------------------------------------" + Convert.ToString((char)10);
                    s += "Tidak Bayar  :  " + String.Format("{0, 30} ", nonApprove.ToString("#,###")) + Convert.ToString((char)10);
                    s += "Jumlah Trns  :  " + String.Format("{0, 30} ", jmlNonApprove.ToString("#,###")) + Convert.ToString((char)10);
                }                    
            };
            s += "------------------------------------------------" + Convert.ToString((char)10);
            s += " " + Convert.ToString((char)10);
            s += Convert.ToString((char)29) + Convert.ToString((char)86) + Convert.ToString((char)66) + Convert.ToString((char)0);
            RawPrinterHelper.SendStringToPrinter(Func.VarGlobal.NamaPrinter, s);  
        }

    }
}
