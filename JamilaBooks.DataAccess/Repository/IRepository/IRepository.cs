using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);                  // Retrieve a category from the database by id 
        //List of Categories based on requirements 

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null             // useful  for foreign key references
            );
        void Add(T entity); // to add an entry
        void Remove(int id);
        void RemoveRnge(IEnumerable<T> entity);
       
    }
}
