using Afazeres.DataContext;
using Afazeres.Interface;
using Afazeres.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Afazeres.Repository
{
    public class AfazerRepository : Base.Repository, IRepository<Afazer>
    {
        public void Adicionar(Afazer obj)
        {
            ctx.AFAZERES.Add(obj);
            ctx.SaveChanges();
        }

        public void Atualizar(Afazer obj)
        {
            ctx.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public void Excluir(params object[] key)
        {
            ctx.AFAZERES.Remove(Find(key));
            ctx.SaveChanges();
        }

        public Afazer Find(params object[] key)
        {
            return ctx.AFAZERES.Find(key);
        }

        public ICollection<Afazer> Get(Func<Afazer, bool> predicate)
        {
            return ctx.AFAZERES.Where(predicate).ToList();
        }

        public ICollection<Afazer> GetAll()
        {
            return ctx.AFAZERES.OrderBy(a => a.DATAAFAZER).ToList();
        }
    }
}