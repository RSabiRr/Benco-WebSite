using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Content { get; set; }
        [MaxLength(100)]
        public string CollapseText { get; set; }
        [MaxLength(500)]
        public string CollapseContent { get; set; }
    }
}
