namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jenisBayar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_jnsBayar",
                c => new
                    {
                        JenisBayarID = c.Int(nullable: false, identity: true),
                        namaJenisBayar = c.String(maxLength: 50),
                        userUpdate = c.String(maxLength: 20),
                        lastUpdate = c.DateTime(nullable: false),
                        hapus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.JenisBayarID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_jnsBayar");
        }
    }
}
