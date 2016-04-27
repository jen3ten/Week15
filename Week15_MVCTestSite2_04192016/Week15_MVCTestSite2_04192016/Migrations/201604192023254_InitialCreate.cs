namespace Week15_MVCTestSite2_04192016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bottoms",
                c => new
                    {
                        BottomID = c.String(nullable: false, maxLength: 128),
                        Item = c.String(),
                        Nickname = c.String(),
                        Season = c.String(),
                    })
                .PrimaryKey(t => t.BottomID);
            
            CreateTable(
                "dbo.Tops",
                c => new
                    {
                        TopID = c.String(nullable: false, maxLength: 128),
                        Item = c.String(),
                        Nickname = c.String(),
                        Season = c.String(),
                    })
                .PrimaryKey(t => t.TopID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tops");
            DropTable("dbo.Bottoms");
        }
    }
}
