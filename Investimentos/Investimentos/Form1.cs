using System;
using Empresa.Investimentos.Investimentos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investimentos
{
    public partial class Form1 : Form
    {
        Conservador conservador = new Conservador();
        Arrojado arrojado = new Arrojado();
        Moderado moderado = new Moderado();
        public Form1()
        {
            InitializeComponent();
            comboTipoInvestimento.Items.Add(moderado);
            comboTipoInvestimento.Items.Add(arrojado);
            comboTipoInvestimento.Items.Add(conservador);
            comboTipoInvestimento.DisplayMember = "Nome";
            comboTipoInvestimento.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = Convert.ToDouble(textValorAInvestir.Text);
                Investimento tipoInvestimento = (Investimento)comboTipoInvestimento.SelectedItem;
                var valorAposInvestimento = CalculadorDeInvestimentos.CalculaInvestimento(tipoInvestimento, valor);
                textValorTotal.Text = Convert.ToString(valorAposInvestimento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Valor à investir deve ser um valor válido");
            }
        }
    }
}
