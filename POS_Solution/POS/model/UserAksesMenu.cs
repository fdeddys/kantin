using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.model
{
    [Table("tb_UserAksesMenu")]
    public class UserAksesMenu
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Column("idUserAksesMenu")]
        public int UserAksesMenuId { get; set; }

        [MaxLength(4)]
        [Column("vc_nik")]
        public string nik { get; set; }

        [Column("vc_kd_menu")]
        [MaxLength(10)]
        public string kodeMenu { get; set; }

        [Column("bt_visible")]
        public bool isVisible { get; set; }

        [Column("bt_enable")]
        public bool isEnable { get; set; }

        [Column("bt_add")]
        public bool isAdd { get; set; }

        [Column("bt_edit")]
        public bool isEdit { get; set; }

        [Column("bt_delete")]
        public bool isDelete { get; set; }

        [Column("bt_approve")]
        public bool isApprove { get; set; }

    }
}
