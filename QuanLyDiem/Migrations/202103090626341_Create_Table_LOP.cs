namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_LOP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LOPS",
                c => new
                    {
                        Lop = c.String(nullable: false, maxLength: 128),
                        Khoi = c.Int(nullable: false),
                        MaGV = c.String(),
                        SiSo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Lop);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LOPS");
        }
    }
}
