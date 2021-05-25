using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concreat
{
    public class Category: IEntity
    {
        //Çıplak class kalmasın
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
