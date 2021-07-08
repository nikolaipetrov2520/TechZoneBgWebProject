using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class RemoveForumUserAndAddFNLN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_ForumUser_ForumUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_ForumUser_ForumUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_ForumUser_ForumUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ApplicationUserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ApplicationUserId1",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_ForumUser_AuthorId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_ForumUser_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReactions_AspNetUsers_ApplicationUserId",
                table: "PostReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReactions_ForumUser_AuthorId",
                table: "PostReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_AspNetUsers_ApplicationUserId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_ForumUser_AuthorId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_ForumUser_AuthorId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_ApplicationUserId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_ForumUser_AuthorId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReactions_AspNetUsers_ApplicationUserId",
                table: "ReplyReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReactions_ForumUser_AuthorId",
                table: "ReplyReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReports_AspNetUsers_ApplicationUserId",
                table: "ReplyReports");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReports_ForumUser_AuthorId",
                table: "ReplyReports");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_ApplicationUserId",
                table: "UsersFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_ForumUser_FollowerId",
                table: "UsersFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_ForumUser_UserId",
                table: "UsersFollowers");

            migrationBuilder.DropTable(
                name: "ForumUser");

            migrationBuilder.DropIndex(
                name: "IX_UsersFollowers_ApplicationUserId",
                table: "UsersFollowers");

            migrationBuilder.DropIndex(
                name: "IX_ReplyReports_ApplicationUserId",
                table: "ReplyReports");

            migrationBuilder.DropIndex(
                name: "IX_ReplyReactions_ApplicationUserId",
                table: "ReplyReactions");

            migrationBuilder.DropIndex(
                name: "IX_Replies_ApplicationUserId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_PostReports_ApplicationUserId",
                table: "PostReports");

            migrationBuilder.DropIndex(
                name: "IX_PostReactions_ApplicationUserId",
                table: "PostReactions");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ApplicationUserId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ApplicationUserId1",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ForumUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_ForumUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_ForumUserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UsersFollowers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ReplyReports");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "ReplyReactions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "PostReports");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "PostReactions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ForumUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ForumUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "ForumUserId",
                table: "AspNetUserClaims");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReactions_AspNetUsers_AuthorId",
                table: "PostReactions",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_AspNetUsers_AuthorId",
                table: "PostReports",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId",
                table: "Replies",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyReactions_AspNetUsers_AuthorId",
                table: "ReplyReactions",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyReports_AspNetUsers_AuthorId",
                table: "ReplyReports",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_FollowerId",
                table: "UsersFollowers",
                column: "FollowerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_UserId",
                table: "UsersFollowers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_AuthorId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_ReceiverId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReactions_AspNetUsers_AuthorId",
                table: "PostReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_AspNetUsers_AuthorId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AuthorId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_AuthorId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReactions_AspNetUsers_AuthorId",
                table: "ReplyReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReports_AspNetUsers_AuthorId",
                table: "ReplyReports");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_FollowerId",
                table: "UsersFollowers");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_UserId",
                table: "UsersFollowers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UsersFollowers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ReplyReports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "ReplyReactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Replies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "PostReports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "PostReactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForumUserId",
                table: "AspNetUserRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForumUserId",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForumUserId",
                table: "AspNetUserClaims",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForumUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersFollowers_ApplicationUserId",
                table: "UsersFollowers",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyReports_ApplicationUserId",
                table: "ReplyReports",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReplyReactions_ApplicationUserId",
                table: "ReplyReactions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_ApplicationUserId",
                table: "Replies",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReports_ApplicationUserId",
                table: "PostReports",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReactions_ApplicationUserId",
                table: "PostReactions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ApplicationUserId",
                table: "Messages",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ApplicationUserId1",
                table: "Messages",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ForumUserId",
                table: "AspNetUserRoles",
                column: "ForumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_ForumUserId",
                table: "AspNetUserLogins",
                column: "ForumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_ForumUserId",
                table: "AspNetUserClaims",
                column: "ForumUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumUser_IsDeleted",
                table: "ForumUser",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_ForumUser_ForumUserId",
                table: "AspNetUserClaims",
                column: "ForumUserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_ForumUser_ForumUserId",
                table: "AspNetUserLogins",
                column: "ForumUserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_ForumUser_ForumUserId",
                table: "AspNetUserRoles",
                column: "ForumUserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ApplicationUserId",
                table: "Messages",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_ApplicationUserId1",
                table: "Messages",
                column: "ApplicationUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_ForumUser_AuthorId",
                table: "Messages",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_ForumUser_ReceiverId",
                table: "Messages",
                column: "ReceiverId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReactions_AspNetUsers_ApplicationUserId",
                table: "PostReactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReactions_ForumUser_AuthorId",
                table: "PostReactions",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_AspNetUsers_ApplicationUserId",
                table: "PostReports",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostReports_ForumUser_AuthorId",
                table: "PostReports",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_ForumUser_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_ApplicationUserId",
                table: "Replies",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_ForumUser_AuthorId",
                table: "Replies",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyReactions_AspNetUsers_ApplicationUserId",
                table: "ReplyReactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyReactions_ForumUser_AuthorId",
                table: "ReplyReactions",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyReports_AspNetUsers_ApplicationUserId",
                table: "ReplyReports",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ReplyReports_ForumUser_AuthorId",
                table: "ReplyReports",
                column: "AuthorId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_ApplicationUserId",
                table: "UsersFollowers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_ForumUser_FollowerId",
                table: "UsersFollowers",
                column: "FollowerId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersFollowers_ForumUser_UserId",
                table: "UsersFollowers",
                column: "UserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
