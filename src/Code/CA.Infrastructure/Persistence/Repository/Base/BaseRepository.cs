﻿using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using CA.Core.Interfaces.Base;

namespace CA.Infrastructure.Persistence.Repository.Base
{
  public class BaseRepository<T, TKey, TContext> : IBaseRepository<T, TContext>
  where T : class
  where TContext : DbContext, new()
  {
    private TContext _dataContext;
    private readonly DbSet<T> _dbSet;
    protected IDbFactory<TContext> DbFactory { get; private set; }
    protected TContext DbContext { get => _dataContext ?? (_dataContext = DbFactory.Init()); }
    public BaseRepository(IDbFactory<TContext> dbFactory) { DbFactory = dbFactory; _dbSet = DbContext.Set<T>(); }

    public async Task AddAsync(T entity, CancellationToken cancellationToken = default) =>
      await _dbSet.AddAsync(entity, cancellationToken);

     public async Task<IEnumerable<T>> AllAsync(CancellationToken cancellationToken = default) => 
      await _dbSet.ToListAsync(cancellationToken);

    public void Delete(T entity) => _dbSet.Remove(entity);

    public async Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default) =>
      await _dbSet.Where(predicate).ToListAsync(cancellationToken);

    public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default) => 
      await _dbSet.FindAsync(new object[] { id }, cancellationToken);
    public void Update(T entity) => _dbSet.Update(entity);
  }
}
