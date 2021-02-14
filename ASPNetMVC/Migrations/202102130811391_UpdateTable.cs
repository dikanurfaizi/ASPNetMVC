namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tb_M_Employee", "Division_Id1", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "Division_Id1" });
            RenameColumn(table: "dbo.Tb_M_Employee", name: "Division_Id1", newName: "DivisionID");
            AlterColumn("dbo.Tb_M_Employee", "DivisionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Tb_M_Employee", "DivisionID");
            AddForeignKey("dbo.Tb_M_Employee", "DivisionID", "dbo.Tb_Division", "Id", cascadeDelete: true);
            DropColumn("dbo.Tb_M_Employee", "Division_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tb_M_Employee", "Division_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tb_M_Employee", "DivisionID", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "DivisionID" });
            AlterColumn("dbo.Tb_M_Employee", "DivisionID", c => c.Int());
            RenameColumn(table: "dbo.Tb_M_Employee", name: "DivisionID", newName: "Division_Id1");
            CreateIndex("dbo.Tb_M_Employee", "Division_Id1");
            AddForeignKey("dbo.Tb_M_Employee", "Division_Id1", "dbo.Tb_Division", "Id");
        }
    }
}
