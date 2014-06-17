using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcApplicationFinal.Models
{
    public class Person
    {
        //[Key]public int ID { get; set; }
        [Key]
        public int PersonKey { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonUsername { get; set; }
     

    }
    public class DonorDBContext : DbContext
    {
        public DbSet<Person> Donors{ get; set; }
    }
}