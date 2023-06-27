using ScreenSound_04.Modelos;



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
    }
    
}
