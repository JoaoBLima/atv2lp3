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
                Form2 formularioOpcoes = new Form2();
                formularioOpcoes.ShowDialog();

                this.Hide();
            }
            else
            {
                result = "Usuário não cadastrado";
                label3.Visible = true;
            }

        }

    }
}