using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SendenPets.Models
{
    [Table("PetsCategory")]
    public class Pet
    {
        [Key]
        public int Pets_Id { get; set; }
        public string Pets_Category { get; set; }

        public List<PetsCategories>petsCategories { get; set; }


    }
}