namespace TranslatorWeb.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulatePlatformTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Platforms(Name,IsActive,ImageUrl) VALUES('Windows','True','~/Images/win.jpg')");
            Sql("INSERT INTO Platforms(Name,IsActive,ImageUrl) VALUES('IOS','True','~/Images/ios.jpg')");
            Sql("INSERT INTO Platforms(Name,IsActive,ImageUrl) VALUES('Android','True','~/Images/android.jpg')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Platforms WHERE Id IN(1,2,3)");
        }
    }
}
