using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Link { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }

    }
}
