using MusicaApi.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;
using System.Linq;
using MusicaApi.Modelos;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient cliente = new HttpClient())
        {
            try
            {
                string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

                //Mostrar todas as musicas da api
                //LinqFiltro.FiltrarTodosOsGeneros(musicas);
                LinqFiltro.FiltrarMusicasEmCsharp(musicas, "aG");
                //Exibir ficha técnica de uma musica
                //musicas[13].ExibirFichaTecnica();

                //Mostrar todos os artistas em ordem alfabetica
                //LinqOrdenar.ExibirListaArtistasOrdenados(musicas);

                //Mostrar todas as musicas de um estilo musical
                //LinqFiltro.FiltrarArtistasPorGeneroMusical(musicas, "rock") ;
                
                //Mostrar todas as musicas de um artista
                //LinqFiltro.FiltrarMusicasDeArtista(musicas, "Ariana Grande");


                //escolher musicas favoritas de um usuario
                //var playlistDoGabriel = new MusicasFavoritas("Gabriel");
                //playlistDoGabriel.AddPlaylistFavoritas(musicas[451]);
                //playlistDoGabriel.AddPlaylistFavoritas(musicas[134]);
                //playlistDoGabriel.AddPlaylistFavoritas(musicas[121]);
                //playlistDoGabriel.AddPlaylistFavoritas(musicas[131]);
                //playlistDoGabriel.AddPlaylistFavoritas(musicas[123]);
                //playlistDoGabriel.ExibirMusicasPreferidas();


            }


            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o seguinte erro:{ex.Message}");
            }

        }
    }
}