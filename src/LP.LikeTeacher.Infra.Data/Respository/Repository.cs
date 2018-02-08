using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LP.LikeTeacher.Domain.Interfaces.Repository;
using LP.LikeTeacher.Infra.Data.Context;

namespace LP.LikeTeacher.Infra.Data.Respository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected LikeTeacherContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new LikeTeacherContext();
            DbSet = Db.Set<TEntity>();
        }
        public virtual TEntity Adicionar(TEntity obj)
        {
            var obReturn = DbSet.Add(obj);
            return obReturn;
        }

        public virtual  TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChange();

            return obj;

        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
           return DbSet.Where(predicate);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()//Paginação (int t,int s)
        {
            //Paginação return DbSet.Take(t).Skip(s);

            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChange();
        }

        public int SaveChange()
        {
            return Db.SaveChanges();
        }
    }
}
