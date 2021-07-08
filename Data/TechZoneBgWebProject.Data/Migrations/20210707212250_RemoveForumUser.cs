using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechZoneBgWebProject.Data.Migrations
{
    public partial class RemoveForumUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_ForumUser_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_ForumUser_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_ForumUser_UserId",
                table: "AspNetUserRoles");

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

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "ForumUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "ForumUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "AspNetUsers",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(max)",
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
                name: "FK_PostReactions_AspNetUsers_ApplicationUserId",
                table: "PostReactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
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
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
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
                name: "FK_ReplyReactions_AspNetUsers_ApplicationUserId",
                table: "ReplyReactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
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
                name: "FK_UsersFollowers_AspNetUsers_ApplicationUserId",
                table: "UsersFollowers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_PostReactions_AspNetUsers_ApplicationUserId",
                table: "PostReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_PostReports_AspNetUsers_ApplicationUserId",
                table: "PostReports");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_ApplicationUserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_ApplicationUserId",
                table: "Replies");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReactions_AspNetUsers_ApplicationUserId",
                table: "ReplyReactions");

            migrationBuilder.DropForeignKey(
                name: "FK_ReplyReports_AspNetUsers_ApplicationUserId",
                table: "ReplyReports");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersFollowers_AspNetUsers_ApplicationUserId",
                table: "UsersFollowers");

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
                name: "Biography",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ForumUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropColumn(
                name: "ForumUserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropColumn(
                name: "ForumUserId",
                table: "AspNetUserClaims");

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "ForumUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Biography",
                table: "ForumUser",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_ForumUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_ForumUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_ForumUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "ForumUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
