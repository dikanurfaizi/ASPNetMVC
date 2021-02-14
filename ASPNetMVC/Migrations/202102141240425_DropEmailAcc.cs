namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropEmailAcc : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tb_M_Account", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tb_M_Account", "Email", c => c.String());
        }
    }
}
