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
    public class CategoryRepositary : Repositary<Category>, ICategoryRepositary
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepositary(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }

        public void Ubdate(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
