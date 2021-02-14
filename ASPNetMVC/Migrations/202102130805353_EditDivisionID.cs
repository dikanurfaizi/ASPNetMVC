namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditDivisionID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tb_M_Employee", "DivisionId", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "DivisionId" });
            RenameColumn(table: "dbo.Tb_M_Employee", name: "DivisionId", newName: "Division_Id1");
            AddColumn("dbo.Tb_M_Employee", "Division_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Tb_M_Employee", "Division_Id1", c => c.Int());
            CreateIndex("dbo.Tb_M_Employee", "Division_Id1");
            AddForeignKey("dbo.Tb_M_Employee", "Division_Id1", "dbo.Tb_Division", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_M_Employee", "Division_Id1", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "Division_Id1" });
            AlterColumn("dbo.Tb_M_Employee", "Division_Id1", c => c.Int(nullable: false));
            DropColumn("dbo.Tb_M_Employee", "Division_Id");
            RenameColumn(table: "dbo.Tb_M_Employee", name: "Division_Id1", newName: "DivisionId");
            CreateIndex("dbo.Tb_M_Employee", "DivisionId");
            AddForeignKey("dbo.Tb_M_Employee", "DivisionId", "dbo.Tb_Division", "Id", cascadeDelete: true);
        }
    }
}
