using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Test001.Models
{
    public class MyDb : DbContext
    {
        public MyDb() : base("MyConnectionString")
        {
        }

        public System.Data.Entity.DbSet<Test001.Models.Student> Students { get; set; }
    }
}