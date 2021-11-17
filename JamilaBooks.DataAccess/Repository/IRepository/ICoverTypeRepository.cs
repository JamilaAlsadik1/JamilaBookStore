using JamilaBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository:IRepository<CoverType>
    {
        void update(CoverType coverType);
        void Remove(Category objFromDb);//I don't know if it's correct to add it
       
        void Update(CoverType coverType);
        void Remove(CoverType objFromDb);
    }
}
