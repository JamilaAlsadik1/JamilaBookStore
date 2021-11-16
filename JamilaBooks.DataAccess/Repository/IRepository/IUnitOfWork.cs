﻿using JamilaBooks.DataAccess.Repository.IRepository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repository.IRepository
{
   public interface IUnitOfWork : IDisposable
    {
       public ICategoryRepository Category { get; }
      public  ISP_Call SP_Call { get; }
    }
}