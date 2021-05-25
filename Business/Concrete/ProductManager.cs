using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreat.InMemory;
using Entities.Concreat;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //bir iş sınıfı başka sınıfları new lemez
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //burda iş ler vs yazıldı ve geçti diyelim aşağıda GetAll ile verileri veriyoruz
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
