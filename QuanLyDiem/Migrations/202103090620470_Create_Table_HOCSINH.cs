namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HOCSINH : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HOSSINHS",
                c => new
                    {
                        MaHS = c.Int(nullable: false, identity: true),
                        TenHS = c.String(),
                        NamSinh = c.Int(nullable: false),
                        Lop = c.String(),
                    })
                .PrimaryKey(t => t.MaHS);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HOSSINHS");
        }
    }
}
