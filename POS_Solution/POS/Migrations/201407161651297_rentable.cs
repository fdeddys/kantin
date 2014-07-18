namespace POS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rentable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tb_adjusment_dtl", newName: "tb_adjustment_dtl");
            RenameTable(name: "dbo.tb_adjusement_hd", newName: "tb_adjustment_hd");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.tb_adjustment_hd", newName: "tb_adjusement_hd");
            RenameTable(name: "dbo.tb_adjustment_dtl", newName: "tb_adjusment_dtl");
        }
    }
}
