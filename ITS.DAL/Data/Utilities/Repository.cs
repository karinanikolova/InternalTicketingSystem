using ITS.DAL.Data.Utilities.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ITS.DAL.Data.Utilities
{
	public class Repository : IRepository
	{
		private readonly DbContext _context;

		public Repository(AppDbContext context)
		{
			_context = context;
		}

		public void Add<TEntity>(TEntity entity) where TEntity : class
		{
			DbSet<TEntity>().Add(entity);
		}

		public async Task AddAsync<TEntity>(TEntity entity) where TEntity : class
		{
			await DbSet<TEntity>().AddAsync(entity);
		}

		public IQueryable<TEntity> All<TEntity>() where TEntity : class
			=> DbSet<TEntity>();
		

		public IQueryable<TEntity> AllReadOnly<TEntity>() where TEntity : class
			=> DbSet<TEntity>().AsNoTracking();
		

		public void Delete<TEntity>(TEntity entityToDelete) where TEntity : class
		{
			DbSet<TEntity>().Remove(entityToDelete);
		}

		public void DeleteRange<TEntity>(params TEntity[] entitiesToDelete) where TEntity : class
		{
			DbSet<TEntity>().RemoveRange(entitiesToDelete);
		}

		public int SaveChanges()
			=> _context.SaveChanges();
		

		public async Task<int> SaveChangesAsync()
			=> await _context.SaveChangesAsync();

		public async Task<TEntity?> GetByIdAsync<TEntity>(object id) where TEntity : class
			=> await DbSet<TEntity>().FindAsync(id);

		private DbSet<TEntity> DbSet<TEntity>() where TEntity : class
			=> _context.Set<TEntity>();
	}
}