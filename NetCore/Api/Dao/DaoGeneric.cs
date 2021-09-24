using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api.Dao
{
    public class DaoGeneric<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class
    {
        public static void Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public static void DeleteById(long id)
        {
            using (var context = new TContext())
            {
                TEntity entityFind = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(entityFind);
                context.SaveChanges();
            }
        }

        public static bool Exist(TEntity entity)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Contains(entity);
            }
        }

        public static TEntity FindById(long id)
        {
            using (var context = new TContext())
            {
                TEntity entityFind = context.Set<TEntity>().Find(id);
                return entityFind;
            }
        }

        public static List<TEntity> Read()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public static void UpdateById(long id, TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
