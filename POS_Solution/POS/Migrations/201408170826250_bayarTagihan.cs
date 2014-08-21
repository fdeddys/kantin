namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bayarTagihan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_bayar_tagihan",
                c => new
                    {
                        BayarTagihanID = c.Int(nullable: false, identity: true),
                        grandTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BayarTagihanID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_bayar_tagihan");
        }
    }
}
