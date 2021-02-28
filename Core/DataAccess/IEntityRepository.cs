using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // interface IEntityRepository<T> kısmına kısıt koymak istiyoruz
    // Generic Constraint --> Generic Kısıt
    // class : referans tip olabilir demek
    // new () : sadece new lenebilen classları yazabilmemizi sağlar, böylece IEntitynin kendisini kullanmamış oluruz.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // filter = null  --> filtre vermeyebiliriz
        T Get(Expression<Func<T, bool>> filter); // filtre zorunlu, tek data getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
