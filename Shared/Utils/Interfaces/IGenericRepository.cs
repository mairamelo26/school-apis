﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Utils.Enums;

namespace Utils.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);

        TEntity GetById(object id);

        List<TEntity> Get(int? pageNum = null, int? size = null, Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, object>> sort = null, SortDirection sortDirection = SortDirection.Ascending, string includeProperties = "", bool noTracking = false);

        List<TEntity> Get(int? pageNum = null, int? size = null, Expression<Func<TEntity, bool>> filter = null, string orderBy = null, SortDirection sortDirection = SortDirection.Ascending, string includeProperties = "", bool noTracking = false);

        void Update(TEntity entityToUpdate);

        void Delete(object id);

        void Delete(TEntity entityToDelete);

        int Count(Expression<Func<TEntity, bool>> filter = null);
    }
}
