using KodlamaIOGun5Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Entities
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int GameID { get; set; }

    }
}
