namespace Fim_Insura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClaimTB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClaimTBs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductName = c.String(),
                        PremiumPrice = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        AmendedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClaimTBs");
        }
    }
}
