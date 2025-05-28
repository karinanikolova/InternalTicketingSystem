namespace ITS.Core.Services.Contracts
{
	public interface IAuthenticationService
	{
		Task<Guid?> GetDepartmentIdByNameAsync(string departmentName);
	}
}