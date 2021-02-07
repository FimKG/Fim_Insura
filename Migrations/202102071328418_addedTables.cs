namespace Fim_Insura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminTBs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Fname = c.String(),
                        Lname = c.String(),
                        Email = c.String(),
                        Cellphone = c.String(),
                        Password = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        AmendedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ClientTBs", "CoverValue");
            DropColumn("dbo.ClientTBs", "PolicyPeriod");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClientTBs", "PolicyPeriod", c => c.Int(nullable: false));
            AddColumn("dbo.ClientTBs", "CoverValue", c => c.Int(nullable: false));
            DropTable("dbo.AdminTBs");
        }
    }
}
