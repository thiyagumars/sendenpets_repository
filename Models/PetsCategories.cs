using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SendenPets.Models
{
    [Table("PetsSubCategory")]
    public class PetsCategories
    {
        [Key]
        public int PetsSubCategory_Id { get; set; }
        public int Pets_Id { get; set; }
                public string Pets_SubCategory { get; set; }
    }
}