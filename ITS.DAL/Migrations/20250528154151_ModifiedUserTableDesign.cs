using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITS.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUserTableDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Users");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Users");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: new Guid("3bfd7d25-a1e5-4f7e-a3bf-028ac195a51b"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: new Guid("d2d36cc2-d7ac-4de5-aba0-6b931d26effb"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: new Guid("6a28384f-8f2b-4fc3-843b-fec3b3b75693"));

            migrationBuilder.UpdateData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: new Guid("abf83cdd-fc9b-4d43-bf37-3093c1994edd"));

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

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }
    }
}
