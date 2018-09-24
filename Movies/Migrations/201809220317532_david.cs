namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class david : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Peliculas", "Poster", c => c.Binary());
            AlterColumn("dbo.Peliculas", "Sinopsis", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Peliculas", "Sinopsis", c => c.String(nullable: false));
            AlterColumn("dbo.Peliculas", "Poster", c => c.Binary(nullable: false));
        }
    }
}
