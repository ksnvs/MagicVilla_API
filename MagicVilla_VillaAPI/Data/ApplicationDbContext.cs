using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Fusce 11 Tince Max",
                    ImageUrl = "dsdasda",
                    Occuoancy = 100,
                    Rate = 100,
                    Sqft = 100,
                    Amenity= "sdsadsadsa",
                    CreatedDate = DateTime.Now,
                },
                  new Villa()
                  {
                      Id = 2,
                      Name = "Premium Pool Villa",
                      Details = "Fusce 11 Tince Max",
                      ImageUrl = "dsdasda",
                      Occuoancy = 100,
                      Rate = 300,
                      Sqft = 500,
                      Amenity = "sdsadsadsa",
                      CreatedDate = DateTime.Now,
                  },
                    new Villa()
                    {
                        Id = 3,
                        Name = "Luxury Pool Villa",
                        Details = "Fusce 11 Tince Max",
                        ImageUrl = "dsdasda",
                        Occuoancy = 100,
                        Rate = 400,
                        Sqft = 700,
                        Amenity = "sdsadsadsa",
                        CreatedDate = DateTime.Now,
                    },
                      new Villa()
                      {
                          Id = 4,
                          Name = "Diamond Villa",
                          Details = "Fusce 11 Tince Max",
                          ImageUrl = "dsdasda",
                          Occuoancy = 100,
                          Rate = 100,
                          Sqft = 500,
                          Amenity = "sdsadsadsa",
                          CreatedDate = DateTime.Now,
                      },
                        new Villa()
                        {
                            Id = 5,
                            Name = "Dimond Pool Villa",
                            Details = "Fusce 11 Tince Max",
                            ImageUrl = "dsdasda",
                            Occuoancy = 100,
                            Rate = 200,
                            Sqft = 600,
                            Amenity = "sdsadsadsa",
                            CreatedDate = DateTime.Now,
                        }
                );
        }

    }
}
