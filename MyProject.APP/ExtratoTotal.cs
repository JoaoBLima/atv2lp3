using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.APP
{
    public partial class ExtratoTotal : Form
    {
        public ExtratoTotal()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\atv2lp3\\MyProject.DAL\\database\\Database1.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            string query = "select * from Despesa union Receita where Despesa.Idusuario == id_usuario";

            SqlCommand cmd = new SqlCommand(query, connection);

            var reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dataGridView1.DataSource = dt;

            connection.Close();
        }
    }
}
