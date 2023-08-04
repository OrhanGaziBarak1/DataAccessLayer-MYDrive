using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository <Entity>
    {
        List<Entity> Read();
        List<Entity> Read (Expression<Func<Entity,bool>> filter);
        void Insert(Entity item);
        void Delete(Entity item);
        void Update(Entity item);
        Entity Get(Expression<Func<Entity,bool>> filter);
    }
}
