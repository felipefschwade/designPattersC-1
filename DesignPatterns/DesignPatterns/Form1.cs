using Empresa.DesignPatterns.Vendas;
using Empresa.DesignPatterns.Impostos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        Orcamento orcamento;
        ISS iss = new ISS();
        ICMS icms = new ICMS();
        ICC icc = new ICC();
        CalculadorDeImpostos calc = new CalculadorDeImpostos();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularImpostos_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = Convert.ToDouble(textOrcamento.Text);
                orcamento = new Orcamento(valor);
                var valorIss = calc.CalcularImposto(orcamento, iss);
                var valorIcms = calc.CalcularImposto(orcamento, icms);
                var valorIcc = calc.CalcularImposto(orcamento, icc);
                textICMS.Text = Convert.ToString(valorIcms);
                textISS.Text = Convert.ToString(valorIss);
                textICC.Text = Convert.ToString(valorIcc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("O campo valor do orçamento deve estar preenchido");
                textICMS.Text = "";
                textISS.Text = "";
                textICC.Text = "";
            }
        }
    }
}
