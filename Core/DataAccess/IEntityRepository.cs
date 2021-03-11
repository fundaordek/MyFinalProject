using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
   public interface IEntityRepository<T>where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//p yerine
        T Get(Expression<Func<T, bool>> filter = null); //tek bir data detayı. filtreleme yazmayı sağlar. filtre olmak zorunda değil
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetAllByCategory(int categoryId); expressiondan sonra buna ihtiyaç yoktur
        //ürünleri kategoriye göre filtrele
    }
}
