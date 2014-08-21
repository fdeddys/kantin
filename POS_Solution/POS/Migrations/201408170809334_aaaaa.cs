namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaaa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_bayar_hd",
                c => new
                    {
                        BayarHdrID = c.Int(nullable: false, identity: true),
                        userUpdate = c.String(maxLength: 20),
                        lastUpdate = c.DateTime(nullable: false),
                        approved = c.Boolean(nullable: false),
                        hapus = c.Boolean(nullable: false),
                        tanggal = c.DateTime(nullable: false),
                        total_tagihan = c.Double(nullable: false),
                        total_bayar = c.Double(nullable: false),
                        pembulatan = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BayarHdrID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_bayar_hd");
        }
    }
}
