namespace Week15_MVCTestSite2_04192016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIDToInt : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bottoms");
            DropPrimaryKey("dbo.Tops");
            AlterColumn("dbo.Bottoms", "BottomID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Tops", "TopID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bottoms", "BottomID");
            AddPrimaryKey("dbo.Tops", "TopID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Tops");
            DropPrimaryKey("dbo.Bottoms");
            AlterColumn("dbo.Tops", "TopID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Bottoms", "BottomID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Tops", "TopID");
            AddPrimaryKey("dbo.Bottoms", "BottomID");
        }
    }
}
