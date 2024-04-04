using backendnet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backendnet.Data.Seed;

public class SeedPelicula : IEntityTypeConfiguration<Pelicula>{

    public void Configure(EntityTypeBuilder<Pelicula> builder){
        builder.HasData(            
            new Pelicula{PeliculaId = 1, Titulo = "Sueño de fuga", Sinopsis="El banquero andy dufrense es arrestado por matar a su esposa", Anio =1994},
            new Pelicula {PeliculaId = 2, Titulo = "El padrino", Sinopsis="El patriarca de una organizacion criminal transfiere el cont", Anio = 1972},
            new Pelicula {PeliculaId = 3, Titulo = "El caballero oscuro", Sinopsis="cunado el joker emerge causando caos y violencia en", Anio= 2008},
            new Pelicula {PeliculaId = 4, Titulo = "El retorno del rey", Sinopsis="Gandalf y aragon lideran el mundo de los hombre,", Anio =2003},
            new Pelicula {PeliculaId = 5, Titulo = "Tiempos violentos", Sinopsis="Las vidas de dos mafiosos, un boxeador, la esposa de", Anio =1974},
            new Pelicula {PeliculaId = 6, Titulo = "Forest Gump", Sinopsis="Las predecidenciales de kennedy y Jonhson, los eventos de viet", Anio= 1994},
            new Pelicula {PeliculaId = 7, Titulo = "El club de la pelea", Sinopsis="Un hombre deprimido conoce a un fabricante de jabon", Anio= 1999},
            new Pelicula {PeliculaId = 8, Titulo = "Inception", Sinopsis="A un ladron que roba secretos corporativos a traves de la tec", Anio=2010},
            new Pelicula {PeliculaId = 9, Titulo = "Star wars", Sinopsis="Los rebeldes han vencido", Anio=1970},
            new Pelicula {PeliculaId = 10, Titulo = "Matrix", Sinopsis="Un hacker se da cuenta por medio de otros rebeldes de la natiraleza", Anio=1999},
            new Pelicula {PeliculaId = 11, Titulo = "Interestelar", Sinopsis="Un grupo de exploradores prueban los saltos a traves de", Anio=2014},
            new Pelicula {PeliculaId = 12, Titulo = "Dune: parte dos", Sinopsis="paul atreides se une a chani u los fremen mientras", Anio=2024},
            new Pelicula {PeliculaId = 13, Titulo = "Terminator 2", Sinopsis="Un cyborg, identico al que fracaso",Anio =1991},
            new Pelicula {PeliculaId = 14, Titulo = "Volver al futuro", Sinopsis="Marty Mcfly, un estudiante de 17 años, es enviado", Anio=1985},
            new Pelicula {PeliculaId = 15, Titulo = "Barbie", Sinopsis="Vivir en Barbie land es ser perfecto en un lugar perfecto", Anio=2023}
         
        );
    }

}