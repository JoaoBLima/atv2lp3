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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            decimal saldoAtual = BLL.ReceitaRepository.getSoma();
            saldoAtual.ToString();

            label2.Text = "Saldo atual: R$" + saldoAtual;
        }

    }
}
