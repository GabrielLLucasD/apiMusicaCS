using MusicaApi.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient cliente = new HttpClient()) {
    try
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
       // LinqFitro.FiltrarTodosOsGeneros(musicas);
        LinqOrdenar.ExibirListaArtistasOrdenados(musicas);

    }
    

    catch(Exception ex) {
        Console.WriteLine($"Ocorreu o seguinte erro:{ex.Message}");
    }

}

