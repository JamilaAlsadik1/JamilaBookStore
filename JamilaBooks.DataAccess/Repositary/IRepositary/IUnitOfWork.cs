using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repositary.IRepositary
{
   public interface IUnitOfWork : IDisposable
    {
       public ICategoryRepositary Category { get; }
      public  ISP_Call SP_Call { get; }
    }
}
