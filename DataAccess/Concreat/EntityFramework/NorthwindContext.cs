using Entities.Concreat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreat.EntityFramework
{
    //context : proje tabloları ile Db tablolarını bağlamak
    public class NorthwindContext:DbContext
    {
        //over yazıp boşluk on yazıp enter deyince burası gelir
        //başına @ koyuyoruz çünkü anlamlı o (\):ctrl+alt+soru işareti
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //burda büyük küçük harf fark etmez mssql kısmında felan
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=True");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
