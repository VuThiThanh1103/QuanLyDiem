namespace QuanLyDiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_MONHOC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MONHOCS",
                c => new
                    {
                        MaMon = c.String(nullable: false, maxLength: 128),
                        TenMonHoc = c.String(),
                        SiSo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaMon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MONHOCS");
        }
    }
}
