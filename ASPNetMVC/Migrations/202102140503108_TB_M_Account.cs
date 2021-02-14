namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TB_M_Account : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tb_Account", newName: "Tb_M_Account");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tb_M_Account", newName: "Tb_Account");
        }
    }
}
