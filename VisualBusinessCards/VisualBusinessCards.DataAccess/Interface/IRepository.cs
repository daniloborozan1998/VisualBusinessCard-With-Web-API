﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VisualBusinessCards.DataAccess.Interface
{
    public interface IRepository<T>
    {
        //CRUD
        List<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
