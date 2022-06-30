using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Luis_Henrique_da_Silva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btBlocoDeNotas_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGerarInscricao_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxNome.Text == "")
                {
                    MessageBox.Show("Digite o nome, por favor");
                }
                else if (cbCategoria.Text == "A")
                {
                    double A = 30.00;
                    textBoxValorInscricao.Text = A.ToString("C2");
                }
                else if (cbCategoria.Text == "B" && radioButtonNao.Checked == true)
                {
                    double B = 50.00;
                    textBoxValorInscricao.Text = B.ToString("C2");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Algo deu errado, tente novamente mais tarde!" + error.Message);
            }
        }

        private void btGerarFicha_Click(object sender, EventArgs e)
        {
            string Ficha = "Ficha " + textBoxNome.Text + ".txt";
            StreamWriter objFicha = new StreamWriter(Ficha);
            objFicha.WriteLine("___________________________________");
            objFicha.WriteLine("Nome: " + textBoxNome.Text);
            objFicha.WriteLine("Valor: " + textBoxValorInscricao.Text);
            objFicha.WriteLine(cbCategoria.Text);
            objFicha.WriteLine("___________________________________");
            objFicha.Close();
            MessageBox.Show("Ficha criada com sucesso.");

            textBoxNome.Clear();
            textBoxValorInscricao.Clear();
            radioButtonNao.Checked = false;
            radioButtonSim.Checked = false;
            cbCategoria.Text = "";

        }
    }
}
