using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<Entity> : IRepository<Entity> where Entity : class
    {
        Context context = new Context();
        DbSet<Entity> _object;

        public GenericRepository()
        {
            _object = context.Set<Entity>();
        }

        public void Delete(Entity item)
        {
            var deletedEntity = context.Entry(item);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Insert(Entity item)
        {
            var addedEntity = context.Entry(item);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public List<Entity> Read()
        {
            return _object.ToList();
        }

        List<Entity> IRepository<Entity>.Read(Expression<Func<Entity, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(Entity item)
        {
            var updatedEntity = context.Entry(item);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public Entity Get(Expression<Func<Entity, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }
    }
}
