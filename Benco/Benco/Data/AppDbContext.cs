using Benco.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Benco.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Blog> Blog { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<CategoryToProducts> CategoryToProducts { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<CustomUser> CustomUser { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Faq> Faq { get; set; }

        public DbSet<FeedBack> FeedBack { get; set; }

        public DbSet<Home> Home { get; set; }

        public DbSet<ProductImage> ProductImage { get; set; }

        public DbSet<Products> Products { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<Size> Size { get; set; }

        public DbSet<Slide> Slide { get; set; }

        public DbSet<Social> Social { get; set; }

        public DbSet<Tag> Tag { get; set; }

        public DbSet<TagToBlog> TagToBlog { get; set; }

    }
}
