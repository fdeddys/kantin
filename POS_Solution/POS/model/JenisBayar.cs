﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_jnsBayar")]
    public class JenisBayar
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int JenisBayarID { get; set; }

        [MaxLength(50)]
        public string namaJenisBayar { get; set; }

        [MaxLength(20)]
        public string userUpdate { get; set; }

        public DateTime lastUpdate { get; set; }

        public bool hapus { get; set; }

    }
}
