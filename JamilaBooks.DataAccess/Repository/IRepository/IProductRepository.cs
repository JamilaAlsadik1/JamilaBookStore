using JamilaBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void update(Product product);
        void Remove(Category objFromDb);//I don't know if it's correct to add it

        void Update(Product product);
        void Remove(Product objFromDb);
    }
}
