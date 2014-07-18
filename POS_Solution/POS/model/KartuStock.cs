﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_kartu_stock")]
    public class KartuStock
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int idKartuStock { get; set; }

        public virtual Barang idBarang { get; set; }

        public DateTime tanggal { get; set; }

        public decimal masuk { get; set; }

        public decimal keluar { get; set; }

        public decimal stockAkhir { get; set; }

        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

        public virtual Lokasi lokasi { get; set; }

        public string idTransaksi { get; set; }

    }
}