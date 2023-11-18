﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
namespace TaskCreator.DDD;
public interface IEfCoreDbContext 
{
    DbSet<T> Set<T>() where T : class;
    EntityEntry<T> Update<T>(T entity) where T : class;
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}