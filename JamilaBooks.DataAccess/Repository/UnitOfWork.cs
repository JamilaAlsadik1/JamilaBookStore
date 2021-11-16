using JamilaBooks.DataAccess.Repository.IRepository;
using JamilaBooks.Models;
using JamilaBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repository
{
   public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call= new SP_Call(_db);

        }
        public CategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        ICategoryRepository IUnitOfWork.Category => throw new NotImplementedException();

       

        ISP_Call IUnitOfWork.SP_Call => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
