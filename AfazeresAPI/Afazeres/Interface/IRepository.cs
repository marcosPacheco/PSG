using System;
using System.Collections.Generic;

namespace Afazeres.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        ICollection<TEntity> GetAll();
        ICollection<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Atualizar(TEntity obj);
        void Adicionar(TEntity obj);
        void Excluir(params object[] key);
    }
}