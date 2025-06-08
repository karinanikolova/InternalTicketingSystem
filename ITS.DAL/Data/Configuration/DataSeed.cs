using ITS.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using ITS.DAL.Enums;
using static ITS.DAL.Constants.AdminConstants;
using static ITS.DAL.Constants.CustomRolesAndClaims;

namespace ITS.DAL.Data.Configuration
{
	public static class DataSeed
	{
		private static readonly Guid EngineeringDeptId = Guid.Parse("e84fad18-ed54-47cd-aeaf-4c94b513d8bc");
		private static readonly Guid QaDeptId = Guid.Parse("cc6a4f78-4c15-41e3-ae61-a6420f6de8cd");
		private static readonly Guid ItDeptId = Guid.Parse("2cd02069-2cb2-4b58-8cc5-58538f4480cb");
		private static readonly Guid HrDeptId = Guid.Parse("0ee540ac-e651-45f5-97c7-a908df086e2d");
		private static readonly Guid FacilitiesDeptId = Guid.Parse("c3f276a1-35a7-4b50-bfbc-373f706d5cd5");

		private static readonly Guid SamJId = Guid.Parse("b94e4389-b297-4f9c-8dbd-5ed1d9d0ee94");
		private static readonly Guid MLevinId = Guid.Parse("98bd95e4-71a2-488a-a56d-12245dd7f291");
		private static readonly Guid MaryCId = Guid.Parse("24ebeca2-8cda-4801-a113-725657e7b47a");
		private static readonly Guid DarcyAId = Guid.Parse("b87a7720-d1f8-4160-8a3c-6c2922bb8946");
		private static readonly Guid SandyBId = Guid.Parse("a4f4d3c9-eaf1-4708-9837-e9b4aeb53d7c");
		private static readonly Guid StanMId = Guid.Parse("0480d7eb-c544-4058-8b07-c828104189af");
		private static readonly Guid AdminUserId = Guid.Parse("291f114d-6be7-4af0-b73f-ee8690597885");

		private static readonly Guid AdminRoleId = Guid.Parse("5f439325-7a78-4d47-8e5f-c58787c10b94");
		private static readonly Guid EmployeeRoleId = Guid.Parse("d5553e44-17ed-4ce2-808f-8d5f02a4ad18");

		private static readonly Guid HardwareCatId = Guid.Parse("34afa6e3-d6d1-42b0-afc4-9a9b5edd278b");
		private static readonly Guid SoftwareCatId = Guid.Parse("cfaff174-8b18-46f8-bcb3-87dd2ffec7ad");
		private static readonly Guid NetworkCatId = Guid.Parse("9c9d0d44-2ab3-4912-8c04-2f2192ed80e1");
		private static readonly Guid SecurityCatId = Guid.Parse("fe9fdc3f-7e82-47f8-a432-76ea5bbfd396");
		private static readonly Guid FacilitiesCatId = Guid.Parse("c21d907c-a05f-4b7f-b4b2-e989dffb8d2a");
		private static readonly Guid HrCatId = Guid.Parse("98d8e692-4707-475e-b870-92a37f881986");

		public static readonly List<Department> Departments = new();

		public static readonly List<ApplicationUser> Users = new();

		public static readonly List<IdentityUserClaim<Guid>> UserClaims = new();

		public static readonly List<ApplicationRole> Roles = new();

		public static readonly List<IdentityUserRole<Guid>> UserRoles = new();

		public static readonly List<Category> Categories = new();

		public static readonly List<Ticket> Tickets = new ();

		public static readonly List<Comment> Comments = new();

		static DataSeed()
		{
			InitializeDepartments();
			InitializeUsers();
			InitializeUserClaims();
			InitializeRoles();
			InitializeUserRoles();
			InitializeCategories();
			InitializeTickets();
			InitializeComments();
		}

		private static void InitializeDepartments()
		{
			Departments.AddRange(new List<Department>()
			{
				new()
				{
					Id = EngineeringDeptId,
					Name = "Engineering & Development"
				},
				new()
				{
					Id = QaDeptId,
					Name = "Quality Assurance"
				},
				new()
				{
					Id = ItDeptId,
					Name = "IT & Security"
				},
				new()
				{
					Id = HrDeptId,
					Name = "Human Resources"
				},
				new()
				{
					Id = FacilitiesDeptId,
					Name = "Facilities"
				}
			});
		}

