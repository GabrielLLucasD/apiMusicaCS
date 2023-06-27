using ScreenSound_04.Modelos;
using System.Linq;


namespace MusicaApi.Filtros
{
    internal class LinqOrdenar
    {

        public static void ExibirListaArtistasOrdenados(List <Musica> musicas) {

            var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
                .Select(musica => musica.Artista).Distinct().ToList();

            Console.WriteLine("Lista de Artistas em ordem da Api:");

            foreach (var artista in artistasOrdenados)
                Console.WriteLine($"- {artista}"); 

        }
    }
}
