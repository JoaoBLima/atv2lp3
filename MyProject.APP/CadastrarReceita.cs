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
    public partial class CadastrarReceita : Form
    {
        public CadastrarReceita()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String valorS = textBox1.Text;
            String dataS = textBox2.Text;
            String login = textBox3.Text;

            decimal valor = decimal.Parse(valorS);
            DateTime data = DateTime.Parse(dataS);

            Usuario usuario = BLL.usuarioRepository.GetByLogin(login);

            Receita receita = new Receita();
            receita.Valor = valor;
            receita.Data = data;
            receita.Idusuario = usuario.Id;

            label5.Text = login;

            BLL.ReceitaRepository.Add(receita);
            label5.Text = "Receita cadastrada";
            label5.Visible = true;

        }

        private void btVoltar_CLick(object sender, EventArgs e)
        {
            
        }
    }
}
