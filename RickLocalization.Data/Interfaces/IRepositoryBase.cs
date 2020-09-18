using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity: class
    {
        void Add(TEntity obj);
        void Remove(TEntity obj);
        void Update(TEntity obj);
        IEnumerable<TEntity> List();
        TEntity GetById(int Id);
    }
}
