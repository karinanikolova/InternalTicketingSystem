using ITS.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using ITS.DAL.Enums;
using static ITS.DAL.Constants.CustomClaims;
using static ITS.DAL.Constants.CustomRoles;

namespace ITS.DAL.Data.Configuration
{
	public static class DataSeed
	{
		private static readonly Guid EngineeringDeptId = Guid.NewGuid();
		private static readonly Guid QaDeptId = Guid.NewGuid();
		private static readonly Guid ItDeptId = Guid.NewGuid();
		private static readonly Guid HrDeptId = Guid.NewGuid();
		private static readonly Guid FacilitiesDeptId = Guid.NewGuid();

		private static readonly Guid SamJId = Guid.NewGuid();
		private static readonly Guid MLevinId = Guid.NewGuid();
		private static readonly Guid MaryCId = Guid.NewGuid();
		private static readonly Guid DarcyAId = Guid.NewGuid();
		private static readonly Guid SandyBId = Guid.NewGuid();
		private static readonly Guid StanMId = Guid.NewGuid();
		private static readonly Guid AdminUserId = Guid.NewGuid();

		private static readonly Guid AdminRoleId = Guid.NewGuid();
		private static readonly Guid EmployeeRoleId = Guid.NewGuid();

		private static readonly Guid HardwareCatId = Guid.NewGuid();
		private static readonly Guid SoftwareCatId = Guid.NewGuid();
		private static readonly Guid NetworkCatId = Guid.NewGuid();
		private static readonly Guid SecurityCatId = Guid.NewGuid();
		private static readonly Guid FacilitiesCatId = Guid.NewGuid();
		private static readonly Guid HrCatId = Guid.NewGuid();

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