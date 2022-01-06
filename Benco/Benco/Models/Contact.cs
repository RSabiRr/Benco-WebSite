using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string MapsLink { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string LastName { get; set; }
        [MaxLength(500)]
        public string Subject { get; set; }
        [MaxLength(500)]
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
