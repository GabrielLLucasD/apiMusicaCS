using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaApi.Modelos
{
    internal class MusicasFavoritas
    {
        public String? Nome { get; set; }
        public List<Musica> MusicasFavoritasUsuario{ get; }

        public MusicasFavoritas(string nome) {

            Nome = nome;
            MusicasFavoritasUsuario = new List<Musica>();
        }
       
        public  void AddPlaylistFavoritas(Musica musica) {

            MusicasFavoritasUsuario.Add(musica);


        }


        public void ExibirMusicasPreferidas()
        {
            Console.WriteLine($"Veja as músicas preferidas de {Nome}:");

            foreach (var musica in MusicasFavoritasUsuario) {
                Console.WriteLine($"- {musica.Nome}");
            
            }


        }

    }
}
