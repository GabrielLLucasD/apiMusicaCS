using ScreenSound_04.Modelos;
using System.Linq;

namespace MusicaApi.Filtros
{
    internal class LinqFiltro
    {
       

        public static void FiltrarTodosOsGeneros(List<Musica> musicas)
        {

            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var genero in todosOsGenerosMusicais)
                Console.WriteLine($"- {genero}");

        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, String genero) {

            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine("Playslist separada e filtrada por gostos musicais");

            foreach (var artista in artistasPorGeneroMusical) {
                Console.WriteLine($"- {artista}");

            }

        }

        public static void FiltrarMusicasDeArtista(List<Musica> musicas, String artista) {

            var musicasDeArtistas = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();

            Console.WriteLine($"o artista: {artista}, possui as musicas:");

            foreach (var musica in musicasDeArtistas) {
                Console.WriteLine($"-{musica.Nome}");

            }
        }

        internal static void FiltrarMusicasEmCsharp(List <Musica> musicas, string tom)
        {
             string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

            if(tonalidades.Contains(tom)) {
                var musicasEMCsharp = musicas.Where(musica => musica.Tonalidade.Equals(tom)).
                  Select(musica => musica.Nome).ToList();

                Console.WriteLine($"Musicas em {tom}");

                foreach (var musica in musicasEMCsharp)
                {

                    Console.WriteLine($"- {musica}");

                }
            }
            else { Console.WriteLine($"A tonalidade - {tom} não existe."); }
          
          
        }
    }
    
}
