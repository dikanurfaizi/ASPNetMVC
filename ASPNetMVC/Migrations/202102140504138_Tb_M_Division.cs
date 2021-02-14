namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tb_M_Division : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Tb_Division", newName: "Tb_M_Division");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Tb_M_Division", newName: "Tb_Division");
        }
    }
}
