using Microsoft.EntityFrameworkCore;
using RickLocalization.Data.Context;
using RickLocalization.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickLocalization.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext _db;

        public RepositoryBase(DataContext db)
        {
            _db = db;
        }

        public void Add(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
 
            _db.SaveChanges();
        }

        public IEnumerable<TEntity> List()
        {
            return _db.Set<TEntity>().ToList();
        }

        public void Remove(TEntity obj)
        {
            _db.Set<TEntity>().Remove(obj);

             _db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _db.Entry(obj).State = EntityState.Modified;

            _db.SaveChanges();
        }

        public TEntity GetById(int Id)
        {
            return _db.Set<TEntity>().Find(Id);
        }
    }
}
