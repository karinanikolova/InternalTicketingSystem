﻿using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Models;
using ITS.DAL.Data.Utilities.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ITS.Core.Services
{
	public class AuthenticationService : IAuthenticationService
	{
		private readonly IRepository _repository;

		public AuthenticationService(IRepository repository)
		{
			_repository = repository;
		}

		public Task<Guid?> GetDepartmentIdByNameAsync(string departmentName)
		{
			var department = _repository.AllReadOnly<Department>()
				.FirstOrDefault(d => d.Name == departmentName);

			return Task.FromResult(department?.Id);
		}

		public async Task<Guid> GetAdminIdAsync()
			=> await _repository.AllReadOnly<ApplicationUser>()
				.Where(u => u.UserName == "AdminUser")
				.Select(u => u.Id)
				.FirstAsync();
	}
}