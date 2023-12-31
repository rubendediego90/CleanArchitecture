﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitecture.Domain.IRepositories
{
    public interface IBaseRepository<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        Task<TEntity?> Add(TEntity entity);

        Task<List<TEntity>?> AddList(List<TEntity> listItems);

        Task Update(TEntity entity);

        Task UpdateRange(List<TEntity> listItems);

        Task Remove(TEntity entity);

        IQueryable<TEntity> Get();

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression);

        IQueryable<TEntity> GetAsNoTracking();

        IQueryable<TEntity> GetAsNoTracking(Expression<Func<TEntity, bool>> expression);

        // Task<PagedResult<T>> GetPaginatedGenericList(DtoListFiltersBase dtoListFiltersBase, IQueryable<T> func);

        Task<TEntity?> GetById(int id);

    }
}
