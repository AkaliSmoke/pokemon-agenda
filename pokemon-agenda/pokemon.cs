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
    internal class Pokemon
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
        string Nome;
        string Tipo;
        int Nivel;
        int Vida;
        int Dano;

        // Criação da função de inicialização padrão do meu objeto
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            //Nome = "Pikachu";
            //Tipo = "Elétrico";
            //Nivel = 5;
            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;
            Vida = 100;
            Dano = 20;
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
    }
}