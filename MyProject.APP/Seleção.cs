﻿using MyProject.MODEL;
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
    public partial class Seleção : Form
    {
        public Seleção(String usuario)
        {
            InitializeComponent();
            label2.Text = usuario;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Form1 pagInicial = new Form1();
            pagInicial.ShowDialog();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] opcoes = { "Extrato da conta", "Cadastrar nova categoria de despesa",
                                "Cadastrar nova despesa", "Cadastrar nova receita"};
            comboBox1.Items.AddRange(opcoes);
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string valorSelecionado = comboBox1.SelectedItem.ToString();

                switch (valorSelecionado)
                {
                    case "Extrato da conta":
                        this.Hide();
                        Form3 extrato = new Form3();
                        extrato.ShowDialog();
                    
                        break;
                    case "Cadastrar nova categoria de despesa":
                        this.Hide();
                        CadastrarCategoria novaCategoria = new CadastrarCategoria();
                        novaCategoria.ShowDialog();
                        
                        break;
                    case "Cadastrar nova despesa":
                        this.Hide();
                        CadastrarDespesa novaDespesa = new CadastrarDespesa();
                        novaDespesa.ShowDialog();

                        break;
                    case "Cadastrar nova receita":
                        this.Hide();
                        CadastrarReceita novaReceita = new CadastrarReceita();
                        novaReceita.ShowDialog();
                        
                        break;
                    default:
                        MessageBox.Show("Opção não reconhecida");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma opção selecionada");
            }
        }

    }
}
