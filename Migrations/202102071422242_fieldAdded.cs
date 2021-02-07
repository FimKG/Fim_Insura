namespace Fim_Insura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClientTBs", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClientTBs", "Password");
        }
    }
}
