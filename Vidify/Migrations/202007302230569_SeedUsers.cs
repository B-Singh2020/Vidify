namespace Vidify.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'753ed0e7-51a1-4fec-b440-110ec0fbb88a', N'admin@vidify.com', 0, N'APb5qUMaMEyhSDfUvRXlkalt3yShOxIZ6AbEPFszIPRn1H9OrLO1K9VTCzUi2PsraQ==', N'405a3dad-5395-464d-949c-115990dc88ef', NULL, 0, 0, NULL, 1, 0, N'admin@vidify.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a9cf6b91-4f13-4546-b73d-f0c39b967f49', N'guest@vidify.com', 0, N'ACOXwmHaDNls23L4xsrfEtMwTtglLFFHlHSIAfhUqfU7d3wEPmnhmErd3WWxyTWu/Q==', N'a3b50f70-acca-4619-9d9c-33df6ffb97b9', NULL, 0, 0, NULL, 1, 0, N'guest@vidify.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b008615f-7a83-40ee-8882-2afa6af05505', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'753ed0e7-51a1-4fec-b440-110ec0fbb88a', N'b008615f-7a83-40ee-8882-2afa6af05505')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
