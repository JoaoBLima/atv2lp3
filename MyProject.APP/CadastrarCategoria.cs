using MyProject.MODEL;
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
    public partial class CadastrarCategoria : Form
    {
        public CadastrarCategoria()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String cat = textBox3.Text;
            String descricao = textBox1.Text;

            Categorium categoria = new Categorium();
            categoria.Nome = cat;
            categoria.Descricao = descricao;

            BLL.CategoriaRepository.Add(categoria);
            label5.Text = "Categoria cadastrada";
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
