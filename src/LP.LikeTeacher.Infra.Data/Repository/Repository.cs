using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using LP.LikeTeacher.Domain.Interface.Repository;
using LP.LikeTeacher.Infra.Data.Context;

namespace LP.LikeTeacher.Infra.Data.Repository
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

        public Repository(LikeTeacherContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();

        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            var objReturnAdd = DbSet.Add(obj);
            return objReturnAdd;
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var ObjReturnUpd = Db.Entry(obj);
            DbSet.Attach(obj);
            ObjReturnUpd.State = EntityState.Modified;
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

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            var ObjRemove = DbSet.Find(id);
            DbSet.Remove(ObjRemove);
        }

        public virtual int SalveChances()
        {
            return Db.SaveChanges();
        }
    }
}