using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public partial class FormDetalhesPokemon : Form
    {
        public Pokemon PokemonRecebido {  get; set; }
        public FormDetalhesPokemon()
        {
            InitializeComponent();

            lbNome.Text = PokemonRecebido.Nome;
            lbTipo.Text = PokemonRecebido.Tipo;
            lbNivel.Text = PokemonRecebido.Nivel.ToString();
        }
    }
}
