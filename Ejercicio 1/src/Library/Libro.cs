using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; } // Deberia pertenecer a otra clase Biblioteca
        public string EstanteBiblioteca { get ; set; } // Deberia pertenecer a otra clase Biblioteca 

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        //  El metodo deberia pertencer a la clase Biblioteca
        // La clase Libro seria un colaborador de la clase Biblioteca
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
