using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace spacer.Migrations
{
    public partial class sampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2002, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Mauris sit amet eros.", new DateTime(2014, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", new DateTime(2013, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Praesent blandit.", new DateTime(2006, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "In eleifend quam a odio. In hac habitasse platea dictumst.", new DateTime(2014, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "In hac habitasse platea dictumst.", new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.", new DateTime(2003, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Aenean sit amet justo. Morbi ut odio.", new DateTime(2010, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "In est risus, auctor sed, tristique in, tempus sit amet, sem. Fusce consequat.", new DateTime(2013, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Etiam faucibus cursus urna.", new DateTime(2006, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Mauris lacinia sapien quis libero.", new DateTime(2017, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2004, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.", new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros.", new DateTime(2022, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Morbi non lectus.", new DateTime(2013, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", new DateTime(2017, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum.", new DateTime(2003, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Proin risus. Praesent lectus.", new DateTime(2017, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "In congue.", new DateTime(2019, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 66, "In quis justo. Maecenas rhoncus aliquam lacus.", new DateTime(2012, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 3 },
                    { 69, "Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.", new DateTime(2022, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 70, "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci.", new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 72, "Etiam justo. Etiam pretium iaculis justo. In hac habitasse platea dictumst.", new DateTime(2022, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 1 },
                    { 73, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2007, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 4 },
                    { 77, "Aenean lectus.", new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 78, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", new DateTime(2008, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1 },
                    { 81, "Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante. Nulla justo. Aliquam quis turpis eget elit sodales scelerisque.", new DateTime(2010, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 82, "Morbi vel lectus in quam fringilla rhoncus.", new DateTime(2005, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 86, "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2014, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 88, "Donec semper sapien a libero. Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2010, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 3 },
                    { 89, "Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2002, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 90, "In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.", new DateTime(2005, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 3 },
                    { 93, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2016, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 97, "Phasellus sit amet erat. Nulla tempus.", new DateTime(2017, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1 },
                    { 101, "Donec semper sapien a libero.", new DateTime(2019, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 102, "Proin risus. Praesent lectus.", new DateTime(2015, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 104, "Nulla mollis molestie lorem. Quisque ut erat.", new DateTime(2003, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 106, "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue. Vestibulum rutrum rutrum neque.", new DateTime(2013, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 2 },
                    { 109, "In quis justo. Maecenas rhoncus aliquam lacus.", new DateTime(2001, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 4 },
                    { 110, "Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", new DateTime(2010, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 2 },
                    { 120, "Donec semper sapien a libero. Nam dui.", new DateTime(2008, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 126, "Pellentesque ultrices mattis odio. Donec vitae nisi.", new DateTime(2002, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 130, "Sed accumsan felis. Ut at dolor quis odio consequat varius. Integer ac leo.", new DateTime(2001, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 134, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis. Ut at dolor quis odio consequat varius.", new DateTime(2018, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 135, "Morbi non quam nec dui luctus rutrum. Nulla tellus.", new DateTime(2014, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 1 },
                    { 136, "Integer ac neque.", new DateTime(2013, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 145, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus.", new DateTime(2007, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 148, "Fusce consequat.", new DateTime(2007, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 150, "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2010, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 163, "Praesent lectus.", new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 165, "Nulla justo.", new DateTime(2003, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2 },
                    { 168, "Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem. Quisque ut erat.", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4 },
                    { 169, "Ut tellus. Nulla ut erat id mauris vulputate elementum. Nullam varius.", new DateTime(2007, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 1 },
                    { 174, "Nulla facilisi. Cras non velit nec nisi vulputate nonummy.", new DateTime(2013, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 178, "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", new DateTime(2017, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 185, "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.", new DateTime(2020, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 186, "Nulla ut erat id mauris vulputate elementum. Nullam varius.", new DateTime(2000, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 187, "Suspendisse potenti.", new DateTime(2017, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3 },
                    { 189, "Aliquam erat volutpat. In congue. Etiam justo.", new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 191, "Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2016, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 193, "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet. Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.", new DateTime(2008, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 195, "Nulla mollis molestie lorem.", new DateTime(2009, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 1 },
                    { 196, "Nunc purus. Phasellus in felis. Donec semper sapien a libero.", new DateTime(2000, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 198, "Suspendisse accumsan tortor quis turpis. Sed ante. Vivamus tortor.", new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 199, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2018, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate", "title", "userId" },
                values: new object[] { "Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede. Morbi porttitor lorem id ligula. Suspendisse ornare consequat lectus.", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Praesent blandit lacinia erat.", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "content", "creationDate", "title" },
                values: new object[] { "Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam.", new DateTime(2022, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suspendisse ornare consequat lectus." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "content", "creationDate", "title", "userId" },
                values: new object[] { "In eleifend quam a odio. In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt.", new DateTime(2011, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donec ut dolor.", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Ut at dolor quis odio consequat varius.", new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Morbi quis tortor id nulla ultrices aliquet.", 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "In sagittis dui vel nisl. Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus.", new DateTime(2009, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat.", new DateTime(2010, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "content", "creationDate", "title", "userId" },
                values: new object[] { "In hac habitasse platea dictumst.", new DateTime(2018, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl.", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Fusce posuere felis sed lacus.", new DateTime(2002, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem.", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Morbi ut odio.", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Donec ut dolor.", new DateTime(2003, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2000, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "In est risus, auctor sed, tristique in, tempus sit amet, sem." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Etiam pretium iaculis justo. In hac habitasse platea dictumst. Etiam faucibus cursus urna.", new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Pellentesque ultrices mattis odio.", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Pellentesque at nulla. Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2009, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Etiam vel augue.", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2015, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "In sagittis dui vel nisl. Duis ac nibh.", new DateTime(2006, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nam tristique tortor eu pede." });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "id", "content", "creationDate", "forumId", "title", "userId" },
                values: new object[,]
                {
                    { 17, "In hac habitasse platea dictumst.", new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Integer non velit.", 2 },
                    { 18, "Duis at velit eu est congue elementum. In hac habitasse platea dictumst.", new DateTime(2007, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", 3 },
                    { 19, "Duis bibendum. Morbi non quam nec dui luctus rutrum.", new DateTime(2018, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Proin eu mi.", 3 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "id", "content", "creationDate", "forumId", "title", "userId" },
                values: new object[,]
                {
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
                    { 42, "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", new DateTime(2015, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Proin interdum mauris non ligula pellentesque ultrices.", 2 },
                    { 43, "Cras in purus eu magna vulputate luctus.", new DateTime(2007, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Nullam molestie nibh in lectus.", 3 },
                    { 44, "Mauris sit amet eros.", new DateTime(2014, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Suspendisse potenti.", 4 },
                    { 45, "Aliquam non mauris. Morbi non lectus.", new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.", 2 },
                    { 46, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque. Duis bibendum.", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Vivamus in felis eu sapien cursus vestibulum.", 4 },
                    { 47, "Quisque erat eros, viverra eget, congue eget, semper rutrum, nulla. Nunc purus.", new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Aliquam non mauris.", 1 },
                    { 48, "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2002, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nulla justo.", 4 },
                    { 49, "Vivamus tortor. Duis mattis egestas metus.", new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Etiam vel augue.", 3 },
                    { 50, "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2018, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Vivamus in felis eu sapien cursus vestibulum.", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Etiam faucibus cursus urna. Ut tellus.", new DateTime(2010, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Phasellus sit amet erat. Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", new DateTime(2017, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2017, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci.", new DateTime(2003, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat.", new DateTime(2005, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Donec semper sapien a libero.", new DateTime(2003, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "In eleifend quam a odio. In hac habitasse platea dictumst.", new DateTime(2002, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Duis mattis egestas metus. Aenean fermentum.", new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nunc rhoncus dui vel sem.", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Duis mattis egestas metus.", new DateTime(2022, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Etiam faucibus cursus urna. Ut tellus.", new DateTime(2017, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 34 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2003, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui.", new DateTime(2003, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti. Nullam porttitor lacus at turpis.", new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Duis at velit eu est congue elementum. In hac habitasse platea dictumst. Morbi vestibulum, velit id pretium iaculis, diam erat fermentum justo, nec condimentum neque sapien placerat ante.", new DateTime(2019, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo.", new DateTime(2009, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est.", new DateTime(2015, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.", new DateTime(2011, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nulla facilisi.", new DateTime(2014, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2006, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", new DateTime(2018, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Sed ante. Vivamus tortor. Duis mattis egestas metus.", new DateTime(2022, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Etiam pretium iaculis justo.", new DateTime(2007, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus.", new DateTime(2015, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", new DateTime(2009, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nullam porttitor lacus at turpis.", new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Curabitur at ipsum ac tellus semper interdum. Mauris ullamcorper purus sit amet nulla. Quisque arcu libero, rutrum ac, lobortis vel, dapibus at, diam.", new DateTime(2010, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis. Fusce posuere felis sed lacus. Morbi sem mauris, laoreet ut, rhoncus aliquet, pulvinar sed, nisl.", new DateTime(2020, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla. Sed accumsan felis.", new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2006, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Praesent blandit lacinia erat. Vestibulum sed magna at nunc commodo placerat. Praesent blandit.", new DateTime(2013, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Nulla mollis molestie lorem. Quisque ut erat. Curabitur gravida nisi at nibh.", new DateTime(2018, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Cras non velit nec nisi vulputate nonummy. Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque.", new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", new DateTime(2022, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique. Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", new DateTime(2006, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2012, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2004, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nunc nisl. Duis bibendum, felis sed interdum venenatis, turpis enim blandit mi, in porttitor pede justo eu massa. Donec dapibus.", new DateTime(2014, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "In hac habitasse platea dictumst.", new DateTime(2005, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", new DateTime(2017, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti. In eleifend quam a odio.", new DateTime(2000, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nulla mollis molestie lorem. Quisque ut erat.", new DateTime(2013, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Vivamus vel nulla eget eros elementum pellentesque.", new DateTime(2012, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", new DateTime(2006, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Fusce congue, diam id ornare imperdiet, sapien urna pretium nisl, ut volutpat sapien arcu sed augue.", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 65, "Duis ac nibh. Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 67, "Morbi a ipsum. Integer a nibh. In quis justo.", new DateTime(2006, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 4 },
                    { 68, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Proin risus. Praesent lectus.", new DateTime(2000, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 4 },
                    { 71, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", new DateTime(2018, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 4 },
                    { 74, "Nulla facilisi. Cras non velit nec nisi vulputate nonummy.", new DateTime(2019, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 75, "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio. Curabitur convallis.", new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 4 },
                    { 76, "Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem. Integer tincidunt ante vel ipsum. Praesent blandit lacinia erat.", new DateTime(2010, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4 },
                    { 79, "Sed sagittis.", new DateTime(2010, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 4 },
                    { 80, "Fusce lacus purus, aliquet at, feugiat non, pretium quis, lectus. Suspendisse potenti.", new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 3 },
                    { 83, "Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.", new DateTime(2014, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 84, "Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc.", new DateTime(2006, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4 },
                    { 85, "Suspendisse potenti. Cras in purus eu magna vulputate luctus.", new DateTime(2005, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 1 },
                    { 87, "Donec ut mauris eget massa tempor convallis. Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2007, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 91, "Sed vel enim sit amet nunc viverra dapibus. Nulla suscipit ligula in lacus. Curabitur at ipsum ac tellus semper interdum.", new DateTime(2010, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 92, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2007, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 2 },
                    { 94, "Aliquam non mauris.", new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 95, "Morbi non quam nec dui luctus rutrum. Nulla tellus. In sagittis dui vel nisl.", new DateTime(2011, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 4 },
                    { 96, "Praesent blandit.", new DateTime(2003, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 98, "Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis.", new DateTime(2013, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 99, "Nulla ut erat id mauris vulputate elementum. Nullam varius.", new DateTime(2003, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 100, "Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.", new DateTime(2015, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 1 },
                    { 103, "Proin risus. Praesent lectus. Vestibulum quam sapien, varius ut, blandit non, interdum in, ante.", new DateTime(2001, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 1 },
                    { 105, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 4 },
                    { 107, "Morbi a ipsum.", new DateTime(2000, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 2 },
                    { 108, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2004, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 3 },
                    { 111, "Nulla ac enim. In tempor, turpis nec euismod scelerisque, quam turpis adipiscing lorem, vitae mattis nibh ligula nec sem. Duis aliquam convallis nunc.", new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 4 },
                    { 112, "In hac habitasse platea dictumst. Etiam faucibus cursus urna.", new DateTime(2013, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 1 },
                    { 113, "Integer a nibh.", new DateTime(2009, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 114, "Aliquam erat volutpat. In congue. Etiam justo.", new DateTime(2014, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 2 },
                    { 115, "Maecenas pulvinar lobortis est.", new DateTime(2022, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 4 },
                    { 116, "Integer ac leo. Pellentesque ultrices mattis odio. Donec vitae nisi.", new DateTime(2005, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 1 },
                    { 117, "Nullam sit amet turpis elementum ligula vehicula consequat.", new DateTime(2005, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 3 },
                    { 118, "Vestibulum sed magna at nunc commodo placerat.", new DateTime(2018, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 3 },
                    { 119, "Pellentesque viverra pede ac diam. Cras pellentesque volutpat dui. Maecenas tristique, est et tempus semper, est quam pharetra magna, ac consequat metus sapien ut nunc.", new DateTime(2006, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 1 },
                    { 121, "Integer tincidunt ante vel ipsum.", new DateTime(2014, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3 },
                    { 122, "Nam dui. Proin leo odio, porttitor id, consequat in, consequat ut, nulla.", new DateTime(2006, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 2 },
                    { 123, "Donec dapibus. Duis at velit eu est congue elementum.", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 2 },
                    { 124, "In hac habitasse platea dictumst. Etiam faucibus cursus urna. Ut tellus.", new DateTime(2012, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 125, "Ut tellus. Nulla ut erat id mauris vulputate elementum.", new DateTime(2004, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 127, "Donec vitae nisi.", new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 2 },
                    { 128, "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 3 },
                    { 129, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi. Integer ac neque.", new DateTime(2005, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 3 },
                    { 131, "In hac habitasse platea dictumst. Maecenas ut massa quis augue luctus tincidunt. Nulla mollis molestie lorem.", new DateTime(2015, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 2 },
                    { 132, "Proin risus.", new DateTime(2018, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 2 },
                    { 133, "In est risus, auctor sed, tristique in, tempus sit amet, sem.", new DateTime(2008, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4 },
                    { 137, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo.", new DateTime(2018, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 1 },
                    { 138, "Praesent blandit. Nam nulla. Integer pede justo, lacinia eget, tincidunt eget, tempus vel, pede.", new DateTime(2004, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 139, "Nam congue, risus semper porta volutpat, quam pede lobortis ligula, sit amet eleifend pede libero quis orci. Nullam molestie nibh in lectus. Pellentesque at nulla.", new DateTime(2001, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 2 },
                    { 140, "Sed accumsan felis.", new DateTime(2010, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 4 },
                    { 141, "Sed ante. Vivamus tortor.", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 2 },
                    { 142, "Duis aliquam convallis nunc. Proin at turpis a pede posuere nonummy. Integer non velit.", new DateTime(2012, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 1 },
                    { 143, "Donec vitae nisi. Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 4 },
                    { 144, "Integer ac neque.", new DateTime(2011, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 3 },
                    { 146, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est. Donec odio justo, sollicitudin ut, suscipit a, feugiat et, eros. Vestibulum ac est lacinia nisi venenatis tristique.", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 3 },
                    { 147, "Donec diam neque, vestibulum eget, vulputate ut, ultrices vel, augue. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Donec pharetra, magna vestibulum aliquet ultrices, erat tortor sollicitudin mi, sit amet lobortis sapien sapien non mi.", new DateTime(2013, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 4 },
                    { 149, "Etiam justo.", new DateTime(2009, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 4 },
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
                    { 164, "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum.", new DateTime(2019, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 2 },
                    { 166, "Maecenas pulvinar lobortis est. Phasellus sit amet erat.", new DateTime(2013, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 3 },
                    { 167, "Integer a nibh. In quis justo.", new DateTime(2003, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1 },
                    { 170, "Donec quis orci eget orci vehicula condimentum.", new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4 },
                    { 171, "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti.", new DateTime(2014, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 4 },
                    { 172, "Morbi a ipsum. Integer a nibh. In quis justo.", new DateTime(2006, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 2 },
                    { 173, "Nulla tempus. Vivamus in felis eu sapien cursus vestibulum. Proin eu mi.", new DateTime(2011, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 3 },
                    { 175, "Curabitur convallis. Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor.", new DateTime(2010, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 176, "Aliquam non mauris. Morbi non lectus. Aliquam sit amet diam in magna bibendum imperdiet.", new DateTime(2004, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 3 },
                    { 177, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 3 },
                    { 179, "Nulla neque libero, convallis eget, eleifend luctus, ultricies eu, nibh. Quisque id justo sit amet sapien dignissim vestibulum.", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 2 },
                    { 180, "Nulla tellus. In sagittis dui vel nisl. Duis ac nibh.", new DateTime(2010, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 2 },
                    { 181, "Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est.", new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 3 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "id", "content", "creationDate", "postId", "userId" },
                values: new object[,]
                {
                    { 182, "Nulla justo. Aliquam quis turpis eget elit sodales scelerisque. Mauris sit amet eros.", new DateTime(2009, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 3 },
                    { 183, "Duis mattis egestas metus. Aenean fermentum. Donec ut mauris eget massa tempor convallis.", new DateTime(2012, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 1 },
                    { 184, "Quisque ut erat. Curabitur gravida nisi at nibh. In hac habitasse platea dictumst.", new DateTime(2016, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4 },
                    { 188, "Nam ultrices, libero non mattis pulvinar, nulla pede ullamcorper augue, a suscipit nulla elit ac nulla.", new DateTime(2013, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 1 },
                    { 190, "Curabitur in libero ut massa volutpat convallis.", new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 4 },
                    { 192, "In quis justo. Maecenas rhoncus aliquam lacus.", new DateTime(2013, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 4 },
                    { 194, "Vivamus vestibulum sagittis sapien.", new DateTime(2004, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 3 },
                    { 197, "Cras mi pede, malesuada in, imperdiet et, commodo vulputate, justo. In blandit ultrices enim. Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", new DateTime(2019, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 1 },
                    { 200, "Vestibulum quam sapien, varius ut, blandit non, interdum in, ante. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis faucibus accumsan odio.", new DateTime(2013, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6123), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6132), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6140), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6146), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6159), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6167), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6173), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6178), 2, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6191), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6197), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6203), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6209), 3, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Great article!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6221), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Very interesting!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6227), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Loved this!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6233), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "I agree!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6239), 4, 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6261), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6268), 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6274), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6305), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6318), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6324), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6331), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6338), 6, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6350), 7 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6356), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6362), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6368), 7, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Nice perspective!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6380), 8 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "More details please!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6386), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can you elaborate?", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6392), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Interesting read!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6398), 8, 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6411), 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6418), 9, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6424), 9, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6430), 9, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6442), 10, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6448), 10, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6454), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6460), 10 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6495), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6501), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6508), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6514), 11, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Fascinating stuff!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6527), 12 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Totally true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6533), 12, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Can't wait!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6539), 12, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "So true!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6545), 12, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6557), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "content", "creationDate", "postId" },
                values: new object[] { "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6562), 13 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 51,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6568), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 52,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6574), 13, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 53,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6587), 14, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 54,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6593), 14, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 55,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6599), 14, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 56,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6605), 14, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 57,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6617), 15, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6623), 15, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6629), 15, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6635), 15, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 61,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Well said!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6647), 16, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 62,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Looking forward!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6653), 16, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 63,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Absolutely!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6659), 16, 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "id",
                keyValue: 64,
                columns: new[] { "content", "creationDate", "postId", "userId" },
                values: new object[] { "Keep it up!", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6688), 16, 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "content", "creationDate", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6073), "Tech Innovations", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "content", "creationDate", "title" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6153), "Space Discoveries" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "content", "creationDate", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6184), "Game Releases", 1 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6215), 1, "Music Trends" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6254), 2, "AI in 2024", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6312), 2, "Mars Rover", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6344), 2, "New Console", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "content", "creationDate", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6374), "Top 10 Albums", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6404), 3, "Gadgets 2023", 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6436), 3, "Climate Change", 3 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6487), 3, "Indie Games" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6520), 3, "Concerts Near Me" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6551), 4, "Future of Tech", 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6581), 4, "Quantum Physics", 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "content", "creationDate", "forumId", "title", "userId" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6611), 4, "VR Experience", 4 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "content", "creationDate", "forumId", "title" },
                values: new object[] { "Post content", new DateTime(2024, 11, 1, 17, 50, 29, 74, DateTimeKind.Local).AddTicks(6641), 4, "Live Performances" });
        }
    }
}
