using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spacer.Migrations
{
    public partial class newdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate" },
                values: new object[] { "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 2, "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6132), 1, 1 },
                    { 3, "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6140), 1, 1 },
                    { 4, "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6146), 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate", "title" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6073), "Tech Innovations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "id", "content", "creationDate", "forumId", "title", "userId" },
                values: new object[,]
                {
                    { 2, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6153), 1, "Space Discoveries", 1 },
                    { 3, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6184), 1, "Game Releases", 1 },
                    { 4, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6215), 1, "Music Trends", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Subspaces",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "technology");

            migrationBuilder.InsertData(
                table: "Subspaces",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 2, "science" },
                    { 3, "gaming" },
                    { 4, "music" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "name", "password" },
                values: new object[] { "alice@example.com", "alice", "password1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "name", "password" },
                values: new object[,]
                {
                    { 2, "bob@example.com", "bob", "password2" },
                    { 3, "charlie@example.com", "charlie", "password3" },
                    { 4, "dave@example.com", "dave", "password4" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 5, "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6159), 2, 1 },
                    { 6, "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6167), 2, 1 },
                    { 7, "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6173), 2, 1 },
                    { 8, "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6178), 2, 1 },
                    { 9, "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6191), 3, 1 },
                    { 10, "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6197), 3, 1 },
                    { 11, "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6203), 3, 1 },
                    { 12, "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6209), 3, 1 },
                    { 13, "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6221), 4, 1 },
                    { 14, "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6227), 4, 1 },
                    { 15, "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6233), 4, 1 },
                    { 16, "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6239), 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "id", "content", "creationDate", "forumId", "title", "userId" },
                values: new object[,]
                {
                    { 5, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6254), 2, "AI in 2024", 2 },
                    { 6, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6312), 2, "Mars Rover", 2 },
                    { 7, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6344), 2, "New Console", 2 },
                    { 8, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6374), 2, "Top 10 Albums", 2 },
                    { 9, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6404), 3, "Gadgets 2023", 3 },
                    { 10, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6436), 3, "Climate Change", 3 },
                    { 11, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6487), 3, "Indie Games", 3 },
                    { 12, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6520), 3, "Concerts Near Me", 3 },
                    { 13, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6551), 4, "Future of Tech", 4 },
                    { 14, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6581), 4, "Quantum Physics", 4 },
                    { 15, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6611), 4, "VR Experience", 4 },
                    { 16, "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6641), 4, "Live Performances", 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 17, "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6261), 5, 2 },
                    { 18, "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6268), 5, 2 },
                    { 19, "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6274), 5, 2 },
                    { 20, "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6305), 5, 2 },
                    { 21, "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6318), 6, 2 },
                    { 22, "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6324), 6, 2 },
                    { 23, "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6331), 6, 2 },
                    { 24, "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6338), 6, 2 },
                    { 25, "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6350), 7, 2 },
                    { 26, "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6356), 7, 2 },
                    { 27, "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6362), 7, 2 },
                    { 28, "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6368), 7, 2 },
                    { 29, "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6380), 8, 2 },
                    { 30, "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6386), 8, 2 },
                    { 31, "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6392), 8, 2 },
                    { 32, "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6398), 8, 2 },
                    { 33, "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6411), 9, 3 },
                    { 34, "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6418), 9, 3 },
                    { 35, "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6424), 9, 3 },
                    { 36, "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6430), 9, 3 },
                    { 37, "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6442), 10, 3 },
                    { 38, "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6448), 10, 3 },
                    { 39, "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6454), 10, 3 },
                    { 40, "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6460), 10, 3 },
                    { 41, "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6495), 11, 3 },
                    { 42, "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6501), 11, 3 },
                    { 43, "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6508), 11, 3 },
                    { 44, "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6514), 11, 3 },
                    { 45, "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6527), 12, 3 },
                    { 46, "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6533), 12, 3 },
                    { 47, "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6539), 12, 3 },
                    { 48, "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6545), 12, 3 },
                    { 49, "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6557), 13, 4 },
                    { 50, "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6562), 13, 4 },
                    { 51, "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6568), 13, 4 },
                    { 52, "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6574), 13, 4 },
                    { 53, "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6587), 14, 4 },
                    { 54, "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6593), 14, 4 },
                    { 55, "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6599), 14, 4 },
                    { 56, "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6605), 14, 4 },
                    { 57, "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6617), 15, 4 },
                    { 58, "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6623), 15, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 59, "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6629), 15, 4 },
                    { 60, "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6635), 15, 4 },
                    { 61, "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6647), 16, 4 },
                    { 62, "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6653), 16, 4 },
                    { 63, "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6659), 16, 4 },
                    { 64, "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6688), 16, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subspaces",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subspaces",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subspaces",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate" },
                values: new object[] { "Test", new DateTime(2024, 11, 1, 17, 42, 52, 683, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate", "title" },
                values: new object[] { "Test", new DateTime(2024, 11, 1, 17, 42, 52, 683, DateTimeKind.Local).AddTicks(7244), "Test" });

            migrationBuilder.UpdateData(
                table: "Subspaces",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "email", "name", "password" },
                values: new object[] { "Test@Gmail.com", "Test", "password" });
        }
    }
}
