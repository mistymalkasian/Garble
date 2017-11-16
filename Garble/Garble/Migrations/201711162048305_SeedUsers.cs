namespace Garble.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'045c2c7a-f891-400c-a51e-713e0943527b', N'admin@garble.com', 0, N'AFYD8F4Lyi3U+cHSL8+mRhRmYW9OVMdtxe/h9SvyjxQXJ5iyYGop2GgW9yqbp2x9iA==', N'fb1e9dca-104c-4acd-84e2-239f7f7162e9', NULL, 0, 0, NULL, 1, 0, N'admin@garble.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6b294056-c68d-4fe4-b3ca-681738182edd', N'banana@garble.com', 0, N'AKGvTWmHdgaMpkhOd4pcVRTGBHIdco/ppPG8rzQ29+TbnQGhx4N/EMb2q+nSX/RC2w==', N'beec9da1-7b8a-4909-83cd-0f7daf6b34f9', NULL, 0, 0, NULL, 1, 0, N'banana@garble.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c0f023ac-60ed-45af-a354-82676e815d84', N'CanManageCollections')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'045c2c7a-f891-400c-a51e-713e0943527b', N'c0f023ac-60ed-45af-a354-82676e815d84')

");
        }
        
        public override void Down()
        {
        }
    }
}
