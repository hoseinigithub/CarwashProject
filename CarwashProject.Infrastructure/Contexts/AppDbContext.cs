using CarwashProject.Application.Interfaces;
using CarwashProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Infrastructure.Contexts;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Worker> Workers { get; set; }
    public DbSet<Khadamat> Khadamats { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Car> Cars { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Worker>().HasData(new List<Worker>()
        {
           new Worker{Id = 1,Age = 20,FirstName = "ali",LastName = "ahmadi",},
           new Worker{Id = 2,Age = 21,FirstName = "majid",LastName = "majidi"},
           new Worker{Id = 3,Age = 22,FirstName = "farhad",LastName = "farhadi"},
           new Worker{Id = 4,Age = 23,FirstName = "soheil",LastName = "soheily"}
        });

        modelBuilder.Entity<Khadamat>().HasData(new List<Khadamat>()
        {
            new Khadamat{Id = 1,Name = "Door",Price = 80000},
            new Khadamat{Id = 2,Name = "Dashboard",Price = 80000},
            new Khadamat{Id = 3,Name = "Ceiling",Price = 80000},
            new Khadamat{Id = 4,Name = "Column",Price = 60000},
        });

        modelBuilder.Entity<Car>().HasData(new List<Car>()
        {
            new Car {Id = 1,Name = "Pride"},
            new Car {Id = 2,Name = "Peugeot"},
            new Car {Id = 3,Name = "PeugeotPars"},
            new Car {Id = 4,Name = "Samand"},
            new Car {Id = 5,Name = "Tiba"},
            new Car {Id = 6,Name = "Runu"},
            new Car {Id = 7,Name = "Denu"},
            new Car {Id = 8,Name = "Quick"},
            new Car {Id = 9,Name = "Vanet"},
            new Car {Id = 10,Name = "206"},
            new Car {Id = 11,Name = "207"},
            new Car {Id = 12,Name = "H30Cras"},
            new Car {Id = 13,Name = "Arrizo"},
            new Car {Id = 14,Name = "Santafa"},
            new Car {Id = 15,Name = "MVM"},
        });

        base.OnModelCreating(modelBuilder);
    }
}