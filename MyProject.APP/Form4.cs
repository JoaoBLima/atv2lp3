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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            this.Hide();
            inicio.ShowDialog();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            String nome = textBox1.Text;
            String login = textBox2.Text;
            String password = textBox3.Text;

            Usuario user = new Usuario();
            user.Nome = nome;
            user.Login = login;
            user.Senha = password;

            BLL.usuarioRepository.Add(user);

            if (BLL.usuarioRepository.AutenticaUsuario(login, password))
            {
                label5.Text = "Usuário cadastrado com sucesso!";
                label5.Visible = true;
            }
            else
            {
                label5.Text = "Não foi possível cadastrar o usuário";
                label5.Visible = true;
            }
        }

    }
}
