using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(5)]
        public int Review { get; set; }
        [MaxLength(250)]
        public string LittleDescription { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(150)]
        public decimal Price { get; set; }
        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Size Size { get; set; }
        [ForeignKey("ProductImage")]
        public int ProductImageId { get; set; }
        public ProductImage ProductImage { get; set; }
    }
}
