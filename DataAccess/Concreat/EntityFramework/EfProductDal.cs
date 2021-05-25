using DataAccess.Abstract;
using Entities.Concreat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concreat.EntityFramework
{
    //NuGet kullanımı
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //using tab tab yapılarak aşağıdaki geldi
            //using burda işi bitince GC e gel burayı temizle diyorq    
            using (NorthwindContext context=new NorthwindContext())
            {
                var addetEntity = context.Entry(entity);//referansı yakala
                addetEntity.State = EntityState.Added;//o aslında eklenecek bir nesne
                context.SaveChanges();//ve şimdi ekle
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);//referansı yakala
                deletedEntity.State = EntityState.Deleted;//o aslında silinecek bir nesne
                context.SaveChanges();//ve şimdi sil
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);//referansı yakala
                updatedEntity.State = EntityState.Modified;//o aslında güncellenecek bir nesne
                context.SaveChanges();//ve şimdi güncelle
            }
        }
    }
}
