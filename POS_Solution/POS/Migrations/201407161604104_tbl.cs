namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbl : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tbl_mutasi_hd", newName: "tb_mutasi_hd");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tb_mutasi_hd", newName: "tbl_mutasi_hd");
        }
    }
}
