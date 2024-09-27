using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Guia10_DSE.Models
{
    public class AgenciaDbContext : IdentityDbContext<Usuario>

    {
        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> options)
              : base(options) { }
        public DbSet<Marca> Marcas { get; set; }
            public DbSet<Modelo> Modelos { get; set; }
            public DbSet<Vehiculo> Vehiculos { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

            //seeds marca
            modelBuilder.Entity<Marca>().HasData(
                new Marca
                {
                    Id = 1,
                    NombreMarca = "Toyota"
                },
                 new Marca
                 {
                     Id = 2,
                     NombreMarca = "Ford"
                 }, new Marca
                 {
                     Id = 3,
                     NombreMarca = "Chevrolet"
                 });

            //seeds modelo
            modelBuilder.Entity<Modelo>().HasData(
                new Modelo
                {
                    Id = 1,
                    MarcaID = 1,
                    /*
                    Marca =
                    {
                        Id = 1,
                        NombreMarca = "Toyota"
                    },
                    */
                    NombreModelo = "Corolla"

                    
                },
                 new Modelo
                 {
                     Id = 2,
                     MarcaID = 1,
                     /*
                     Marca =
                    {
                        Id = 1,
                        NombreMarca = "Toyota"
                    },*/
                     NombreModelo = "Yaris"


                 });
            //seeds vehiculo
            modelBuilder.Entity<Vehiculo>().HasData(
                new Vehiculo
                {
                    Id = 1,
                    ModeloID = 1,
                    /*
                    Modelo =
                    {
                        Id = 1,
                        MarcaID = 1,
                        Marca =
                        {
                            Id = 1,
                            NombreMarca = "Toyota"
                        },
                   
                        NombreModelo = "Corolla"
                    }, */
                    FechaFabricacion = "2020"


                },
                 new Vehiculo
                 {
                     Id = 2,
                     ModeloID = 1,
                     /*
                     Modelo =
                    {
                        Id = 1,
                        MarcaID = 1,
                        Marca =
                        {
                            Id = 1,
                            NombreMarca = "Toyota"
                        },
                        NombreModelo = "Corolla"
                    },*/
                     FechaFabricacion = "2023"


                 });
        }


    }
}
