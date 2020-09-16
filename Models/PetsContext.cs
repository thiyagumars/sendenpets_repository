using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;

namespace SendenPets.Models
{
    public class PetsContext:DbContext
    {
     public DbSet<Pet>Pets { get; set; }
        public DbSet<PetsCategories> petsCategories { get; set; }
    }
}