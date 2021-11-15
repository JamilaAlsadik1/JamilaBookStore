using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repositary.IRepositary
{
    interface UnitOfWork:IDisposable
    {
        ICategoryRepositary Category { get; }
        ISP_Call SP_Call { get; }
    }
}
