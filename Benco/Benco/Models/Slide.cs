using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Slide
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Image { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(150)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
    }
}
