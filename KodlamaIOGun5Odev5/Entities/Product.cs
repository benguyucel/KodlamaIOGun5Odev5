using KodlamaIOGun5Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Entities
{
  public  class Product: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
