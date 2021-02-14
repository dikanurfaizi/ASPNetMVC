namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmpACC : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tb_M_Employee", "Division_Id", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "Division_Id" });
            RenameColumn(table: "dbo.Tb_M_Employee", name: "Division_Id", newName: "DivisionId");
            AlterColumn("dbo.Tb_M_Employee", "DivisionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tb_M_Employee", "DivisionId");
            AddForeignKey("dbo.Tb_M_Employee", "DivisionId", "dbo.Tb_Division", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_M_Employee", "DivisionId", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "DivisionId" });
            AlterColumn("dbo.Tb_M_Employee", "DivisionId", c => c.Int());
            RenameColumn(table: "dbo.Tb_M_Employee", name: "DivisionId", newName: "Division_Id");
            CreateIndex("dbo.Tb_M_Employee", "Division_Id");
            AddForeignKey("dbo.Tb_M_Employee", "Division_Id", "dbo.Tb_Division", "Id");
        }
    }
}