		private static void InitializeUsers()
		{
			var hasher = new PasswordHasher<ApplicationUser>();

			Users.AddRange(new List<ApplicationUser>()
			{
				CreateUser(SamJId, "SamJ", "samj@mail.com", "Samuel", "Johnson", EngineeringDeptId, "SamJ123!", hasher),
				CreateUser(MLevinId, "MLevin", "mlevin@mail.com", "Mark", "Levin", QaDeptId, "MLevin123!", hasher),
				CreateUser(MaryCId, "MaryC", "maryc@mail.com", "Mary", "Cooper", ItDeptId, "MaryC123!", hasher),
				CreateUser(DarcyAId, "DarcyA", "darcya@mail.com", "Darcy", "Abrams", HrDeptId, "DarcyA123!", hasher),
				CreateUser(SandyBId, "SandyB", "sandyb@mail.com", "Sandy", "Brown", HrDeptId, "SandyB123!", hasher),
				CreateUser(StanMId, "StanM", "stanleym@mail.com", "Stanley", "Morgan", FacilitiesDeptId, "StanM123!", hasher),
				CreateUser(AdminUserId, "AdminUser", "admin@mail.com", "Garry", "Francis", ItDeptId, "AdminUser123!", hasher)
			});
		}

		public static void InitializeUserClaims()
		{
			UserClaims.AddRange(new List<IdentityUserClaim<Guid>>()
			{
				new()
				{
					Id = 1,
					UserId = MaryCId,
					ClaimType = UserSupportAgentClaim,
					ClaimValue = "true"
				},
				new()
				{
					Id = 2,
					UserId = StanMId,
					ClaimType = UserSupportAgentClaim,
					ClaimValue = "true"
				},
				new()
				{
					Id = 3,
					UserId = DarcyAId,
					ClaimType = UserSupportAgentClaim,
					ClaimValue = "true"
				},
				new()
				{
					Id = 4,
					UserId = AdminUserId,
					ClaimType = UserSupportAgentClaim,
					ClaimValue = "true"
				}
			});
		}

		private static void InitializeRoles()
		{
			Roles.AddRange(new List<ApplicationRole>()
			{
				new()
				{
					Id = AdminRoleId,
					Name = AdminRole,
					NormalizedName = AdminRole.ToUpper()
				},
				new()
				{
					Id = EmployeeRoleId,
					Name = EmployeeRole,
					NormalizedName = EmployeeRole.ToUpper()
				}
			});
		}

		private static void InitializeUserRoles()
		{
			UserRoles.AddRange(new List<IdentityUserRole<Guid>>()
			{
				new()
				{
					UserId = AdminUserId,
					RoleId = AdminRoleId
				},
				new()
				{
					UserId = SamJId,
					RoleId = EmployeeRoleId
				},
				new()
				{
					UserId = MLevinId,
					RoleId = EmployeeRoleId
				},
				new()
				{
					UserId = MaryCId,
					RoleId = EmployeeRoleId
				},
				new()
				{
					UserId = DarcyAId,
					RoleId = EmployeeRoleId
				},
				new()
				{
					UserId = SandyBId,
					RoleId = EmployeeRoleId
				},
				new()
				{
					UserId = StanMId,
					RoleId = EmployeeRoleId
				}
			});
		}

		private static void InitializeCategories()
		{
			Categories.AddRange(new List<Category>()
			{
				new()
				{
					Id = HardwareCatId,
					Name = "Hardware"
				},
				new()
				{
					Id = SoftwareCatId,
					Name = "Software"
				},
				new()
				{
					Id = NetworkCatId,
					Name = "Network & Access Request"
				},
				new()
				{
					Id = SecurityCatId,
					Name = "Security"
				},
				new()
				{
					Id = FacilitiesCatId,
					Name = "Facilities"
				},
				new()
				{
					Id = HrCatId,
					Name = "HR"
				}
			});
		}

