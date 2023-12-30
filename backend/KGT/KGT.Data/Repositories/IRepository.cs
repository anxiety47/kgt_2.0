using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGT.Data.Repositories
{
    public interface IRepository<T, TPrimaryKey>
    where T: class, IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        Task<T> GetByIdAsync(TPrimaryKey id);
        List<T> GetAll();
        Task<TPrimaryKey> AddAsync(T item);
        Task<TPrimaryKey> ModifyAsync(T item);
        Task DeleteAsync(TPrimaryKey id);
    }
}
