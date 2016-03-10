namespace PartyTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuestResponses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WillAttend = c.Boolean(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        Adults = c.Int(nullable: false),
                        Arrival = c.String(nullable: false),
                        Departure = c.String(nullable: false),
                        Information = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GuestResponses");
        }
    }
}
