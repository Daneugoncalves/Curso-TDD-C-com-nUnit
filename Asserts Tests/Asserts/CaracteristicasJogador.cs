using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asserts
{
    public class CaracteristicasJogador
    {
        public int Vida { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public bool NovoJogador { get; set; }
        public List<string> Armas { get; set; }


        // Classe construtor caracteristicas
        public CaracteristicasJogador()
        {
            Nome = GerarNome();
            NovoJogador = true;
            CriarArmasIniciais();
        }


        // Método que aumenta vida
        public void Dormir()
        {
            var random = new Random();

            var aumentarVida = random.Next(1, 101);

            Vida += aumentarVida;
        }

        // Método que tira vida
        public void PerderVida(int perderVida)
        {
            Vida = Math.Max(1, Vida -= perderVida);
        }

        // Método que gera nomes random
        private string GerarNome()
        {
            var nomes = new[]
            {
             "Jogador 01",
             "Jogador 02",
             "Jogador 03",
             "Jogador 04",
             "Jogador 05"
            };

            return nomes[new Random().Next(0, nomes.Length)];
        }

        private void CriarArmasIniciais()
        {
            Armas = new List<string>()
            {
                "Escudo",
                "Espada",
                "Espada Medieval",
                "Katana",
                "Lança",
                "Nunchaku"
            };
        }

    }
}
