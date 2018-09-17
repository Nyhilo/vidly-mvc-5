namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('The Hangover', 5, 'June 2, 2017', 'June 2, 2009', 0)");
            Sql("INSERT INTO dbo.Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Die Hard', 1, 'July 15, 2017', 'July 15, 1988', 2)");
            Sql("INSERT INTO dbo.Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('The Terminator', 1, 'October 26, 2017', 'October 26, 1984', 5)");
            Sql("INSERT INTO dbo.Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Toy Story', 3, 'November 22, 2017', 'November 22, 1995', 4)");
            Sql("INSERT INTO dbo.Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES('Titanic', 4, 'December 19, 2017', 'December 19, 1997', 3)");

        }

        public override void Down()
        {
        }
    }
}
