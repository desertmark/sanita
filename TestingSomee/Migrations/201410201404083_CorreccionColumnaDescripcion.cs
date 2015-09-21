namespace Sanita.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorreccionColumnaDescripcion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Banners", "Descripcion", c => c.String());
            DropColumn("dbo.Banners", "Descrpcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Banners", "Descrpcion", c => c.String());
            DropColumn("dbo.Banners", "Descripcion");
        }
    }
}
