namespace Fim_Insura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class producTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTBs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CoverValue = c.String(),
                        Period = c.String(),
                        ProductName = c.String(),
                        PremiumPrice = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        AmendedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductTBs");
        }
    }
}
