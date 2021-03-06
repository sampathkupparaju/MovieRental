namespace Warehouse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'31c37cc5-6e1d-48e8-8b0a-faf0115f7682', N'admin@warehouse.com', 0, N'ADfztC5iBOYjpzhSGirUoc5uYWsVXzQIgnCJAnFKITRj3Y0GCN7l2KsLVuwUf0U9TQ==', N'8b550e61-7fe7-4928-987f-ca00751bd938', NULL, 0, 0, NULL, 1, 0, N'admin@warehouse.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ca0ce9a7-b86f-4e3e-b5b6-d68aab4ece25', N'guest@warehouse.com', 0, N'AEDLBl+6r/eIbaTU26OhHmOIgSwnFn2Fs4So0Pe7O3j5TIHDlGRIGtz5Qy+BAr9EQg==', N'e8ab0908-0c6e-406c-8dbe-c3696bf82981', NULL, 0, 0, NULL, 1, 0, N'guest@warehouse.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'53ebe44d-9096-4fee-8569-e183ccfa2872', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'31c37cc5-6e1d-48e8-8b0a-faf0115f7682', N'53ebe44d-9096-4fee-8569-e183ccfa2872')


");

        }
        
        public override void Down()
        {
        }
    }
}
