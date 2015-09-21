namespace Sanita.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campoBannerDescripcion : DbMigration
    {
        public override void Up()
        {
           
            
            CreateTable(
                "dbo.Banners",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Img = c.String(),
                        Descrpcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Banners");
        }
    }
}
