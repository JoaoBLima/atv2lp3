using MyProject.MODEL;
using System;
using System.Collections;
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
    public partial class CadastrarDespesa : Form
    {
        public CadastrarDespesa()
        {
            InitializeComponent();
        }

        private void Despesa_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<Categorium> categorias = BLL.CategoriaRepository.GetAll();

            foreach (Categorium categoria in categorias)
            {
                comboBox1.Items.Add(categoria.Nome);
            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String valorS = textBox1.Text;
            String dataS = textBox2.Text;
            String login = textBox3.Text;
            String categoriaSelecionada = comboBox1.SelectedItem.ToString();

            decimal valor = decimal.Parse(valorS);
            DateTime data = DateTime.Parse(dataS);

            Usuario usuario = BLL.usuarioRepository.GetByLogin(login);
            Categorium categoria = BLL.CategoriaRepository.GetByNome(categoriaSelecionada);

            Despesa despesa = new Despesa();
            despesa.Valor = valor;
            despesa.Data = data;
            despesa.Idusuario = usuario.Id;
            despesa.Idcategoria = categoria.Id;

            BLL.DespesaRepository.Add(despesa);
            label5.Text = "Despesa cadastrada";
            label5.Visible = true;

        }

        private void btVoltar_CLick(object sender, EventArgs e)
        {

            String login = textBox3.Text;
            Usuario usuario = BLL.usuarioRepository.GetByLogin(login);
            String user = usuario.ToString();

            this.Close();
            Seleção voltar = new Seleção(user);
            voltar.ShowDialog();
        }
    }
}