		private static void InitializeTickets()
		{
			Tickets.AddRange(new List<Ticket>()
			{
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Laptop not working",
					Description = "My laptop is not turning on. I need it for work.",
					CategoryId = HardwareCatId,
					Status = Status.Open,
					Priority = Priority.High,
					CreatedOn = DateTime.UtcNow,
					DueDate = DateTime.UtcNow.AddDays(1),
					CreatorId = SamJId,
					AssignedToUserId = AdminUserId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Printer not working",
					Description = "My printer is not working. I have a presentation in 3 days and I need it.",
					CategoryId = HardwareCatId,
					Status = Status.Open,
					Priority = Priority.Medium,
					CreatedOn = DateTime.UtcNow,
					DueDate = DateTime.UtcNow.AddDays(2),
					CreatorId = DarcyAId,
					AssignedToUserId = AdminUserId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Software installation",
					Description = "I need to install a new software on my laptop.",
					CategoryId = SoftwareCatId,
					Status = Status.Open,
					Priority = Priority.Low,
					CreatedOn = DateTime.UtcNow,
					CreatorId = MLevinId,
					AssignedToUserId = AdminUserId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Network issue",
					Description = "I am unable to connect to the network.",
					CategoryId = NetworkCatId,
					Status = Status.InProgress,
					Priority = Priority.High,
					CreatedOn = DateTime.UtcNow,
					CreatorId = SamJId,
					AssignedToUserId = MaryCId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Access request",
					Description = "I need access to the new software.",
					CategoryId = NetworkCatId,
					Status = Status.Open,
					Priority = Priority.Medium,
					CreatedOn = DateTime.UtcNow,
					CreatorId = SamJId,
					AssignedToUserId = AdminUserId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Security issue",
					Description = "I found a security issue in the system.",
					CategoryId = SecurityCatId,
					Status = Status.Open,
					Priority = Priority.High,
					CreatedOn = DateTime.UtcNow,
					CreatorId = MLevinId,
					AssignedToUserId = AdminUserId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Conference room needed",
					Description = "I need a conference room for a small meeting.",
					CategoryId = FacilitiesCatId,
					Status = Status.Open,
					Priority = Priority.Medium,
					CreatedOn = DateTime.UtcNow.AddDays(-3),
					DueDate = DateTime.UtcNow.AddDays(7),
					CreatorId = DarcyAId,
					AssignedToUserId = AdminUserId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "HR support needed",
					Description = "I need HR support for a new employee.",
					CategoryId = HrCatId,
					Status = Status.Closed,
					Priority = Priority.Medium,
					CreatedOn = DateTime.UtcNow.AddDays(-15),
					CreatorId = MaryCId,
					AssignedToUserId =  DarcyAId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Software update",
					Description = "I need to update the software on my laptop.",
					CategoryId = SoftwareCatId,
					Status = Status.Closed,
					Priority = Priority.Low,
					CreatedOn = DateTime.UtcNow.AddDays(-10),
					CreatorId = SamJId,
					AssignedToUserId = MaryCId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Title = "Company car needed",
					Description = "I need a company car for a business trip for 3 people.",
					CategoryId = FacilitiesCatId,
					Status = Status.Resolved,
					Priority = Priority.Medium,
					CreatedOn = DateTime.UtcNow.AddDays(-5),
					DueDate = DateTime.UtcNow.AddDays(-3),
					CreatorId = SandyBId,
					AssignedToUserId =  StanMId
				}
			});
		}

		private static void InitializeComments()
		{
			var carTicketId = Tickets.First(t => t.Title == "Company car needed").Id;
			var hrTicketId = Tickets.First(t => t.Title == "HR support needed").Id;
			var accessTicketId = Tickets.First(t => t.Title == "Access request").Id;

			Comments.AddRange(new List<Comment>()
			{
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Hello Sandy, we have a Honda Civic and a Toyota 4Runner available. Would you need a large luggage space or will you be travelling light?",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = StanMId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Hello Stan, we will be travelling with a total of 3 carry-on luggages, as well as one large suitcase.",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = SandyBId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Sandy, based on your luggage size I would reccoment you to take the Toyota 4Runner. When are you supposed to leave and return?",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = StanMId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Stan, we will be leaving in two days and we are supposed to return in a day or so.",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = SandyBId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Okay, Sandy, I will contact you as soon as the car is ready. Will you be needing further instructions for operating the vehicle?",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = StanMId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "No, thank you, I have already driven this particular car. Have a great day!",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = SandyBId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "You're welcome. Don't hesitate to contact me if you have any questions or need more assistance. Good day to you, too!",
					CreatedOn = DateTime.UtcNow.AddDays(-4),
					TicketId = carTicketId,
					CreatorId = StanMId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Hello Mary, I have just received your request. I will be contacting you shortly.",
					CreatedOn = DateTime.UtcNow.AddDays(-14),
					TicketId = hrTicketId,
					CreatorId = DarcyAId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Hello Darcy, thank you for your prompt response. I will be waiting for your contact.",
					CreatedOn = DateTime.UtcNow.AddDays(-14),
					TicketId = hrTicketId,
					CreatorId = MaryCId
				},
				new()
				{
					Id = Guid.NewGuid(),
					Message = "Hello Sam, please restart your device and wait for further instructions. I will contact you in several minutes.",
					CreatedOn = DateTime.UtcNow,
					TicketId = accessTicketId,
					CreatorId = MaryCId
				}
			});
		}

		private static ApplicationUser CreateUser(Guid id, string userName, string email, string firstName, string lastName, Guid departmentId, string password, PasswordHasher<ApplicationUser> hasher)
		{
			var user = new ApplicationUser()
			{
				Id = id,
				UserName = userName,
				NormalizedUserName = userName.ToUpper(),
				Email = email,
				NormalizedEmail = email.ToUpper(),
				FirstName = firstName,
				LastName = lastName,
				DepartmentId = departmentId
			};

			user.PasswordHash = hasher.HashPassword(user, password);

			return user;
		}
	}
}