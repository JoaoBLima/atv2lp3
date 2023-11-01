using MyProject.BLL;
using MyProject.MODEL;

namespace MyProject.APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            string loginInput = loginTxt.Text;
            string senhaInput = senhaTxt.Text;

            string result = label3.Text;

            if (MyProject.BLL.usuarioRepository.AutenticaUsuario(loginInput, senhaInput))
            {
                Sele��o formularioOpcoes = new Sele��o(loginInput);
                this.Hide();
                formularioOpcoes.ShowDialog();
            }
            else
            {
                result = "Usu�rio n�o cadastrado";
                label3.Visible = true;
            }

        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            Form4 cadastro = new Form4();
            this.Hide();
            cadastro.ShowDialog();
        }

    }
}