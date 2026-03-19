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
        public FmCadastroPokemon()
        {
            InitializeComponent();
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
            string nomePokemon = txtNome.Text; // TextBox
            string tipoPokemon = cboTipo.Text; // ComboBox
            int nivelPokemon = (int)numNivel.Value; // NumericUpDown

            MessageBox.Show($"O Pokémon {nomePokemon} do tipo {tipoPokemon} " +
                $"foi cadastrado com o nível {nivelPokemon}");

            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }
    }
}
