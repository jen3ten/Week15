namespace Week15_GameScoresMig2_04192016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "Team", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "Team");
        }
    }
}
