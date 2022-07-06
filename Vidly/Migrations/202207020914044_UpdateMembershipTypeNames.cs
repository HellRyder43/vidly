namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name='Pay as You Go' Where Id = 1");
            Sql("Update MembershipTypes Set Name='Monthly' Where Id != 1");
        }
        
        public override void Down()
        {
        }
    }
}
