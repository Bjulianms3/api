﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendnet.Data;

#nullable disable

namespace backendnet.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculasPeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "PeliculasPeliculaId");

                    b.HasIndex("PeliculasPeliculaId");

                    b.ToTable("CategoriaPelicula");
                });

            modelBuilder.Entity("backendnet.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Protegida")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            Nombre = "Accion",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 2,
                            Nombre = "Aventura",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 3,
                            Nombre = "Animacion",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 4,
                            Nombre = "Ciencia ficcion",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 5,
                            Nombre = "Comedia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 6,
                            Nombre = "Crimen",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 7,
                            Nombre = "Documental",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 8,
                            Nombre = "Drama",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 9,
                            Nombre = "Familiar",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 10,
                            Nombre = "Fantasia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 11,
                            Nombre = "Historia",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 12,
                            Nombre = "Horror",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 13,
                            Nombre = "Musica",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 14,
                            Nombre = "Misterio",
                            Protegida = true
                        },
                        new
                        {
                            CategoriaId = 15,
                            Nombre = "Romance",
                            Protegida = true
                        });
                });

            modelBuilder.Entity("backendnet.Models.Pelicula", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PeliculaId"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PeliculaId");

                    b.ToTable("Pelicula");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Anio = 1994,
                            Poster = "N/A",
                            Sinopsis = "El banquero andy dufrense es arrestado por matar a su esposa",
                            Titulo = "Sueño de fuga"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Anio = 1972,
                            Poster = "N/A",
                            Sinopsis = "El patriarca de una organizacion criminal transfiere el cont",
                            Titulo = "El padrino"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Anio = 2008,
                            Poster = "N/A",
                            Sinopsis = "cunado el joker emerge causando caos y violencia en",
                            Titulo = "El caballero oscuro"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Anio = 2003,
                            Poster = "N/A",
                            Sinopsis = "Gandalf y aragon lideran el mundo de los hombre,",
                            Titulo = "El retorno del rey"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Anio = 1974,
                            Poster = "N/A",
                            Sinopsis = "Las vidas de dos mafiosos, un boxeador, la esposa de",
                            Titulo = "Tiempos violentos"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Anio = 1994,
                            Poster = "N/A",
                            Sinopsis = "Las predecidenciales de kennedy y Jonhson, los eventos de viet",
                            Titulo = "Forest Gump"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Anio = 1999,
                            Poster = "N/A",
                            Sinopsis = "Un hombre deprimido conoce a un fabricante de jabon",
                            Titulo = "El club de la pelea"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Anio = 2010,
                            Poster = "N/A",
                            Sinopsis = "A un ladron que roba secretos corporativos a traves de la tec",
                            Titulo = "Inception"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Anio = 1970,
                            Poster = "N/A",
                            Sinopsis = "Los rebeldes han vencido",
                            Titulo = "Star wars"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Anio = 1999,
                            Poster = "N/A",
                            Sinopsis = "Un hacker se da cuenta por medio de otros rebeldes de la natiraleza",
                            Titulo = "Matrix"
                        },
                        new
                        {
                            PeliculaId = 11,
                            Anio = 2014,
                            Poster = "N/A",
                            Sinopsis = "Un grupo de exploradores prueban los saltos a traves de",
                            Titulo = "Interestelar"
                        },
                        new
                        {
                            PeliculaId = 12,
                            Anio = 2024,
                            Poster = "N/A",
                            Sinopsis = "paul atreides se une a chani u los fremen mientras",
                            Titulo = "Dune: parte dos"
                        },
                        new
                        {
                            PeliculaId = 13,
                            Anio = 1991,
                            Poster = "N/A",
                            Sinopsis = "Un cyborg, identico al que fracaso",
                            Titulo = "Terminator 2"
                        },
                        new
                        {
                            PeliculaId = 14,
                            Anio = 1985,
                            Poster = "N/A",
                            Sinopsis = "Marty Mcfly, un estudiante de 17 años, es enviado",
                            Titulo = "Volver al futuro"
                        },
                        new
                        {
                            PeliculaId = 15,
                            Anio = 2023,
                            Poster = "N/A",
                            Sinopsis = "Vivir en Barbie land es ser perfecto en un lugar perfecto",
                            Titulo = "Barbie"
                        });
                });

            modelBuilder.Entity("CategoriaPelicula", b =>
                {
                    b.HasOne("backendnet.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendnet.Models.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasPeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
