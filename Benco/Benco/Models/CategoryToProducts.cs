using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class CategoryToProducts
    {
        [Key]
        public int Id  { get; set; }
        [ForeignKey("Products")]
        public int ProductsId { get; set; }
        public Products Products { get; set; }
        [ForeignKey("Categories")]
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
    }
}
