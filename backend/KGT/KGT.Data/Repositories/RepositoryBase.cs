using KGT.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KGT.Data.Repositories
{
    public abstract class RepositoryBase<T, TPrimaryKey> : IRepository<T, TPrimaryKey>
        where T : class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        protected AppDbContext Context;
        protected DbSet<T> DbSet;

        protected RepositoryBase()
        {
        }

        protected RepositoryBase(AppDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }


        public virtual async Task AddAsync(T item)
        {
            await DbSet.AddAsync(item);
            Context.SaveChanges();
        }

        // TODO: we can consider soft delete later
        public virtual async Task DeleteAsync(TPrimaryKey id)
        {
            var item = await GetByIdAsync(id);
            DbSet.Remove(item);
            await Context.SaveChangesAsync();

        }

        public virtual List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual async Task<T> GetByIdAsync(TPrimaryKey id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task ModifyAsync(T item)
        {
            var original = await GetByIdAsync(item.Id);
            Context.Entry(original).CurrentValues.SetValues(item);
            await Context.SaveChangesAsync();
        }
    }
}
