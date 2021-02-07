namespace Fim_Insura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientTBs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CoverValue = c.Int(nullable: false),
                        Fname = c.String(),
                        LName = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        DOB = c.String(),
                        Cellphone = c.String(),
                        PolicyPeriod = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        AmendedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClientTBs");
        }
    }
}
