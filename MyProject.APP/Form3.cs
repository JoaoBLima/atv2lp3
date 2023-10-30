using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.APP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] opcoes = { "Conta", "Despesa", "Receita" };
            comboBox1.Items.AddRange(opcoes);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string valorSelecionado = comboBox1.SelectedItem.ToString();

                switch (valorSelecionado)
                {
                    case "Conta":
                        break;
                    case "Despesa":
                        break;
                    case "Receita":
                        break;
                    default:
                        MessageBox.Show("Opção não reconhecida");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma opção selecionada");
            }
        }
    }
}
