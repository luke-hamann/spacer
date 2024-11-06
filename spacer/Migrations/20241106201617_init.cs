using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spacer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subspaces",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subspaces", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    forumId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Posts_Subspaces_forumId",
                        column: x => x.forumId,
                        principalTable: "Subspaces",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    postId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_postId",
                        column: x => x.postId,
                        principalTable: "Posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Subspaces",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "technology" },
                    { 2, "science" },
                    { 3, "gaming" },
                    { 4, "music" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "name", "password" },
                values: new object[,]
                {
                    { 1, "alice@example.com", "alice", "password1" },
                    { 2, "bob@example.com", "bob", "password2" },
                    { 3, "charlie@example.com", "charlie", "password3" },
                    { 4, "dave@example.com", "dave", "password4" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "id", "content", "creationDate", "forumId", "title", "userId" },
                values: new object[,]
                {
                    { 1, "Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus.", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Praesent blandit lacinia erat.", 2 },
                    { 2, "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Suspendisse ornare consequat lectus.", 1 },
                    { 3, "In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt.", new DateTime(2011, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Donec ut dolor.", 2 },
                    { 4, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.", 1 },
                    { 5, "Ut at dolor quis odio consequat varius.", new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Morbi quis tortor id nulla ultrices aliquet.", 4 },
                    { 6, "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.", new DateTime(2009, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", 3 },
                    { 7, "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.", new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", 1 },
                    { 8, "In hac habitasse platea dictumst.", new DateTime(2018, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", 1 },
                    { 9, "Fusce posuere felis sed lacus.", new DateTime(2002, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", 2 },
                    { 10, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morbi ut odio.", 1 },
                    { 11, "Donec ut dolor.", new DateTime(2003, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", 3 },
                    { 12, "Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", 3 },
                    { 13, "Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.", new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pellentesque ultrices mattis odio.", 2 },
                    { 14, "Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2009, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Etiam vel augue.", 1 },
                    { 15, "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", 1 },
                    { 16, "In sagittis dui vel nisl. Duis ac nibh.", new DateTime(2006, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nam tristique tortor eu pede.", 4 },
                    { 17, "In hac habitasse platea dictumst.", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Integer non velit.", 2 },
                    { 18, "Duis at velit eu est congue elementum. In hac habitasse platea dictumst.", new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", 3 },
                    { 19, "Duis bibendum. Morbi non quam nec dui luctus rutrum.", new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Proin eu mi.", 3 },
                    { 20, "Donec dapibus. Duis at velit eu est congue elementum. In hac habitasse platea dictumst.", new DateTime(2015, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", 4 },
                    { 21, "Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Vivamus in felis eu sapien cursus vestibulum.", 3 },
                    { 22, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", new DateTime(2020, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Integer non velit.", 4 },
                    { 23, "Fusce consequat. Nulla nisl.", new DateTime(2008, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Nullam sit amet turpis elementum ligula vehicula consequat.", 4 },
                    { 24, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.", new DateTime(2017, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Nulla tellus.", 2 },
                    { 25, "Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh.", new DateTime(2000, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla.", 1 },
                    { 26, "Suspendisse potenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nullam molestie nibh in lectus.", 2 },
                    { 27, "Maecenas pulvinar lobortis est.", new DateTime(2016, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Integer a nibh.", 3 },
                    { 28, "Vestibulum rutrum rutrum neque.", new DateTime(2007, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cras pellentesque volutpat dui.", 3 },
                    { 29, "In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2008, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Donec ut dolor.", 1 },
                    { 30, "Etiam justo.", new DateTime(2004, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Cras pellentesque volutpat dui.", 4 },
                    { 31, "Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2019, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "In hac habitasse platea dictumst.", 4 },
                    { 32, "Morbi a ipsum. Integer a nibh. In quis justo.", new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", 1 },
                    { 33, "Nunc purus. Phasellus in felis. Donec semper sapien a libero.", new DateTime(2019, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nam nulla.", 2 },
                    { 34, "Nunc purus.", new DateTime(2006, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", 1 },
                    { 35, "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2001, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "In quis justo.", 3 },
                    { 36, "Suspendisse accumsan tortor quis turpis.", new DateTime(2015, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Phasellus sit amet erat.", 1 },
                    { 37, "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue. Aliquam erat volutpat.", new DateTime(2015, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Donec semper sapien a libero.", 1 },
                    { 38, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2017, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Morbi ut odio.", 3 },
                    { 39, "Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis.", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.", 3 },
                    { 40, "Etiam justo. Etiam pretium iaculis justo.", new DateTime(2016, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "In hac habitasse platea dictumst.", 4 },
                    { 41, "In hac habitasse platea dictumst. Etiam faucibus cursus urna.", new DateTime(2013, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Sed vel enim sit amet nunc viverra dapibus.", 1 },
                    { 42, "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", new DateTime(2015, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Proin interdum mauris non ligula pellentesque ultrices.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "id", "content", "creationDate", "forumId", "title", "userId" },
                values: new object[,]
                {
                    { 43, "Cras in purus eu magna vulputate luctus.", new DateTime(2007, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Nullam molestie nibh in lectus.", 3 },
                    { 44, "Mauris sit amet eros.", new DateTime(2014, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Suspendisse potenti.", 4 },
                    { 45, "Aliquam non mauris. Morbi non lectus.", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.", 2 },
                    { 46, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vivamus in felis eu sapien cursus vestibulum.", 4 },
                    { 47, "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.", new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Aliquam non mauris.", 1 },
                    { 48, "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2002, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nulla justo.", 4 },
                    { 49, "Vivamus tortor. Duis mattis egestas metus.", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Etiam vel augue.", 3 },
                    { 50, "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2018, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Vivamus in felis eu sapien cursus vestibulum.", 2 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 1, "Etiam faucibus cursus urna. Ut tellus.", new DateTime(2010, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 2, "Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", new DateTime(2017, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 3, "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2017, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 1 },
                    { 4, "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 },
                    { 5, "Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", new DateTime(2003, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 6, "Mauris sit amet eros.", new DateTime(2014, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4 },
                    { 7, "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.", new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 1 },
                    { 8, "Donec semper sapien a libero.", new DateTime(2003, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4 },
                    { 9, "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 10, "Praesent blandit.", new DateTime(2006, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 11, "In eleifend quam a odio. In hac habitasse platea dictumst.", new DateTime(2014, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4 },
                    { 12, "In eleifend quam a odio. In hac habitasse platea dictumst.", new DateTime(2002, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3 },
                    { 13, "In hac habitasse platea dictumst.", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 14, "Duis mattis egestas metus. Aenean fermentum.", new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 15, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.", new DateTime(2003, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3 },
                    { 16, "Nunc rhoncus dui vel sem.", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 17, "Duis mattis egestas metus.", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 18, "Etiam faucibus cursus urna. Ut tellus.", new DateTime(2017, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 2 },
                    { 19, "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2003, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4 },
                    { 20, "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", new DateTime(2003, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 3 },
                    { 21, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis.", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 4 },
                    { 22, "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 23, "Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.", new DateTime(2009, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 24, "Aenean sit amet justo. Morbi ut odio.", new DateTime(2010, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 25, "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est.", new DateTime(2015, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 2 },
                    { 26, "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2011, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 27, "Nulla facilisi.", new DateTime(2014, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 4 },
                    { 28, "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2006, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 29, "Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", new DateTime(2018, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 30, "In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.", new DateTime(2013, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 31, "Sed ante. Vivamus tortor. Duis mattis egestas metus.", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4 },
                    { 32, "Etiam pretium iaculis justo.", new DateTime(2007, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1 },
                    { 33, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.", new DateTime(2015, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 34, "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", new DateTime(2009, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 35, "Nullam porttitor lacus at turpis.", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 2 },
                    { 36, "Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", new DateTime(2010, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 37, "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.", new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 2 },
                    { 38, "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 1 },
                    { 39, "Etiam faucibus cursus urna.", new DateTime(2006, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 3 },
                    { 40, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2006, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 41, "Mauris lacinia sapien quis libero.", new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 42, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2004, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 43, "Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit.", new DateTime(2013, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 44, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.", new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 45, "Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.", new DateTime(2018, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 46, "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 2 },
                    { 47, "Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 4 },
                    { 48, "Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 4 },
                    { 49, "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", new DateTime(2006, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 3 },
                    { 50, "Morbi non lectus.", new DateTime(2013, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 4 },
                    { 51, "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", new DateTime(2017, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 52, "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2012, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 53, "Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2004, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1 },
                    { 54, "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 55, "In hac habitasse platea dictumst.", new DateTime(2005, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 56, "Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", new DateTime(2017, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 57, "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.", new DateTime(2000, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 58, "Nulla mollis molestie lorem. Quisque ut erat.", new DateTime(2013, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 59, "Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.", new DateTime(2003, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 60, "Proin risus. Praesent lectus.", new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 61, "Vivamus vel nulla eget eros elementum pellentesque.", new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3 },
                    { 62, "In congue.", new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2 },
                    { 63, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", new DateTime(2006, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 2 },
                    { 64, "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1 },
                    { 65, "Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 66, "In quis justo. Maecenas rhoncus aliquam lacus.", new DateTime(2012, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 67, "Morbi a ipsum. Integer a nibh. In quis justo.", new DateTime(2006, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 4 },
                    { 68, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus.", new DateTime(2000, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 4 },
                    { 69, "Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 70, "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 71, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", new DateTime(2018, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 4 },
                    { 72, "Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 73, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2007, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4 },
                    { 74, "Nulla facilisi. Cras non velit nec nisi vulputate nonummy.", new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 75, "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.", new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4 },
                    { 76, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2010, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4 },
                    { 77, "Aenean lectus.", new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 78, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", new DateTime(2008, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 79, "Sed sagittis.", new DateTime(2010, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4 },
                    { 80, "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 81, "Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque.", new DateTime(2010, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 82, "Morbi vel lectus in quam fringilla rhoncus.", new DateTime(2005, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 83, "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.", new DateTime(2014, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 84, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", new DateTime(2006, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 85, "Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2005, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 86, "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 87, "Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2007, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 88, "Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2010, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 89, "Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2002, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 90, "In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.", new DateTime(2005, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 91, "Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.", new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 92, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2007, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 93, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2016, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 94, "Aliquam non mauris.", new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 95, "Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.", new DateTime(2011, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 4 },
                    { 96, "Praesent blandit.", new DateTime(2003, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 97, "Phasellus sit amet erat. Nulla tempus.", new DateTime(2017, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 98, "Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.", new DateTime(2013, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 99, "Nulla ut erat id mauris vulputate elementum. Nullam varius.", new DateTime(2003, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 100, "Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", new DateTime(2015, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 101, "Donec semper sapien a libero.", new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 102, "Proin risus. Praesent lectus.", new DateTime(2015, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 103, "Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", new DateTime(2001, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 104, "Nulla mollis molestie lorem. Quisque ut erat.", new DateTime(2003, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 105, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 4 },
                    { 106, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.", new DateTime(2013, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 107, "Morbi a ipsum.", new DateTime(2000, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 108, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2004, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 109, "In quis justo. Maecenas rhoncus aliquam lacus.", new DateTime(2001, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 110, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", new DateTime(2010, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 111, "Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.", new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 4 },
                    { 112, "In hac habitasse platea dictumst. Etiam faucibus cursus urna.", new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 113, "Integer a nibh.", new DateTime(2009, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 114, "Aliquam erat volutpat. In congue. Etiam justo.", new DateTime(2014, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 115, "Maecenas pulvinar lobortis est.", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4 },
                    { 116, "Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.", new DateTime(2005, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 117, "Nullam sit amet turpis elementum ligula vehicula consequat.", new DateTime(2005, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 118, "Vestibulum sed magna at nunc commodo placerat.", new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 119, "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 120, "Donec semper sapien a libero. Nam dui.", new DateTime(2008, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 121, "Integer tincidunt ante vel ipsum.", new DateTime(2014, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 122, "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2006, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 123, "Donec dapibus. Duis at velit eu est congue elementum.", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 124, "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", new DateTime(2012, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 125, "Ut tellus. Nulla ut erat id mauris vulputate elementum.", new DateTime(2004, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 126, "Pellentesque ultrices mattis odio. Donec vitae nisi.", new DateTime(2002, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 127, "Donec vitae nisi.", new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 128, "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 129, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 130, "Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo.", new DateTime(2001, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 131, "In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.", new DateTime(2015, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 132, "Proin risus.", new DateTime(2018, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 133, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", new DateTime(2008, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4 },
                    { 134, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 135, "Morbi non quam nec dui luctus rutrum. Nulla tellus.", new DateTime(2014, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 136, "Integer ac neque.", new DateTime(2013, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 137, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 138, "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2004, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 139, "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", new DateTime(2001, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 140, "Sed accumsan felis.", new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 4 },
                    { 141, "Sed ante. Vivamus tortor.", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 142, "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.", new DateTime(2012, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 143, "Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4 },
                    { 144, "Integer ac neque.", new DateTime(2011, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 145, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus.", new DateTime(2007, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 146, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 147, "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", new DateTime(2013, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 4 },
                    { 148, "Fusce consequat.", new DateTime(2007, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 149, "Etiam justo.", new DateTime(2009, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 4 },
                    { 150, "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2010, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 151, "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", new DateTime(2017, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 4 },
                    { 152, "Donec semper sapien a libero. Nam dui.", new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 3 },
                    { 153, "Vivamus tortor.", new DateTime(2003, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 4 },
                    { 154, "Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2015, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 2 },
                    { 155, "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa.", new DateTime(2019, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4 },
                    { 156, "Nam tristique tortor eu pede.", new DateTime(2017, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 2 },
                    { 157, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2006, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 158, "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 1 },
                    { 159, "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2007, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 160, "Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 4 },
                    { 161, "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi.", new DateTime(2015, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 162, "Nullam molestie nibh in lectus. Pellentesque at nulla.", new DateTime(2015, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 4 },
                    { 163, "Praesent lectus.", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 164, "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 165, "Nulla justo.", new DateTime(2003, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 166, "Maecenas pulvinar lobortis est. Phasellus sit amet erat.", new DateTime(2013, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 167, "Integer a nibh. In quis justo.", new DateTime(2003, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 168, "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 169, "Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.", new DateTime(2007, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 170, "Donec quis orci eget orci vehicula condimentum.", new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4 },
                    { 171, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2014, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 4 },
                    { 172, "Morbi a ipsum. Integer a nibh. In quis justo.", new DateTime(2006, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 173, "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi.", new DateTime(2011, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 174, "Nulla facilisi. Cras non velit nec nisi vulputate nonummy.", new DateTime(2013, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 175, "Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 176, "Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.", new DateTime(2004, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 177, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 178, "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", new DateTime(2017, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 179, "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 180, "Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.", new DateTime(2010, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 181, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 3 },
                    { 182, "Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", new DateTime(2009, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 183, "Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis.", new DateTime(2012, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 184, "Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", new DateTime(2016, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4 },
                    { 185, "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.", new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 186, "Nulla ut erat id mauris vulputate elementum. Nullam varius.", new DateTime(2000, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 187, "Suspendisse potenti.", new DateTime(2017, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 188, "Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2013, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 189, "Aliquam erat volutpat. In congue. Etiam justo.", new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 190, "Curabitur in libero ut massa volutpat convallis.", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 4 },
                    { 191, "Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2016, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 192, "In quis justo. Maecenas rhoncus aliquam lacus.", new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 4 },
                    { 193, "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", new DateTime(2008, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 194, "Vivamus vestibulum sagittis sapien.", new DateTime(2004, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 195, "Nulla mollis molestie lorem.", new DateTime(2009, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 196, "Nunc purus. Phasellus in felis. Donec semper sapien a libero.", new DateTime(2000, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 197, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 198, "Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor.", new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 199, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 },
                    { 200, "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", new DateTime(2013, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_postId",
                table: "Comments",
                column: "postId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_userId",
                table: "Comments",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_forumId",
                table: "Posts",
                column: "forumId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_userId",
                table: "Posts",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Subspaces");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
