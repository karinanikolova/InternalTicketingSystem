using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("34afa6e3-d6d1-42b0-afc4-9a9b5edd278b"), "Hardware" },
                    { new Guid("98d8e692-4707-475e-b870-92a37f881986"), "HR" },
                    { new Guid("9c9d0d44-2ab3-4912-8c04-2f2192ed80e1"), "Network & Access Request" },
                    { new Guid("c21d907c-a05f-4b7f-b4b2-e989dffb8d2a"), "Facilities" },
                    { new Guid("cfaff174-8b18-46f8-bcb3-87dd2ffec7ad"), "Software" },
                    { new Guid("fe9fdc3f-7e82-47f8-a432-76ea5bbfd396"), "Security" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ee540ac-e651-45f5-97c7-a908df086e2d"), "Human Resources" },
                    { new Guid("2cd02069-2cb2-4b58-8cc5-58538f4480cb"), "IT & Security" },
                    { new Guid("c3f276a1-35a7-4b50-bfbc-373f706d5cd5"), "Facilities" },
                    { new Guid("cc6a4f78-4c15-41e3-ae61-a6420f6de8cd"), "Quality Assurance" },
                    { new Guid("e84fad18-ed54-47cd-aeaf-4c94b513d8bc"), "Engineering & Development" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("5f439325-7a78-4d47-8e5f-c58787c10b94"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0480d7eb-c544-4058-8b07-c828104189af"), 0, "8bb7efe5-a723-4604-9e2d-92b3d40b0b80", new Guid("c3f276a1-35a7-4b50-bfbc-373f706d5cd5"), "stanleym@mail.com", false, "Stanley", "Morgan", false, null, "STANLEYM@MAIL.COM", "STANM", "AQAAAAIAAYagAAAAEF2pE5ECgm7TWxN7uExaXLhUWv0lbC4pGqowWBY+J9iRDnfma4NhyeV3nA3RTtxhEw==", null, false, null, false, "StanM" },
                    { new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"), 0, "dd09a1c5-4b79-416d-b89b-536b3324960e", new Guid("2cd02069-2cb2-4b58-8cc5-58538f4480cb"), "maryc@mail.com", false, "Mary", "Cooper", false, null, "MARYC@MAIL.COM", "MARYC", "AQAAAAIAAYagAAAAEEg3Q25V0F//wByPaO4htd2IXvIuR/ZPAIjZ9IoHx7uMLtvpEnbxrNsX+p6LfV6wHw==", null, false, null, false, "MaryC" },
                    { new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), 0, "4b4dd194-4a6a-459f-8668-c4574e6e3e3d", new Guid("2cd02069-2cb2-4b58-8cc5-58538f4480cb"), "admin@mail.com", false, "Garry", "Francis", false, null, "ADMIN@MAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAEK/ZkT51moQ3lBZpwOy53lnz2uEFtdlUoBcB4zw3hwje1g/WqHP/TyWjiDl27+szoA==", null, false, null, false, "AdminUser" },
                    { new Guid("98bd95e4-71a2-488a-a56d-12245dd7f291"), 0, "4e0609e2-cc91-46ed-beb3-7f6bdc395f5a", new Guid("cc6a4f78-4c15-41e3-ae61-a6420f6de8cd"), "mlevin@mail.com", false, "Mark", "Levin", false, null, "MLEVIN@MAIL.COM", "MLEVIN", "AQAAAAIAAYagAAAAEJ3MbPLWcpd5l1Qhm63T8hdDhvlyUBvrdU8ItuONCpmofyfeXM0dG9YJY5usN8AHzw==", null, false, null, false, "MLevin" },
                    { new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c"), 0, "98a7c063-d20c-42ed-9336-52676e3aa2b6", new Guid("0ee540ac-e651-45f5-97c7-a908df086e2d"), "sandyb@mail.com", false, "Sandy", "Brown", false, null, "SANDYB@MAIL.COM", "SANDYB", "AQAAAAIAAYagAAAAENUG7A1UyCGRQhmOruYmaRofr8Aj7XmQw4p1obWk661OfUromW8lR29cg/wgRy5Ixw==", null, false, null, false, "SandyB" },
                    { new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946"), 0, "bafc0ae5-b031-4fb0-99f1-58f3daf74d75", new Guid("0ee540ac-e651-45f5-97c7-a908df086e2d"), "darcya@mail.com", false, "Darcy", "Abrams", false, null, "DARCYA@MAIL.COM", "DARCYA", "AQAAAAIAAYagAAAAEJQrDZH+DG8jcc3ARVedaOYmztq3rAvZJ9GmTqOIhLL+aBtYLhMc/5TBrdjvMBxp0g==", null, false, null, false, "DarcyA" },
                    { new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94"), 0, "5ad19fb3-52a5-4481-839d-8082218d9aaf", new Guid("e84fad18-ed54-47cd-aeaf-4c94b513d8bc"), "samj@mail.com", false, "Samuel", "Johnson", false, null, "SAMJ@MAIL.COM", "SAMJ", "AQAAAAIAAYagAAAAEGJNRYGaTJC6XLjVrXUYkKW15LtQPjYjcvVAg5Szzx7fvN/N7Ad0wTursMgP3cmbrQ==", null, false, null, false, "SamJ" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "AssignedToUserId", "CategoryId", "CreatedOn", "CreatorId", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("0039715b-ddf1-4aba-8e7b-9dc2eb1afb68"), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"), new Guid("9c9d0d44-2ab3-4912-8c04-2f2192ed80e1"), new DateTime(2025, 6, 8, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1236), new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94"), "I am unable to connect to the network.", null, 2, 1, "Network issue" },
                    { new Guid("0ca2655c-e434-4e00-a84b-2bff2aa7f765"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), new Guid("c21d907c-a05f-4b7f-b4b2-e989dffb8d2a"), new DateTime(2025, 6, 5, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1246), new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946"), "I need a conference room for a small meeting.", new DateTime(2025, 6, 15, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1246), 1, 0, "Conference room needed" },
                    { new Guid("0d33367f-02f9-4324-be87-30e5f65be109"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), new Guid("34afa6e3-d6d1-42b0-afc4-9a9b5edd278b"), new DateTime(2025, 6, 8, 17, 24, 23, 429, DateTimeKind.Utc).AddTicks(4631), new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94"), "My laptop is not turning on. I need it for work.", new DateTime(2025, 6, 9, 17, 24, 23, 429, DateTimeKind.Utc).AddTicks(4888), 2, 0, "Laptop not working" },
                    { new Guid("2e246a75-e482-415d-adb8-b3b7545ad77c"), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"), new Guid("cfaff174-8b18-46f8-bcb3-87dd2ffec7ad"), new DateTime(2025, 5, 29, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1251), new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94"), "I need to update the software on my laptop.", null, 0, 3, "Software update" },
                    { new Guid("461191ed-d0b0-43e5-982b-426f1b369ba6"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), new Guid("34afa6e3-d6d1-42b0-afc4-9a9b5edd278b"), new DateTime(2025, 6, 8, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1220), new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946"), "My printer is not working. I have a presentation in 3 days and I need it.", new DateTime(2025, 6, 10, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1221), 1, 0, "Printer not working" },
                    { new Guid("4867a566-c6f2-4a77-8222-0daaf53d49a1"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), new Guid("fe9fdc3f-7e82-47f8-a432-76ea5bbfd396"), new DateTime(2025, 6, 8, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1243), new Guid("98bd95e4-71a2-488a-a56d-12245dd7f291"), "I found a security issue in the system.", null, 2, 0, "Security issue" },
                    { new Guid("57579abc-57eb-4594-88a2-cd9d653cbd65"), new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946"), new Guid("98d8e692-4707-475e-b870-92a37f881986"), new DateTime(2025, 5, 24, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1249), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"), "I need HR support for a new employee.", null, 1, 3, "HR support needed" },
                    { new Guid("a296e1e3-57c0-45b9-8e9d-9332cd6bbf1a"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), new Guid("cfaff174-8b18-46f8-bcb3-87dd2ffec7ad"), new DateTime(2025, 6, 8, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1233), new Guid("98bd95e4-71a2-488a-a56d-12245dd7f291"), "I need to install a new software on my laptop.", null, 0, 0, "Software installation" },
                    { new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0"), new Guid("0480d7eb-c544-4058-8b07-c828104189af"), new Guid("c21d907c-a05f-4b7f-b4b2-e989dffb8d2a"), new DateTime(2025, 6, 3, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1269), new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c"), "I need a company car for a business trip for 3 people.", new DateTime(2025, 6, 5, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1270), 1, 2, "Company car needed" },
                    { new Guid("cc9a909d-37f6-4225-8148-9b96264a167b"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885"), new Guid("9c9d0d44-2ab3-4912-8c04-2f2192ed80e1"), new DateTime(2025, 6, 8, 17, 24, 23, 430, DateTimeKind.Utc).AddTicks(1238), new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94"), "I need access to the new software.", null, 1, 0, "Access request" }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "SupportAgent", "true", new Guid("24ebeca2-8cda-4801-a113-725657e7b47a") },
                    { 2, "SupportAgent", "true", new Guid("0480d7eb-c544-4058-8b07-c828104189af") },
                    { 3, "SupportAgent", "true", new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946") },
                    { 4, "SupportAgent", "true", new Guid("291f114d-6be7-4af0-b73f-ee8690597885") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("0480d7eb-c544-4058-8b07-c828104189af") },
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a") },
                    { new Guid("5f439325-7a78-4d47-8e5f-c58787c10b94"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885") },
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("98bd95e4-71a2-488a-a56d-12245dd7f291") },
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c") },
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946") },
                    { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Message", "TicketId" },
                values: new object[,]
                {
                    { new Guid("24c61f63-fd5d-4acd-8eaa-1639a53bbf14"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3364), new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c"), "No, thank you, I have already driven this particular car. Have a great day!", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") },
                    { new Guid("51d38196-9d32-4c8f-a835-e13d920d09c2"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3358), new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c"), "Stan, we will be leaving in two days and we are supposed to return in a day or so.", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") },
                    { new Guid("681e27c5-8fdb-49d2-931c-ca0d8f322975"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(2567), new Guid("0480d7eb-c544-4058-8b07-c828104189af"), "Hello Sandy, we have a Honda Civic and a Toyota 4Runner available. Would you need a large luggage space or will you be travelling light?", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") },
                    { new Guid("73432f43-3b18-40cd-b6df-48411eeaed0c"), new DateTime(2025, 5, 25, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3374), new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946"), "Hello Mary, I have just received your request. I will be contacting you shortly.", new Guid("57579abc-57eb-4594-88a2-cd9d653cbd65") },
                    { new Guid("738b0d6e-0a9d-49eb-b40a-c1140881de5a"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3356), new Guid("0480d7eb-c544-4058-8b07-c828104189af"), "Sandy, based on your luggage size I would reccoment you to take the Toyota 4Runner. When are you supposed to leave and return?", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") },
                    { new Guid("787b1fce-2a40-4090-9a0c-948d0a295237"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3353), new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c"), "Hello Stan, we will be travelling with a total of 3 carry-on luggages, as well as one large suitcase.", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") },
                    { new Guid("8a9a9810-cf14-4952-a885-90f3caaf30a2"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3366), new Guid("0480d7eb-c544-4058-8b07-c828104189af"), "You're welcome. Don't hesitate to contact me if you have any questions or need more assistance. Good day to you, too!", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") },
                    { new Guid("947c5db9-5773-4730-a026-924f67394160"), new DateTime(2025, 5, 25, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3444), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"), "Hello Darcy, thank you for your prompt response. I will be waiting for your contact.", new Guid("57579abc-57eb-4594-88a2-cd9d653cbd65") },
                    { new Guid("bbde4056-0b8c-42fa-b6ec-72e27d568096"), new DateTime(2025, 6, 8, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3447), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"), "Hello Sam, please restart your device and wait for further instructions. I will contact you in several minutes.", new Guid("cc9a909d-37f6-4225-8148-9b96264a167b") },
                    { new Guid("c2e2b02c-fad2-4218-be20-4c4c87a84a1a"), new DateTime(2025, 6, 4, 17, 24, 23, 431, DateTimeKind.Utc).AddTicks(3360), new Guid("0480d7eb-c544-4058-8b07-c828104189af"), "Okay, Sandy, I will contact you as soon as the car is ready. Will you be needing further instructions for operating the vehicle?", new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("24c61f63-fd5d-4acd-8eaa-1639a53bbf14"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("51d38196-9d32-4c8f-a835-e13d920d09c2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("681e27c5-8fdb-49d2-931c-ca0d8f322975"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("73432f43-3b18-40cd-b6df-48411eeaed0c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("738b0d6e-0a9d-49eb-b40a-c1140881de5a"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("787b1fce-2a40-4090-9a0c-948d0a295237"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("8a9a9810-cf14-4952-a885-90f3caaf30a2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("947c5db9-5773-4730-a026-924f67394160"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("bbde4056-0b8c-42fa-b6ec-72e27d568096"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c2e2b02c-fad2-4218-be20-4c4c87a84a1a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0039715b-ddf1-4aba-8e7b-9dc2eb1afb68"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0ca2655c-e434-4e00-a84b-2bff2aa7f765"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0d33367f-02f9-4324-be87-30e5f65be109"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("2e246a75-e482-415d-adb8-b3b7545ad77c"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("461191ed-d0b0-43e5-982b-426f1b369ba6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("4867a566-c6f2-4a77-8222-0daaf53d49a1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a296e1e3-57c0-45b9-8e9d-9332cd6bbf1a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("0480d7eb-c544-4058-8b07-c828104189af") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("24ebeca2-8cda-4801-a113-725657e7b47a") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5f439325-7a78-4d47-8e5f-c58787c10b94"), new Guid("291f114d-6be7-4af0-b73f-ee8690597885") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("98bd95e4-71a2-488a-a56d-12245dd7f291") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"), new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("34afa6e3-d6d1-42b0-afc4-9a9b5edd278b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cfaff174-8b18-46f8-bcb3-87dd2ffec7ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe9fdc3f-7e82-47f8-a432-76ea5bbfd396"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5f439325-7a78-4d47-8e5f-c58787c10b94"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d5553e44-17ed-4ce2-808f-8d5f02a4ad18"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("57579abc-57eb-4594-88a2-cd9d653cbd65"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b5f59953-c062-4e40-bbde-c5263ad61fa0"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("cc9a909d-37f6-4225-8148-9b96264a167b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("98bd95e4-71a2-488a-a56d-12245dd7f291"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("98d8e692-4707-475e-b870-92a37f881986"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9c9d0d44-2ab3-4912-8c04-2f2192ed80e1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c21d907c-a05f-4b7f-b4b2-e989dffb8d2a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cc6a4f78-4c15-41e3-ae61-a6420f6de8cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0480d7eb-c544-4058-8b07-c828104189af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("24ebeca2-8cda-4801-a113-725657e7b47a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("291f114d-6be7-4af0-b73f-ee8690597885"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b87a7720-d1f8-4160-8a3c-6c2922bb8946"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0ee540ac-e651-45f5-97c7-a908df086e2d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2cd02069-2cb2-4b58-8cc5-58538f4480cb"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c3f276a1-35a7-4b50-bfbc-373f706d5cd5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e84fad18-ed54-47cd-aeaf-4c94b513d8bc"));
        }
    }
}
