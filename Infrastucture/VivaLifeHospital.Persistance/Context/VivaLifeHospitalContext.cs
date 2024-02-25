using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Persistance.Context
{
    public class VivaLifeHospitalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FURKAN\\FURKANKILIC;initial Catalog=VivaLifeHospital;integrated Security= true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<VisitorContact> VisitorContacts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalProgram> MedicalPrograms { get; set;}
        public DbSet<Pricing> Pricings{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Comment> Comments { get; set;}
        public DbSet<TagCloud> TagsCloud { get; set;}
        public DbSet<Appointment> Appointments { get; set;}
    }
}

