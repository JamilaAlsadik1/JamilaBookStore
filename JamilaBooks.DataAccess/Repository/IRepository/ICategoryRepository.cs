﻿using JamilaBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamilaBooks.DataAccess.Repository.IRepository
{
   public interface ICategoryRepository:IRepository<Category>
    {
        void Ubdate(Category category);
       
    }
}
