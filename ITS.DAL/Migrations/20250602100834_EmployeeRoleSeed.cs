using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("1a53f44a-1f1d-41cc-8964-c757943fb084"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("20340d4e-ce5a-457b-bb64-7b3dd79543d0"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("23eff7e6-1a19-4f8e-b319-19cc0b0ed2d6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("27145fee-a563-48a9-a071-df55f5058a57"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("442bf548-2bfc-4e7b-9db4-7c8584c80d4e"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6de041ad-a28e-4ee2-ab71-dd0c8d1b9566"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("781819af-deb7-4efe-9da3-1d2e30b4b559"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("93dca21a-5bd6-46a4-8e85-693bc3d18712"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b0d1e9f2-6c8d-4b61-8451-2842eaeb7341"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("c541d904-d20f-4b36-81fd-60aaf95b6905"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("df6c1eef-5e87-448b-a123-68ef7ed568c1"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("05772994-8e9d-4dd9-89ab-3af31525bee9"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("3f68d665-78f1-4913-b86a-14fbc6320e44"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("662951ec-01fb-4702-b327-c82321b001da"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8b969b26-8719-45fd-b698-6cb7adc88c27"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("b344f46c-3fb0-4ed7-9510-b90280fb3866"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("c5cf35e2-8ef9-4da3-84b9-98955f3b12b5"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("d7c5e601-71a8-4dfa-9157-302468373179"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("22b3a385-dd4e-4d86-836e-2909f1add421"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c72716ef-fb8e-4355-b653-a4ec6a41cb36"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8716d5b-b764-42fa-8830-5f8d98ec5a65"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdf9c1f4-58a8-41d2-8687-f1819fec2d8a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("22b3a385-dd4e-4d86-836e-2909f1add421"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("87e3cba6-a0cd-4ab3-9b11-306507c6c6cb"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("c019231d-b05e-49e0-a8bb-2a85c6355bdf"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c69f3217-12e3-45ce-b5f8-84ebf4fcd77f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("077afb68-01e2-4ca2-ba80-cb53a34e6904"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("192d6dd7-c8ee-4df0-9d24-acaa766fa556"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7160fdfa-f038-4743-b23f-543b4c1a4786"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("37a90661-82aa-44a5-b267-079d36832bdb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("65c01962-0033-452e-87f7-ee2f7db4ac42"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f2310846-a216-40d2-bb35-fe7492b82718"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("928c2995-b16b-40c8-b77d-dd18d8525f28"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac0b620f-da33-4ea7-8425-f3ad0d9d6789"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("afc6278b-748f-4546-bcb9-2e1b43f402dd"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f3021af9-370e-4766-bb64-fed4b1fdff8e"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d0cceee-727e-4c22-8b35-2e19692afe14"), "Security" },
                    { new Guid("8bdcf1fa-cfd6-4be9-bd0d-309a90b318bc"), "Software" },
                    { new Guid("8fccfe2d-5666-4179-905d-be741c6a82db"), "Network & Access Request" },
                    { new Guid("aca05d8b-6d87-44b6-8cc1-7aeb57a95104"), "HR" },
                    { new Guid("ba917995-a14b-42ac-be6b-b9e9457a63d2"), "Hardware" },
                    { new Guid("ec2ae63e-613e-4201-be3b-d0688a57c5d2"), "Facilities" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c351ab8-4e95-419e-9072-33a9b1f3b544"), "Human Resources" },
                    { new Guid("3d90f217-af56-4d20-8e7a-c9629b37c878"), "Quality Assurance" },
                    { new Guid("cf9a3046-af6d-4874-91ef-efb436aa06a4"), "IT & Security" },
                    { new Guid("d43760a0-ed19-4c32-a889-5836e7d21609"), "Engineering & Development" },
                    { new Guid("f5670143-f71e-4822-9a13-2e9b4c8a59a3"), "Facilities" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("912a7db8-3432-4d23-a135-f0f0bd75eda0"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"), 0, "c4f53aa8-cede-4fcb-b468-1d3d73c9b6b9", new Guid("f5670143-f71e-4822-9a13-2e9b4c8a59a3"), "stanleym@mail.com", false, "Stanley", "Morgan", false, null, "STANLEYM@MAIL.COM", "STANM", "AQAAAAIAAYagAAAAEB3vGEBhXvQAh57U1vGET+Mjry1+bWjy4taip5Vbkw8fjNUOoY/gkUDWyHXrLyfGNw==", null, false, null, false, "StanM" },
                    { new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89"), 0, "1916fbfe-7e88-4aa6-8a26-a12d4b9fb07b", new Guid("0c351ab8-4e95-419e-9072-33a9b1f3b544"), "sandyb@mail.com", false, "Sandy", "Brown", false, null, "SANDYB@MAIL.COM", "SANDYB", "AQAAAAIAAYagAAAAED38yagkH8mXcG+bJ0d8a2z9/KBCt0RBjJwYL7F6US1CUqwA6MQe1GDpYjI0Fex43Q==", null, false, null, false, "SandyB" },
                    { new Guid("2fe45266-224f-4b65-86e8-6622b85911e3"), 0, "c57b6456-d20f-47ac-bc6e-881eb13e8440", new Guid("3d90f217-af56-4d20-8e7a-c9629b37c878"), "mlevin@mail.com", false, "Mark", "Levin", false, null, "MLEVIN@MAIL.COM", "MLEVIN", "AQAAAAIAAYagAAAAEFcrtHP3EGZlKn+eSMK0Rg0Hs8zTGax2o5iGTQsWHSCwqeHMWQfVx1tEDMVeNo6mVA==", null, false, null, false, "MLevin" },
                    { new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"), 0, "268ec38a-8453-43a1-ad82-d3b4422e49e6", new Guid("0c351ab8-4e95-419e-9072-33a9b1f3b544"), "darcya@mail.com", false, "Darcy", "Abrams", false, null, "DARCYA@MAIL.COM", "DARCYA", "AQAAAAIAAYagAAAAELijkJCKQM27f8eR74+hbELaQIlWHN6uiQtvBXR/fCs+Kp/cRwl09rS3S9NQkmEc/w==", null, false, null, false, "DarcyA" },
                    { new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), 0, "ad724dd2-c6e2-44d4-bd58-33ac62a8100a", new Guid("cf9a3046-af6d-4874-91ef-efb436aa06a4"), "admin@mail.com", false, "Garry", "Francis", false, null, "ADMIN@MAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAENk/6X1WFu7HGCt/EB6vq6whaeQz9jYOqWywhnBEm58ASVEXOlZUOlkNZ2+kyVDZxw==", null, false, null, false, "AdminUser" },
                    { new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf"), 0, "8ca977e4-db86-42f2-b881-8ebaa958a22b", new Guid("d43760a0-ed19-4c32-a889-5836e7d21609"), "samj@mail.com", false, "Samuel", "Johnson", false, null, "SAMJ@MAIL.COM", "SAMJ", "AQAAAAIAAYagAAAAEAjhtt7/j1C4DqwnSVLPTGzo3I2jkjWXXp5iqCsUjUx7ug7mZeneIEe+SaNWp4N9VQ==", null, false, null, false, "SamJ" },
                    { new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"), 0, "31a738e3-1f86-4628-9161-d75ec24b8aaf", new Guid("cf9a3046-af6d-4874-91ef-efb436aa06a4"), "maryc@mail.com", false, "Mary", "Cooper", false, null, "MARYC@MAIL.COM", "MARYC", "AQAAAAIAAYagAAAAENvFTDsYJObqCK4bhx2n3F0HirQ+y+C++zFqIuPnNReNFF+iMxVlt8hbeNpeleHCxw==", null, false, null, false, "MaryC" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "AssignedToUserId", "CategoryId", "CreatedOn", "CreatorId", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("022988c5-451e-48c4-b925-f6f886d83101"), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"), new Guid("8bdcf1fa-cfd6-4be9-bd0d-309a90b318bc"), new DateTime(2025, 5, 23, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9869), new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf"), "I need to update the software on my laptop.", null, 0, 3, "Software update" },
                    { new Guid("14ed201e-03d9-486a-a9e8-447ad05f0230"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), new Guid("3d0cceee-727e-4c22-8b35-2e19692afe14"), new DateTime(2025, 6, 2, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9765), new Guid("2fe45266-224f-4b65-86e8-6622b85911e3"), "I found a security issue in the system.", null, 2, 0, "Security issue" },
                    { new Guid("295a08f7-3b53-4dda-998e-e97fc4a87d85"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), new Guid("ba917995-a14b-42ac-be6b-b9e9457a63d2"), new DateTime(2025, 6, 2, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(8684), new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf"), "My laptop is not turning on. I need it for work.", new DateTime(2025, 6, 3, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(8911), 2, 0, "Laptop not working" },
                    { new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f"), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"), new Guid("ec2ae63e-613e-4201-be3b-d0688a57c5d2"), new DateTime(2025, 5, 28, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9884), new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89"), "I need a company car for a business trip for 3 people.", new DateTime(2025, 5, 30, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9884), 1, 2, "Company car needed" },
                    { new Guid("57b89f98-e672-4dba-9e85-206d793e80e6"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), new Guid("ec2ae63e-613e-4201-be3b-d0688a57c5d2"), new DateTime(2025, 5, 30, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9862), new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"), "I need a conference room for a small meeting.", new DateTime(2025, 6, 9, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9863), 1, 0, "Conference room needed" },
                    { new Guid("5c8c6467-4109-465d-95fa-8715edb04b79"), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"), new Guid("8fccfe2d-5666-4179-905d-be741c6a82db"), new DateTime(2025, 6, 2, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9758), new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf"), "I am unable to connect to the network.", null, 2, 1, "Network issue" },
                    { new Guid("8df812b7-f7c7-42cb-879f-229e27e2947b"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), new Guid("8fccfe2d-5666-4179-905d-be741c6a82db"), new DateTime(2025, 6, 2, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9760), new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf"), "I need access to the new software.", null, 1, 0, "Access request" },
                    { new Guid("a9a75aec-728f-4487-a68d-c8083df9f707"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), new Guid("ba917995-a14b-42ac-be6b-b9e9457a63d2"), new DateTime(2025, 6, 2, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9746), new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"), "My printer is not working. I have a presentation in 3 days and I need it.", new DateTime(2025, 6, 4, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9747), 1, 0, "Printer not working" },
                    { new Guid("c5e6ddc7-2c41-4350-8b2a-277a4853c110"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"), new Guid("8bdcf1fa-cfd6-4be9-bd0d-309a90b318bc"), new DateTime(2025, 6, 2, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9755), new Guid("2fe45266-224f-4b65-86e8-6622b85911e3"), "I need to install a new software on my laptop.", null, 0, 0, "Software installation" },
                    { new Guid("f6e3699f-ab52-4771-a6f4-b715819bb289"), new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"), new Guid("aca05d8b-6d87-44b6-8cc1-7aeb57a95104"), new DateTime(2025, 5, 18, 10, 8, 32, 163, DateTimeKind.Utc).AddTicks(9866), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"), "I need HR support for a new employee.", null, 1, 3, "HR support needed" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e") },
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89") },
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("2fe45266-224f-4b65-86e8-6622b85911e3") },
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("4087710f-eed3-450a-b563-1e4d28d7d170") },
                    { new Guid("912a7db8-3432-4d23-a135-f0f0bd75eda0"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0") },
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf") },
                    { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874") }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Message", "TicketId" },
                values: new object[,]
                {
                    { new Guid("09f55fdb-2415-4c13-9eb7-b7c5f0b0da56"), new DateTime(2025, 5, 29, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(105), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"), "Okay, Sandy, I will contact you as soon as the car is ready. Will you be needing further instructions for operating the vehicle?", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") },
                    { new Guid("11c9a28b-4f33-4fa0-994f-384f68ef1e40"), new DateTime(2025, 5, 29, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(98), new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89"), "Stan, we will be leaving in two days and we are supposed to return in a day or so.", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") },
                    { new Guid("216f1e0a-85f7-4cae-ac56-a026d683ce7f"), new DateTime(2025, 6, 2, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(118), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"), "Hello Sam, please restart your device and wait for further instructions. I will contact you in several minutes.", new Guid("8df812b7-f7c7-42cb-879f-229e27e2947b") },
                    { new Guid("287fff3c-353c-4edd-bd68-c92aa18895b7"), new DateTime(2025, 5, 19, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(116), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"), "Hello Darcy, thank you for your prompt response. I will be waiting for your contact.", new Guid("f6e3699f-ab52-4771-a6f4-b715819bb289") },
                    { new Guid("39cd734b-a39c-4a84-946a-be39f59b33b9"), new DateTime(2025, 5, 19, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(114), new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"), "Hello Mary, I have just received your request. I will be contacting you shortly.", new Guid("f6e3699f-ab52-4771-a6f4-b715819bb289") },
                    { new Guid("9b794843-3189-4e19-bf19-39f4bea1b178"), new DateTime(2025, 5, 29, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(110), new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89"), "No, thank you, I have already driven this particular car. Have a great day!", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") },
                    { new Guid("a3374df4-3a0b-4499-bcd9-25d3f39b47df"), new DateTime(2025, 5, 29, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(96), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"), "Sandy, based on your luggage size I would reccoment you to take the Toyota 4Runner. When are you supposed to leave and return?", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") },
                    { new Guid("b527af42-fdf4-4d71-b07a-8c4e7b079721"), new DateTime(2025, 5, 29, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(112), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"), "You're welcome. Don't hesitate to contact me if you have any questions or need more assistance. Good day to you, too!", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") },
                    { new Guid("b867d0c1-371d-4392-9f81-9a788d6c8466"), new DateTime(2025, 5, 29, 10, 8, 32, 164, DateTimeKind.Utc).AddTicks(9425), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"), "Hello Sandy, we have a Honda Civic and a Toyota 4Runner available. Would you need a large luggage space or will you be travelling light?", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") },
                    { new Guid("ff340ede-5cda-47e6-9cae-0bfbc0f6831d"), new DateTime(2025, 5, 29, 10, 8, 32, 165, DateTimeKind.Utc).AddTicks(92), new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89"), "Hello Stan, we will be travelling with a total of 3 carry-on luggages, as well as one large suitcase.", new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("09f55fdb-2415-4c13-9eb7-b7c5f0b0da56"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("11c9a28b-4f33-4fa0-994f-384f68ef1e40"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("216f1e0a-85f7-4cae-ac56-a026d683ce7f"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("287fff3c-353c-4edd-bd68-c92aa18895b7"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("39cd734b-a39c-4a84-946a-be39f59b33b9"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("9b794843-3189-4e19-bf19-39f4bea1b178"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("a3374df4-3a0b-4499-bcd9-25d3f39b47df"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b527af42-fdf4-4d71-b07a-8c4e7b079721"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("b867d0c1-371d-4392-9f81-9a788d6c8466"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("ff340ede-5cda-47e6-9cae-0bfbc0f6831d"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("022988c5-451e-48c4-b925-f6f886d83101"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("14ed201e-03d9-486a-a9e8-447ad05f0230"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("295a08f7-3b53-4dda-998e-e97fc4a87d85"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("57b89f98-e672-4dba-9e85-206d793e80e6"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("5c8c6467-4109-465d-95fa-8715edb04b79"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a9a75aec-728f-4487-a68d-c8083df9f707"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("c5e6ddc7-2c41-4350-8b2a-277a4853c110"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("2fe45266-224f-4b65-86e8-6622b85911e3") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("4087710f-eed3-450a-b563-1e4d28d7d170") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("912a7db8-3432-4d23-a135-f0f0bd75eda0"), new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"), new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3d0cceee-727e-4c22-8b35-2e19692afe14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bdcf1fa-cfd6-4be9-bd0d-309a90b318bc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ba917995-a14b-42ac-be6b-b9e9457a63d2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("912a7db8-3432-4d23-a135-f0f0bd75eda0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("af33fb95-252c-4d75-8822-90dda032d0ce"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("4d284d7a-f3bc-441c-b2a3-9161011fed1f"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("8df812b7-f7c7-42cb-879f-229e27e2947b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("f6e3699f-ab52-4771-a6f4-b715819bb289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2fe45266-224f-4b65-86e8-6622b85911e3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fccfe2d-5666-4179-905d-be741c6a82db"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aca05d8b-6d87-44b6-8cc1-7aeb57a95104"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec2ae63e-613e-4201-be3b-d0688a57c5d2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3d90f217-af56-4d20-8e7a-c9629b37c878"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fc59888-843b-439a-a44e-aaebfdff5c6e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f799af8-c4b1-4218-bbae-aa08d63d4b89"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4087710f-eed3-450a-b563-1e4d28d7d170"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5625e59c-9619-4bbd-87b6-db41cb4eaae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7e587c66-2893-46b4-a1e3-dc4e109c8bdf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9bbebed4-07e9-47bc-a6c7-95faed3ec874"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0c351ab8-4e95-419e-9072-33a9b1f3b544"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("cf9a3046-af6d-4874-91ef-efb436aa06a4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d43760a0-ed19-4c32-a889-5836e7d21609"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f5670143-f71e-4822-9a13-2e9b4c8a59a3"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("077afb68-01e2-4ca2-ba80-cb53a34e6904"), "Facilities" },
                    { new Guid("192d6dd7-c8ee-4df0-9d24-acaa766fa556"), "HR" },
                    { new Guid("7160fdfa-f038-4743-b23f-543b4c1a4786"), "Network & Access Request" },
                    { new Guid("c72716ef-fb8e-4355-b653-a4ec6a41cb36"), "Hardware" },
                    { new Guid("c8716d5b-b764-42fa-8830-5f8d98ec5a65"), "Security" },
                    { new Guid("fdf9c1f4-58a8-41d2-8687-f1819fec2d8a"), "Software" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("37a90661-82aa-44a5-b267-079d36832bdb"), "Quality Assurance" },
                    { new Guid("928c2995-b16b-40c8-b77d-dd18d8525f28"), "Engineering & Development" },
                    { new Guid("ac0b620f-da33-4ea7-8425-f3ad0d9d6789"), "IT & Security" },
                    { new Guid("afc6278b-748f-4546-bcb9-2e1b43f402dd"), "Facilities" },
                    { new Guid("f3021af9-370e-4766-bb64-fed4b1fdff8e"), "Human Resources" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("22b3a385-dd4e-4d86-836e-2909f1add421"), null, "Administrator", "ADMINISTRATOR" },
                    { new Guid("df6c1eef-5e87-448b-a123-68ef7ed568c1"), null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), 0, "f4b8d02b-2224-43e9-9992-77d296d6ed3a", new Guid("ac0b620f-da33-4ea7-8425-f3ad0d9d6789"), "admin@mail.com", false, "Garry", "Francis", false, null, "ADMIN@MAIL.COM", "ADMINUSER", "AQAAAAIAAYagAAAAEE6F1EfyOu32U3PsU7s+XRMPCo6n9gesWvidGhMC2W7ZY8s4yhiZ24+toayF6ITBvw==", null, false, null, false, "AdminUser" },
                    { new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"), 0, "228fff85-b91e-4bd9-8a93-e9f45ce529b9", new Guid("afc6278b-748f-4546-bcb9-2e1b43f402dd"), "stanleym@mail.com", false, "Stanley", "Morgan", false, null, "STANLEYM@MAIL.COM", "STANM", "AQAAAAIAAYagAAAAEFIwQebW2ouQjU8TY2ZSiwmLXj8aUuNt2Sh0R3Bl0t6BQiJWYPhsVvByD7Ln9RPP0Q==", null, false, null, false, "StanM" },
                    { new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"), 0, "1fdd065c-9b82-4f30-8118-34791afb6a12", new Guid("f3021af9-370e-4766-bb64-fed4b1fdff8e"), "darcya@mail.com", false, "Darcy", "Abrams", false, null, "DARCYA@MAIL.COM", "DARCYA", "AQAAAAIAAYagAAAAEIti6NA3UxqmCgILlTS+oFf2YeLN9suufXG66qsfSecjoIpW/Dyk5wEaIgpmwJ83UA==", null, false, null, false, "DarcyA" },
                    { new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"), 0, "d971b547-1c57-4458-b7b8-a9e3453bb4ab", new Guid("ac0b620f-da33-4ea7-8425-f3ad0d9d6789"), "maryc@mail.com", false, "Mary", "Cooper", false, null, "MARYC@MAIL.COM", "MARYC", "AQAAAAIAAYagAAAAEOayuy//YBZ9/nUNmR82KwZ3RebZX6mPtpepaWcQAOgy7YM6ICXor34+fDbJRS6WTQ==", null, false, null, false, "MaryC" },
                    { new Guid("65c01962-0033-452e-87f7-ee2f7db4ac42"), 0, "6f018859-2976-4096-95e5-ac389507659a", new Guid("f3021af9-370e-4766-bb64-fed4b1fdff8e"), "sandyb@mail.com", false, "Sandy", "Brown", false, null, "SANDYB@MAIL.COM", "SANDYB", "AQAAAAIAAYagAAAAEATJLHHpXPMDBJpvG5lZqG9+eclAn1UvV9mZAQ4BrlFeyzOPemCaUOdiaEdfhyl9OQ==", null, false, null, false, "SandyB" },
                    { new Guid("c69f3217-12e3-45ce-b5f8-84ebf4fcd77f"), 0, "b4d09310-46cb-4c17-bff4-7549a574d0e1", new Guid("37a90661-82aa-44a5-b267-079d36832bdb"), "mlevin@mail.com", false, "Mark", "Levin", false, null, "MLEVIN@MAIL.COM", "MLEVIN", "AQAAAAIAAYagAAAAEJBgyo5UfidFog+oskkL0MSM1RHFN+KubTUGqd+yy6xIZBt/3t1rFkNz1GEUNXoouA==", null, false, null, false, "MLevin" },
                    { new Guid("f2310846-a216-40d2-bb35-fe7492b82718"), 0, "4505ec21-5c54-49d9-a1d4-2d6e31c74548", new Guid("928c2995-b16b-40c8-b77d-dd18d8525f28"), "samj@mail.com", false, "Samuel", "Johnson", false, null, "SAMJ@MAIL.COM", "SAMJ", "AQAAAAIAAYagAAAAEBVmijUKuvIh5wI+Ke8hkf0FlEtT5wESJrAWqEy5F0cVD2St8Y0dMwqOBaAQE7YKUg==", null, false, null, false, "SamJ" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "AssignedToUserId", "CategoryId", "CreatedOn", "CreatorId", "Description", "DueDate", "Priority", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("05772994-8e9d-4dd9-89ab-3af31525bee9"), new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"), new Guid("7160fdfa-f038-4743-b23f-543b4c1a4786"), new DateTime(2025, 5, 28, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4969), new Guid("f2310846-a216-40d2-bb35-fe7492b82718"), "I am unable to connect to the network.", null, 2, 1, "Network issue" },
                    { new Guid("3f68d665-78f1-4913-b86a-14fbc6320e44"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), new Guid("077afb68-01e2-4ca2-ba80-cb53a34e6904"), new DateTime(2025, 5, 25, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4983), new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"), "I need a conference room for a small meeting.", new DateTime(2025, 6, 4, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4983), 1, 0, "Conference room needed" },
                    { new Guid("662951ec-01fb-4702-b327-c82321b001da"), new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"), new Guid("fdf9c1f4-58a8-41d2-8687-f1819fec2d8a"), new DateTime(2025, 5, 18, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(5072), new Guid("f2310846-a216-40d2-bb35-fe7492b82718"), "I need to update the software on my laptop.", null, 0, 3, "Software update" },
                    { new Guid("87e3cba6-a0cd-4ab3-9b11-306507c6c6cb"), new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"), new Guid("192d6dd7-c8ee-4df0-9d24-acaa766fa556"), new DateTime(2025, 5, 13, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4986), new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"), "I need HR support for a new employee.", null, 1, 3, "HR support needed" },
                    { new Guid("8b969b26-8719-45fd-b698-6cb7adc88c27"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), new Guid("c8716d5b-b764-42fa-8830-5f8d98ec5a65"), new DateTime(2025, 5, 28, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4980), new Guid("c69f3217-12e3-45ce-b5f8-84ebf4fcd77f"), "I found a security issue in the system.", null, 2, 0, "Security issue" },
                    { new Guid("b344f46c-3fb0-4ed7-9510-b90280fb3866"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), new Guid("c72716ef-fb8e-4355-b653-a4ec6a41cb36"), new DateTime(2025, 5, 28, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(3714), new Guid("f2310846-a216-40d2-bb35-fe7492b82718"), "My laptop is not turning on. I need it for work.", new DateTime(2025, 5, 29, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(3973), 2, 0, "Laptop not working" },
                    { new Guid("c019231d-b05e-49e0-a8bb-2a85c6355bdf"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), new Guid("7160fdfa-f038-4743-b23f-543b4c1a4786"), new DateTime(2025, 5, 28, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4972), new Guid("f2310846-a216-40d2-bb35-fe7492b82718"), "I need access to the new software.", null, 1, 0, "Access request" },
                    { new Guid("c5cf35e2-8ef9-4da3-84b9-98955f3b12b5"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), new Guid("fdf9c1f4-58a8-41d2-8687-f1819fec2d8a"), new DateTime(2025, 5, 28, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4967), new Guid("c69f3217-12e3-45ce-b5f8-84ebf4fcd77f"), "I need to install a new software on my laptop.", null, 0, 0, "Software installation" },
                    { new Guid("d7c5e601-71a8-4dfa-9157-302468373179"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3"), new Guid("c72716ef-fb8e-4355-b653-a4ec6a41cb36"), new DateTime(2025, 5, 28, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4956), new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"), "My printer is not working. I have a presentation in 3 days and I need it.", new DateTime(2025, 5, 30, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(4957), 1, 0, "Printer not working" },
                    { new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a"), new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"), new Guid("077afb68-01e2-4ca2-ba80-cb53a34e6904"), new DateTime(2025, 5, 23, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(5075), new Guid("65c01962-0033-452e-87f7-ee2f7db4ac42"), "I need a company car for a business trip for 3 people.", new DateTime(2025, 5, 25, 15, 41, 50, 895, DateTimeKind.Utc).AddTicks(5076), 1, 2, "Company car needed" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("22b3a385-dd4e-4d86-836e-2909f1add421"), new Guid("05abc7b7-e554-485f-a419-19ce2945e0e3") });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedOn", "CreatorId", "Message", "TicketId" },
                values: new object[,]
                {
                    { new Guid("1a53f44a-1f1d-41cc-8964-c757943fb084"), new DateTime(2025, 5, 24, 15, 41, 50, 896, DateTimeKind.Utc).AddTicks(9238), new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"), "Hello Sandy, we have a Honda Civic and a Toyota 4Runner available. Would you need a large luggage space or will you be travelling light?", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") },
                    { new Guid("20340d4e-ce5a-457b-bb64-7b3dd79543d0"), new DateTime(2025, 5, 24, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(55), new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"), "Okay, Sandy, I will contact you as soon as the car is ready. Will you be needing further instructions for operating the vehicle?", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") },
                    { new Guid("23eff7e6-1a19-4f8e-b319-19cc0b0ed2d6"), new DateTime(2025, 5, 28, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(83), new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"), "Hello Sam, please restart your device and wait for further instructions. I will contact you in several minutes.", new Guid("c019231d-b05e-49e0-a8bb-2a85c6355bdf") },
                    { new Guid("27145fee-a563-48a9-a071-df55f5058a57"), new DateTime(2025, 5, 14, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(80), new Guid("6330ce51-dc59-4d13-9bc8-a10e7e435cd6"), "Hello Darcy, thank you for your prompt response. I will be waiting for your contact.", new Guid("87e3cba6-a0cd-4ab3-9b11-306507c6c6cb") },
                    { new Guid("442bf548-2bfc-4e7b-9db4-7c8584c80d4e"), new DateTime(2025, 5, 24, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(37), new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"), "Sandy, based on your luggage size I would reccoment you to take the Toyota 4Runner. When are you supposed to leave and return?", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") },
                    { new Guid("6de041ad-a28e-4ee2-ab71-dd0c8d1b9566"), new DateTime(2025, 5, 14, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(78), new Guid("527e8d2d-45af-4888-b323-8a13c65682aa"), "Hello Mary, I have just received your request. I will be contacting you shortly.", new Guid("87e3cba6-a0cd-4ab3-9b11-306507c6c6cb") },
                    { new Guid("781819af-deb7-4efe-9da3-1d2e30b4b559"), new DateTime(2025, 5, 24, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(76), new Guid("3c818c4e-4ad8-4703-af4d-4c8677cf5874"), "You're welcome. Don't hesitate to contact me if you have any questions or need more assistance. Good day to you, too!", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") },
                    { new Guid("93dca21a-5bd6-46a4-8e85-693bc3d18712"), new DateTime(2025, 5, 24, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(33), new Guid("65c01962-0033-452e-87f7-ee2f7db4ac42"), "Hello Stan, we will be travelling with a total of 3 carry-on luggages, as well as one large suitcase.", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") },
                    { new Guid("b0d1e9f2-6c8d-4b61-8451-2842eaeb7341"), new DateTime(2025, 5, 24, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(40), new Guid("65c01962-0033-452e-87f7-ee2f7db4ac42"), "Stan, we will be leaving in two days and we are supposed to return in a day or so.", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") },
                    { new Guid("c541d904-d20f-4b36-81fd-60aaf95b6905"), new DateTime(2025, 5, 24, 15, 41, 50, 897, DateTimeKind.Utc).AddTicks(66), new Guid("65c01962-0033-452e-87f7-ee2f7db4ac42"), "No, thank you, I have already driven this particular car. Have a great day!", new Guid("d9d75702-668e-43da-af16-b1f58ee92f4a") }
                });
        }
    }
}
