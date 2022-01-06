using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Models
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string Icon { get; set; }
        [MaxLength(500)]
        public string IconTitle { get; set; }
        [MaxLength(500)]
        public string IconDescription { get; set; }
        [ForeignKey("Slide")]
        public int SlideId { get; set; }
        public Slide  Slide { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public Company  Company { get; set; }
    }
}
