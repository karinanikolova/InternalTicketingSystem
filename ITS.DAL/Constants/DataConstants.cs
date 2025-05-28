namespace ITS.DAL.Constants
{
	public static class DataConstants
	{
		public static class Category
		{
			public const int NameMinLength = 1;
			public const int NameMaxLength = 50;
		}

		public static class Ticket
		{
			public const int TitleMinLength = 3;
			public const int TitleMaxLength = 50;

			public const int DescriptionMinLength = 5;
			public const int DescriptionMaxLength = 1000;
		}

		public static class Comment
		{
			public const int MessageMinLength = 1;
			public const int MessageMaxLength = 1000;
		}

		public static class Department
		{
			public const int DepartmentNameMinLength = 1;
			public const int DepartmentNameMaxLength = 50;
		}

		public static class ApplicationUser
		{
			public const int UserNameMinLength = 3;
			public const int UserNameMaxLength = 50;

			public const int UserFirstNameMinLength = 1;
			public const int UserFirstNameMaxLength = 50;

			public const int UserLastNameMinLength = 1;
			public const int UserLastNameMaxLength = 50;

			public const int UserPasswordMinLength = 6;
			public const int UserPasswordMaxLength = 100;

			public const int UserEmailMaxLength = 50;
		}
	}
}