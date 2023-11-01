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

            try
            {
                if (MyProject.BLL.usuarioRepository.AutenticaUsuario(loginInput, senhaInput))
                {
                    this.Hide();

                    Sele��o formularioOpcoes = new Sele��o(loginInput);
                    formularioOpcoes.ShowDialog();
                }
                else
                {
                    label3.Text = "Usu�rio n�o cadastrado";
                    label3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                label3.Text = "N�o foi poss�vel realizar o login: " + ex.Message;
                label3.Visible = true;
                senhaTxt.Text = "";
            }


        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            Form4 cadastro = new Form4();
            cadastro.ShowDialog();
            this.Close();
        }

    }
}