namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_GIAOVIEN : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GIAOVIENS",
                c => new
                    {
                        MaGV = c.String(nullable: false, maxLength: 128),
                        HoTenGV = c.String(),
                        NamSinh = c.Int(nullable: false),
                        MaMon = c.String(),
                        SoDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaGV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GIAOVIENS");
        }
    }
}
