using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{

    /// <summary>
    /// Representa um Pokémon dentro da agenda, armazenando suas características e atributos de combate.
    /// </summary>
    public class Pokemon
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Pokemon""")/>> com atributos básicos definidos.
        /// </summary>
        /// <param name="nomePokemon">O nome da espécie do Pokémon (ex: Pikachu).</param>
        /// <param name="tipoPokemon">O elemento do Pokémon (ex: Elétrico).</param>
        /// <param name="nivelPokemon">O nível atual de experiência.</param>
        /// <list type="bullet">
        ///     <item>A Vida inicial é definida automaticamente como 100.</item>
        ///     <item>O Dano inicial é definido automaticamente como 20.</item>
        /// </list>

        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon

        // get set
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Dano { get; set; }

        // Criação da função de inicialização padrão do meu objeto
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            //Nome = "Pikachu";
            //Tipo = "Elétrico";
            //Nivel = 5;

            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;

            Vida = nivelPokemon * 70;
            Dano = nivelPokemon * 15;
        }

        /// <summary>
        /// Exibe uma caixa de mensagem contendo os detalhes completos do Pokémon.
        /// </summary>
        /// <list type="number">
        ///     <item>Coleta os dados de Nome, Tipo e Nível.</item>
        ///     <item>Adiciona os status de Vida e Dano.</item>
        ///     <item>Exibe o resultado via MessageBox.</item>
        /// </list>

        // public posso usar da função em qualquer espaço do meu projeto
        // private posso usar a função somente no meu arquivo original
        public void fnDescricao()
        {
            MessageBox.Show($"Pokemon: {Nome}, Tipo: {Tipo}, " +
                $"Nível: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }

        public string fnLinkImg()
        {
            string nomeTratado = Nome.Replace(" ", "-").Replace(".", "").ToLower();
            return $"https://pokemondb.net{nomeTratado}.jpg";
        }

        public void fnTreinar()
        {
            Nivel++;

            Vida = Nivel * 70;
            Dano = Nivel * 15;
        }
    }
}