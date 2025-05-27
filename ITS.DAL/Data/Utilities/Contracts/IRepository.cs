namespace ITS.DAL.Data.Utilities.Contracts
{
	public interface IRepository
	{
		IQueryable<TEntity> All<TEntity>() where TEntity : class;

		IQueryable<TEntity> AllReadOnly<TEntity>() where TEntity : class;

		Task AddAsync<TEntity>(TEntity entity) where TEntity : class;

		void Add<TEntity>(TEntity entity) where TEntity : class;

		Task<int> SaveChangesAsync();

		int SaveChanges();

		void Delete<TEntity>(TEntity entityToDelete) where TEntity : class;

		void DeleteRange<TEntity>(params TEntity[] entitiesToDelete) where TEntity : class;

		Task<TEntity?> GetByIdAsync<TEntity>(object id) where TEntity : class;
	}
}