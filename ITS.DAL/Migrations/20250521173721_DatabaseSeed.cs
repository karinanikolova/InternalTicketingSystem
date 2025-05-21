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
                    { new Guid("0e5a49d6-a85e-4360-b108-d87b548b7c29"), "Facilities" },
                    { new Guid("350d8c0e-136a-4e69-9dd1-0565739107b9"), "Hardware" },
                    { new Guid("4c27736d-e075-4e27-9127-46005e712d86"), "Security" },
                    { new Guid("5639a07f-2dfe-43aa-9092-39d4a31723a4"), "Network & Access Request" },
                    { new Guid("6054ce04-e0ff-4f37-accb-f6b18760ad49"), "HR" },
                    { new Guid("cd6788f9-2738-4795-ae67-21e46d812768"), "Software" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0cd5a2c3-37dd-4c32-8fe5-94b781728e13"), "IT & Security" },
                    { new Guid("12757374-5465-4725-b132-436e31bab030"), "Facilities" },
                    { new Guid("60728fee-1021-44e5-9dde-59d82e334397"), "Human Resources" },
                    { new Guid("6fcb7fc7-cac3-43bf-ad1c-67be80208437"), "Engineering & Development" },
                    { new Guid("b87a947d-8700-4bcd-b674-c459332b0076"), "Quality Assurance" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("20bfdb73-43e9-4442-a293-4774b05b5239"), null, "Employee", "EMPLOYEE" },
                    { new Guid("93565863-5f33-4e14-9f8f-ffa20ec6c4a6"), null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"), 0, "eaedf7b9-c3b4-4566-bbf4-981221a97bcd", new Guid("0cd5a2c3-37dd-4c32-8fe5-94b781728e13"), "maryc@mail.com", false, "Mary", "Cooper", false, null, "MARYC@MAIL.COM", "MARYC", "AQAAAAIAAYagAAAAELbDAj/F/7Xy+VGw0SkNZifbCkA2ReU5KPQeQiEZDeVKreHQdK0417clsoetIUk7lw==", null, false, null, false, "MaryC" },
                    { new Guid("4ce1b44e-b99e-4c98-8948-1643bb09ba35"), 0, "51dd2f83-0abb-4133-9061-18a6acd70aa5", new Guid("b87a947d-8700-4bcd-b674-c459332b0076"), "mlevin@mail.com", false, "Mark", "Levin", false, null, "MLEVIN@MAIL.COM", "MLEVIN", "AQAAAAIAAYagAAAAEMe9T8wBoeqHKGyCYN4CgVGgqay2jE0YQNH3gitPfXFs+JslFSd+nCeJWBXDorDhQQ==", null, false, null, false, "MLevin" },
                    { new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"), 0, "b970f4a5-a560-4d38-b92f-6df23ce2416a", new Guid("60728fee-1021-44e5-9dde-59d82e334397"), "darcya@mail.com", false, "Darcy", "Abrams", false, null, "DARCYA@MAIL.COM", "DARCYA", "AQAAAAIAAYagAAAAED5AaFx8OWMokOQRKwDN4yMwdTxodJ9Is14kf5i+o3VGPK10Uv2lgPY7f7Nj2vLFeQ==", null, false, null, false, "DarcyA" },
                    { new Guid("a4890fae-6461-4f73-a6a1-8072c74ba24b"), 0, "757c19a8-9145-41ef-be46-cc00340fc51e", new Guid("6fcb7fc7-cac3-43bf-ad1c-67be80208437"), "samj@mail.com", false, "Samuel", "Johnson", false, null, "SAMJ@MAIL.COM", "SAMJ", "AQAAAAIAAYagAAAAEIi/60zvxjbUlXkvDlZKY/4rv/zq84h+5n+09+8ySYTE0cMhy3S0IuRQYB/oj6a41A==", null, false, null, false, "SamJ" },
                    { new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), 0, "7460c0f1-fdcf-4932-8bfa-c46821b6e812", new Guid("0cd5a2c3-37dd-4c32-8fe5-94b781728e13"), "admin@mail.com", false, "Garry", "Francis", false, null, "ADMIN@MAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAENxM9b/voBN3fh9v3l9bHT2BSkZ04U52OVvEK8+sBjPZnrAxCdeEsGeaKdvHErST3g==", null, false, null, false, "AdminUser" },
                    { new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"), 0, "accf528b-280c-4a7e-b1d2-9a37f35118c9", new Guid("12757374-5465-4725-b132-436e31bab030"), "stanleym@mail.com", false, "Stanley", "Morgan", false, null, "STANLEYM@MAIL.COM", "STANM", "AQAAAAIAAYagAAAAEOtJKxQReoPeag5VrXaeV64cQsMo9IOkk0LWZWizp2zuFUA/xRrh9WOF1Jimu4qxMg==", null, false, null, false, "StanM" },
                    { new Guid("ed77f9d2-186b-4022-aabf-9788a17f9b1c"), 0, "0a3f3282-8f35-4a7c-9ae6-5a198fbcd39f", new Guid("60728fee-1021-44e5-9dde-59d82e334397"), "sandyb@mail.com", false, "Sandy", "Brown", false, null, "SANDYB@MAIL.COM", "SANDYB", "AQAAAAIAAYagAAAAEO3030rTf7OeEiT2q0zAnq0+5zKt/JgXZeFiXDdB+yDGR/7xKWRUh2kbau0C8eg/QA==", null, false, null, false, "SandyB" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "AssignedToUserId", "CategoryId", "CreatedOn", "CreatorId", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("090fde6c-4f28-4c9f-9368-78153c7f7729"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), new Guid("cd6788f9-2738-4795-ae67-21e46d812768"), new DateTime(2025, 5, 21, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7172), new Guid("4ce1b44e-b99e-4c98-8948-1643bb09ba35"), "I need to install a new software on my laptop.", null, 0, 0, "Software installation" },
                    { new Guid("12a731cc-8d86-46ad-acca-e177ea969d8f"), new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"), new Guid("5639a07f-2dfe-43aa-9092-39d4a31723a4"), new DateTime(2025, 5, 21, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7175), new Guid("a4890fae-6461-4f73-a6a1-8072c74ba24b"), "I am unable to connect to the network.", null, 2, 1, "Network issue" },
                    { new Guid("3c54ce28-3de8-49ed-8611-4ecc26b5e8fa"), new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"), new Guid("cd6788f9-2738-4795-ae67-21e46d812768"), new DateTime(2025, 5, 11, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7189), new Guid("a4890fae-6461-4f73-a6a1-8072c74ba24b"), "I need to update the software on my laptop.", null, 0, 3, "Software update" },
                    { new Guid("410f738e-b133-4878-8a50-bee63ef6abea"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), new Guid("350d8c0e-136a-4e69-9dd1-0565739107b9"), new DateTime(2025, 5, 21, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7154), new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"), "My printer is not working. I have a presentation in 3 days and I need it.", new DateTime(2025, 5, 23, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7154), 1, 0, "Printer not working" },
                    { new Guid("4c6600ec-1e69-4572-9819-d21b155e2956"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), new Guid("5639a07f-2dfe-43aa-9092-39d4a31723a4"), new DateTime(2025, 5, 21, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7177), new Guid("a4890fae-6461-4f73-a6a1-8072c74ba24b"), "I need access to the new software.", null, 1, 0, "Access request" },
                    { new Guid("5d7b0cab-bb34-4ce7-88f2-389bb606cd21"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), new Guid("4c27736d-e075-4e27-9127-46005e712d86"), new DateTime(2025, 5, 21, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7181), new Guid("4ce1b44e-b99e-4c98-8948-1643bb09ba35"), "I found a security issue in the system.", null, 2, 0, "Security issue" },
                    { new Guid("94a8fb3c-6847-4ee8-bdf8-c0b7a3d03f0a"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), new Guid("350d8c0e-136a-4e69-9dd1-0565739107b9"), new DateTime(2025, 5, 21, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(6125), new Guid("a4890fae-6461-4f73-a6a1-8072c74ba24b"), "My laptop is not turning on. I need it for work.", new DateTime(2025, 5, 22, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(6348), 2, 0, "Laptop not working" },
                    { new Guid("b0940a17-f6a7-47aa-84f3-bc357eb9b7c7"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"), new Guid("0e5a49d6-a85e-4360-b108-d87b548b7c29"), new DateTime(2025, 5, 18, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7184), new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"), "I need a conference room for a small meeting.", new DateTime(2025, 5, 28, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7185), 1, 0, "Conference room needed" },
                    { new Guid("efe3136f-039e-4ccc-85d4-bcbafa335a4a"), new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"), new Guid("6054ce04-e0ff-4f37-accb-f6b18760ad49"), new DateTime(2025, 5, 6, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7187), new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"), "I need HR support for a new employee.", null, 1, 3, "HR support needed" },
                    { new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76"), new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"), new Guid("0e5a49d6-a85e-4360-b108-d87b548b7c29"), new DateTime(2025, 5, 16, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7193), new Guid("ed77f9d2-186b-4022-aabf-9788a17f9b1c"), "I need a company car for a business trip for 3 people.", new DateTime(2025, 5, 18, 17, 37, 20, 823, DateTimeKind.Utc).AddTicks(7193), 1, 2, "Company car needed" }
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "SupportAgent", "true", new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b") },
                    { 2, "SupportAgent", "true", new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb") },
                    { 3, "SupportAgent", "true", new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693") },
                    { 4, "SupportAgent", "true", new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("93565863-5f33-4e14-9f8f-ffa20ec6c4a6"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd") });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Message", "TicketId" },
                values: new object[,]
                {
                    { new Guid("027e6256-1eb2-4505-a4e5-a21242672e92"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7837), new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"), "You're welcome. Don't hesitate to contact me if you have any questions or need more assistance. Good day to you, too!", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("073da5fd-5ef6-4b64-b185-283fb5c15be5"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7823), new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"), "Sandy, based on your luggage size I would reccoment you to take the Toyota 4Runner. When are you supposed to leave and return?", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("3fbfabec-afdf-4983-bd48-294c1818092d"), new DateTime(2025, 5, 7, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7839), new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"), "Hello Mary, I have just received your request. I will be contacting you shortly.", new Guid("efe3136f-039e-4ccc-85d4-bcbafa335a4a") },
                    { new Guid("4579286d-879b-4f07-9f2d-f623573f7c1d"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7152), new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"), "Hello Sandy, we have a Honda Civic and a Toyota 4Runner available. Would you need a large luggage space or will you be travelling light?", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("7823a93b-aac4-43a2-9219-b426f788d14b"), new DateTime(2025, 5, 21, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7849), new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"), "Hello Sam, please restart your device and wait for further instructions. I will contact you in several minutes.", new Guid("4c6600ec-1e69-4572-9819-d21b155e2956") },
                    { new Guid("a7ffac77-1b7d-4da1-861b-e22afcba6e30"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7830), new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"), "Okay, Sandy, I will contact you as soon as the car is ready. Will you be needing further instructions for operating the vehicle?", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("b3861be2-c37e-494f-95a5-36c22c18acb8"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7813), new Guid("ed77f9d2-186b-4022-aabf-9788a17f9b1c"), "Hello Stan, we will be travelling with a total of 3 carry-on luggages, as well as one large suitcase.", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("ba11cf23-1f99-4e68-a454-53fc48c84d71"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7835), new Guid("ed77f9d2-186b-4022-aabf-9788a17f9b1c"), "No, thank you, I have already driven this particular car. Have a great day!", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("c135d88b-d73e-4ead-bc7a-b6975afe8b2f"), new DateTime(2025, 5, 17, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7828), new Guid("ed77f9d2-186b-4022-aabf-9788a17f9b1c"), "Stan, we will be leaving in two days and we are supposed to return in a day or so.", new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76") },
                    { new Guid("ed3014b9-9bae-4c14-8958-7323a76bde3e"), new DateTime(2025, 5, 7, 17, 37, 20, 824, DateTimeKind.Utc).AddTicks(7846), new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"), "Hello Darcy, thank you for your prompt response. I will be waiting for your contact.", new Guid("efe3136f-039e-4ccc-85d4-bcbafa335a4a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("027e6256-1eb2-4505-a4e5-a21242672e92"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("073da5fd-5ef6-4b64-b185-283fb5c15be5"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("3fbfabec-afdf-4983-bd48-294c1818092d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("4579286d-879b-4f07-9f2d-f623573f7c1d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("7823a93b-aac4-43a2-9219-b426f788d14b"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a7ffac77-1b7d-4da1-861b-e22afcba6e30"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b3861be2-c37e-494f-95a5-36c22c18acb8"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ba11cf23-1f99-4e68-a454-53fc48c84d71"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c135d88b-d73e-4ead-bc7a-b6975afe8b2f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ed3014b9-9bae-4c14-8958-7323a76bde3e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20bfdb73-43e9-4442-a293-4774b05b5239"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("090fde6c-4f28-4c9f-9368-78153c7f7729"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("12a731cc-8d86-46ad-acca-e177ea969d8f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("3c54ce28-3de8-49ed-8611-4ecc26b5e8fa"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("410f738e-b133-4878-8a50-bee63ef6abea"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("5d7b0cab-bb34-4ce7-88f2-389bb606cd21"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("94a8fb3c-6847-4ee8-bdf8-c0b7a3d03f0a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b0940a17-f6a7-47aa-84f3-bc357eb9b7c7"));

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
                keyValues: new object[] { new Guid("93565863-5f33-4e14-9f8f-ffa20ec6c4a6"), new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("350d8c0e-136a-4e69-9dd1-0565739107b9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c27736d-e075-4e27-9127-46005e712d86"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd6788f9-2738-4795-ae67-21e46d812768"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("93565863-5f33-4e14-9f8f-ffa20ec6c4a6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("4c6600ec-1e69-4572-9819-d21b155e2956"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("efe3136f-039e-4ccc-85d4-bcbafa335a4a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("f50a4a3a-2c17-4001-8d61-7c06ce1cea76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4ce1b44e-b99e-4c98-8948-1643bb09ba35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e5a49d6-a85e-4360-b108-d87b548b7c29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5639a07f-2dfe-43aa-9092-39d4a31723a4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6054ce04-e0ff-4f37-accb-f6b18760ad49"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b87a947d-8700-4bcd-b674-c459332b0076"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a4890fae-6461-4f73-a6a1-8072c74ba24b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ed77f9d2-186b-4022-aabf-9788a17f9b1c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0cd5a2c3-37dd-4c32-8fe5-94b781728e13"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("12757374-5465-4725-b132-436e31bab030"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("60728fee-1021-44e5-9dde-59d82e334397"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6fcb7fc7-cac3-43bf-ad1c-67be80208437"));
        }
    }
}
