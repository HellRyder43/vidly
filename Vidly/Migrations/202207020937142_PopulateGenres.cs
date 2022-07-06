namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (Id, Name) Values (1, 'Comedy')");
            Sql("Insert Into Genres (Id, Name) Values (2, 'Action')");
            Sql("Insert Into Genres (Id, Name) Values (3, 'Family')");
            Sql("Insert Into Genres (Id, Name) Values (4, 'Romance')");
            Sql("Insert Into Genres (Id, Name) Values (5, 'Sci-Fi')");
            Sql("Insert Into Genres (Id, Name) Values (6, 'Fantasy')");
            Sql("Insert Into Genres (Id, Name) Values (7, 'Anime')");
        }
        
        public override void Down()
        {
        }
    }
}
