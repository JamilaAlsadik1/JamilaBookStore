using JamilaBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repositary.IRepositary
{
   public interface ICategoryRepositary
    {
        void Ubdate(Category category);
        object GetAll();
    }
}
