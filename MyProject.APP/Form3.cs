using Microsoft.VisualBasic;
using MyProject.BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProject.APP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            decimal receita = BLL.ReceitaRepository.getSoma();
            decimal despesa = BLL.DespesaRepository.getSoma();
            decimal saldoAtual = receita - despesa;
            saldoAtual.ToString();

            label2.Text = "Saldo atual: R$" + saldoAtual;
        }

        private void PopularGrade()
        {
            List<Receita> receitas = ReceitaRepository.GetAll();

            foreach (Receita receita in receitas)
            {
                string[] item = new string[3];

                Receita receita1 = ReceitaRepository.GetById(receita.Id);
                item[0] = receita1.IdCategoria.ToString();
                item[1] = receita1.Valor.ToString();
                DateTime dataHora = (DateTime)receita1.Data;
                string dataFormatada = dataHora.ToString("dd/MM/yyyy");
                item[2] = dataFormatada;

                ListViewItem l = new ListViewItem(item);

                listView1.Items.Add(l);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularGrade();
        }

        /*private void preencherListView(object sender, EventArgs e)
        {
            List<Receita> receitas = BLL.ReceitaRepository.GetAll();

            foreach (Receita receita in receitas)
            {
                listView1.Items.Add(receita);
            }

        }*/

    }
}