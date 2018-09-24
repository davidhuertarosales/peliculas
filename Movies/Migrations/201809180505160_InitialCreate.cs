namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        ComentarioID = c.Int(nullable: false, identity: true),
                        PeliID = c.Int(nullable: false),
                        UserName = c.String(),
                        Critica = c.String(nullable: false, maxLength: 250),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.ComentarioID)
                .ForeignKey("dbo.Peliculas", t => t.PeliID, cascadeDelete: true)
                .Index(t => t.PeliID);
            
            CreateTable(
                "dbo.Peliculas",
                c => new
                    {
                        PeliID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Poster = c.Binary(nullable: false),
                        ImageMimeType = c.String(),
                        Sinopsis = c.String(nullable: false),
                        Fecha_estreno = c.DateTime(nullable: false),
                        Director = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PeliID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "PeliID", "dbo.Peliculas");
            DropIndex("dbo.Comentarios", new[] { "PeliID" });
            DropTable("dbo.Peliculas");
            DropTable("dbo.Comentarios");
        }
    }
}
