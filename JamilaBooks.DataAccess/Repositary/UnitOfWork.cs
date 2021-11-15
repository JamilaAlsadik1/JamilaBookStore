using JamilaBooks.DataAccess.Repositary.IRepositary;
using JamilaBooks.Models;
using JamilaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repositary
{
   public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepositary(_db);
            SP_Call= new SP_Call(_db);

        }
        public CategoryRepositary Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        ICategoryRepositary IUnitOfWork.Category => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
