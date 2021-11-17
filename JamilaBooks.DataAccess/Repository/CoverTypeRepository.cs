using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JamilaBooks.DataAccess.Repository.IRepository;
using JamilaBooks.Models;
using JamilaBookStore.DataAccess.Data;

namespace JamilaBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Remove(Category objFromDb)
        {
            throw new NotImplementedException();
        }

        public void update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;

            }
        }
        public void Update(CoverTypeRepository coverType)
        {
            throw new NotImplementedException();
        }
        public void Update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
