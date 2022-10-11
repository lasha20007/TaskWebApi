using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonsWebApi.Domain.BaseEnum;
using PersonsWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsWebApi.Infrastructure.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PersonsRelation> PersonsRelations { get; set; }
        public DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Tbilisi" },
                new City { CityId = 2, CityName = "Batumi" },
                new City { CityId = 3, CityName = "Kutaisi" },
                new City { CityId = 4, CityName = "Samtredia" },
                new City { CityId = 5, CityName = "Mestia" },
                new City { CityId = 6, CityName = "Khoni" },
                new City { CityId = 7, CityName = "Zugdidi" },
                new City { CityId = 8, CityName = "Telavi" }
                );

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    PersonId = 1,
                    Name = "Lasha",
                    Surname = "Sulukhia",
                    Gender = Gender.Male,
                    PersonalNumber = "01027073355",
                    BirthDate = new DateTime(2000, 11, 6),
                    PhotoPath = "Lasha.jpg",
                    CityRefId = 1
                }
                );
        }

    }
}
