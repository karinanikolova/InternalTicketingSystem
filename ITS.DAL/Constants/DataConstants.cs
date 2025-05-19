namespace ITS.DAL.Constants
{
	public static class DataConstants
	{
		public static class Category
		{
			public const int NameMinLength = 3;
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
	}
}