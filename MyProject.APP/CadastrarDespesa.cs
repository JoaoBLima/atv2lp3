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
    public partial class CadastrarDespesa : Form
    {
        public CadastrarDespesa()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            String valorS = textBox1.Text;
            String dataS = textBox2.Text;
            String login = textBox3.Text;

            decimal valor = decimal.Parse(valorS);
            DateTime data = DateTime.Parse(dataS);

            Usuario usuario = BLL.usuarioRepository.GetByLogin(login);

            Despesa despesa = new Despesa();
            despesa.Valor = valor;
            despesa.Data = data;
            despesa.Idusuario = usuario.Id;

            label5.Text = login;

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
