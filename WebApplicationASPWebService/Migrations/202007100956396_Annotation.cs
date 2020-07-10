namespace WebApplicationASPWebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Annotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abonnes", "Prenom", c => c.String(nullable: false));
            AlterColumn("dbo.Abonnes", "Telephone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abonnes", "Telephone", c => c.String());
            AlterColumn("dbo.Abonnes", "Prenom", c => c.String());
        }
    }
}
