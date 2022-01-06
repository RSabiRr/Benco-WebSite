using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [MaxLength(500)]
        public string Contex { get; set; }
        public DateTime CreateTime { get; set; }
        [ForeignKey("CustomUser")]
        public int CustomUserId { get; set; }
        public CustomUser CustomUser { get; set; }
    }
}
