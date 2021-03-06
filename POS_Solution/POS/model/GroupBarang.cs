﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_Group")]
    public class GroupBarang
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int GroupBarangID { get; set; }
        
        [MaxLength(50)]
        public string namaGroup { get; set; }

        //public int BarangID { get; set; }
        //public virtual List<Barang> Barang { get; set; }

        //public GroupBarang()
        //{
        //    this.Barang = new List<Barang>();
        //}

        public bool hapus { get; set; }
    }
}
