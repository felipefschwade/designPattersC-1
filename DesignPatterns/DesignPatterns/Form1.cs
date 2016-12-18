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
        List<Item> itens = new List<Item>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularImpostos_Click(object sender, EventArgs e)
        {
            try
            {
                orcamento = new Orcamento(itens);
                textOrcamento.Text = Convert.ToString(orcamento.Valor);
                var valorIss = calc.CalcularImposto(orcamento, iss);
                var valorIcms = calc.CalcularImposto(orcamento, icms);
                var valorIcc = calc.CalcularImposto(orcamento, icc);
                textICMS.Text = Convert.ToString(valorIcms);
                textISS.Text = Convert.ToString(valorIss);
                textICC.Text = Convert.ToString(valorIcc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível calcular os impostos do orcamento");
                textICMS.Text = "";
                textISS.Text = "";
                textICC.Text = "";
            }
        }

        private void buttonAdiciona_Click(object sender, EventArgs e)
        {
            try
            {
                var valor = Convert.ToDouble(textValorItem.Text);
                var nome = textNomeItem.Text;
                itens.Add(new Item(nome, valor));
                MessageBox.Show("Item adicionado com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve adicionar um nome e um valor para o item");
                textNomeItem.Text = "";
                textValorItem.Text = "";
            }
            textNomeItem.Text = "";
            textValorItem.Text = "";
        }

        private void buttonMostraListaItens_Click(object sender, EventArgs e)
        {
            try
            {
                itens.ForEach(i => MessageBox.Show(string.Format("Produto: {0} Preço: {1}", i.Nome, i.Preco)));
            }
            catch (Exception)
            {
                MessageBox.Show("Lista vazia");
            }
        }
    }
}
