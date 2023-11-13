using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using real_estate_web.Data.Common;
using real_estate_web.Models.Database;

namespace real_estate_web.Data.EntityFramework.Common
{
    public class EfEntityRepositoryBase<TEntity, TContext> :IEntityRepository<TEntity>
       where TEntity : BaseEntity
       where TContext : DbContext
    {
        protected readonly TContext Context;

        public EfEntityRepositoryBase(TContext context)
        {
            Context = context;
        }

        public DbSet<TEntity> Table => Context.Set<TEntity>();
        public async Task<TEntity> AddAsync(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = await Table.AddAsync(model);
            if(entityEntry.State == EntityState.Added){
                return entityEntry.Entity;
            }
            return null;
        }
        public async Task<bool> AddRangeAsync(List<TEntity> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }
        public bool Remove(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRange(List<TEntity> datas)
        {
            foreach (var item in datas)
            {
                Remove(item);
            }
            return true;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            TEntity model = await Table.FirstOrDefaultAsync(data => data.Id == id);
            return Remove(model);
        }

        public bool Update(TEntity model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public TEntity Add(TEntity entity)
        {
            return Context.Add(entity).Entity;
        }


        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return Context.Set<TEntity>().Where(x=>!x.IsDeleted).FirstOrDefault(expression);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await Context.Set<TEntity>().AsQueryable().Where(x => !x.IsDeleted).FirstOrDefaultAsync(expression);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression == null ? Context.Set<TEntity>().Where(x => !x.IsDeleted).AsNoTracking() : Context.Set<TEntity>().Where(x => !x.IsDeleted).Where(expression).AsNoTracking();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression == null ? await Context.Set<TEntity>().Where(x => !x.IsDeleted).ToListAsync() :
                 await Context.Set<TEntity>().Where(x => !x.IsDeleted).Where(expression).ToListAsync();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public async Task<int> SaveAsync()
            => await Context.SaveChangesAsync();


        public IQueryable<TEntity> Query()
        {
            return Context.Set<TEntity>();
        }

        public Task<int> Execute(FormattableString interpolatedQueryString)
        {
            return Context.Database.ExecuteSqlInterpolatedAsync(interpolatedQueryString);
        }

        public TResult InTransaction<TResult>(Func<TResult> action, Action successAction = null, Action<Exception> exceptionAction = null)
        {
            var result = default(TResult);
            try
            {


                if (Context.Database.ProviderName.EndsWith("InMemory"))
                {
                    result = action();
                    SaveChanges();
                }
                else
                {
                    using (var tx = Context.Database.BeginTransaction())
                    {
                        try
                        {
                            result = action();
                            SaveChanges();
                            tx.Commit();
                        }
                        catch (Exception)
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }

                successAction?.Invoke();
            }
            catch (Exception ex)
            {
                if (exceptionAction == null)
                    throw;
                else
                    exceptionAction(ex);
            }
            return result;
        }

        public async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression == null)
                return await Context.Set<TEntity>().Where(x => !x.IsDeleted).CountAsync();
            else
                return await Context.Set<TEntity>().Where(x => !x.IsDeleted).CountAsync(expression);
        }

        public int GetCount(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression == null)
                return Context.Set<TEntity>().Where(x => !x.IsDeleted).Count();
            else
                return Context.Set<TEntity>().Where(x => !x.IsDeleted).Count(expression);
        }
    }
}
