namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bayarDtl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_bayar_dtl",
                c => new
                    {
                        BayarDtlID = c.Int(nullable: false, identity: true),
                        noRek = c.String(maxLength: 50),
                        subTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BayarDtlID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_bayar_dtl");
        }
    }
}
