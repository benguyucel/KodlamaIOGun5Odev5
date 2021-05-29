using KodlamaIOGun5Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace KodlamaIOGun5Odev5.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string NationalityID { get; set; }
        public string  FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
