using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Burdaki t ye kısıtlama getirecez yani sadece category product ve customer yazılması gerek
    //class =referans tip demek
    //IEntity ise IEntity olabilir veya IEntity implemente eden bir nesne olabilir demek 
    //new() ise new lenebilir olması lazım demek böylelikle artık IEntity kullanılamaz 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //burası iş sınıfında listeleme yapılarını yazmamızı sağlıyor
        //herşeyi getirmek için
        //filter null demek filtrelemese de herşeyi istiyor demektir
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        //sadece bir detaya bakmak için
        //burda ise filter filter olması gerekiyor demek
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
