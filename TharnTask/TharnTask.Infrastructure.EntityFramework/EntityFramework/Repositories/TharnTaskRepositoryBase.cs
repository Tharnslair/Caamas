using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace TharnTask.EntityFramework.Repositories
{
    public abstract class TharnTaskRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TharnTaskDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class TharnTaskRepositoryBase<TEntity> : TharnTaskRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
