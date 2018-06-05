namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2726312a-9133-4cd8-9e17-dfcf2a2e44a0', N'guest@vidly.com', 0, N'ANa5UWFAVjdZaVB21fbNJ2WtN2elP/6HqqnVpaHrhc2x5jgJUFBx/qPBKL2cRBe3nw==', N'54ed8b2d-fa4a-46b0-8f7c-276b695e25c1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'54647151-daca-46ff-813c-c4f539f3d608', N'admin@vidly.com', 0, N'AKeexqPn0dPQhjxJlDadXQPMpAFAkG6BC1UWDwJkw5oqnhkQQwfJVsJk5iwgyVDmNw==', N'fc28d0e4-1f48-4f85-8bf7-41b893d01e00', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2030e06b-b4b0-4466-ae7d-4148fda0d3d5', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'54647151-daca-46ff-813c-c4f539f3d608', N'2030e06b-b4b0-4466-ae7d-4148fda0d3d5')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
