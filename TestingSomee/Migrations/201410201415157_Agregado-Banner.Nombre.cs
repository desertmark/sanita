namespace Sanita.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregadoBannerNombre : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banners", "Nombre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Banners", "Nombre");
        }
    }
}
