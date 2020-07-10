namespace WebApplicationASPWebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abonnes",
                c => new
                    {
                        Numero = c.Int(nullable: false, identity: true),
                        Prenom = c.String(),
                        Mail = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Numero);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abonnes");
        }
    }
}
