using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Func
{
    public class VarGlobal
    {
                
        public static string IdBarang = string.Empty;
        public static string NamaBarang = string.Empty;

        // kasir dan lokasi saat login di simpan sebagai GLOBAL VAR
        public static Int32 idKasir=0;
        public static string UserNameLogin = string.Empty;
        public static Int32 idLokasi=0;
        public static string namaLokasi = string.Empty;

        //untuk struck
        public static string Header1 = string.Empty;
        public static string Header2 = string.Empty;
        public static string Header3 = string.Empty;

        public static string Footer1 = string.Empty;
        public static string Footer2 = string.Empty;
        public static string Footer3 = string.Empty;

        //config di File setting.ini
        public static string NamaPrinter = string.Empty;
        public static byte isPosSwalayan = 0;
        public static byte isPosRestaurant = 0;

    }
}
