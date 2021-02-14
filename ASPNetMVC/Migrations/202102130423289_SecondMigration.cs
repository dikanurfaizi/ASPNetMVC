namespace ASPNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tb_Account",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_M_Employee", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Tb_M_Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDay = c.DateTime(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Division_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tb_Division", t => t.Division_Id)
                .Index(t => t.Division_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tb_Account", "Id", "dbo.Tb_M_Employee");
            DropForeignKey("dbo.Tb_M_Employee", "Division_Id", "dbo.Tb_Division");
            DropIndex("dbo.Tb_M_Employee", new[] { "Division_Id" });
            DropIndex("dbo.Tb_Account", new[] { "Id" });
            DropTable("dbo.Tb_M_Employee");
            DropTable("dbo.Tb_Account");
        }
    }
}
