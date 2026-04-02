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
    public partial class FmCadastroPokemon : Form
    {
        /* objetivo da aula: aprender a criar e utilizar objetos
         * mini game pokemon
         * 1- montar meu time pokemon (6 pokemon) -> Listas
         * 2- treinar esse meu time pokemon (a cada treinamento ele recebe 2 nivel)
         * 3- batalhar com esse pokemon de forma randonica
         * sistema vai sortear 1 a 6 pokemon (somente os 151 primeiros)
         */
        
        BindingList<Pokemon> listaPokemon = new BindingList<Pokemon>();
        public FmCadastroPokemon()
        {
            InitializeComponent();
            // DataGridView Visualizador organizador de dados

            Pokemon p1 = new Pokemon("Pikachu", "Elétrico", 5);
            Pokemon p2 = new Pokemon("Charmander", "Fogo", 9);
            Pokemon p3 = new Pokemon("Bulbasaur", "Grama", 15);
            Pokemon p4 = new Pokemon("Squirtle", "Água", 29);

            listaPokemon.Add(p1);
            listaPokemon.Add(p2);
            listaPokemon.Add(p3);
            listaPokemon.Add(p4);

            dgvListaPokemon.DataSource = listaPokemon;
        }

        // disponibilidade retorno nome (funções) a função serve para reaproveitar codigos, definindo uma função eu posso reutilizar o codigos
        private void fnLimpar()
        {
            txtNome.Clear();
            cboTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text; //textBox
            string tipoPokemon = cboTipo.Text; //comboBox
            int nivelPokemon = (int)numNivel.Value; //numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);


            poke.fnDescricao();

            //MessageBox.Show($"O Pokémon {nomePokemon} do tipo {tipoPokemon} " +
            //  $"foi cadastrado com o nível {nivelPokemon}");

            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }

        private void dgvListaPokemon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FmCadastroPokemon_Load(object sender, EventArgs e)
        {
            
        }
    }
}
