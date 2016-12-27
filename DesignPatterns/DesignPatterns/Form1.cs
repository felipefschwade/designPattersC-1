using Empresa.DesignPatterns.Vendas;
using Empresa.DesignPatterns.Impostos;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Empresa.DesignPatterns.Vendas.Descontos;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        Orcamento orcamento;
        CalculadorDeImpostos calc = new CalculadorDeImpostos();
        List<Item> itens = new List<Item>();
        CalculadorDeDescontos calcDescontos = new CalculadorDeDescontos();
        
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
                var valorDesconto = calcDescontos.Calcula(orcamento);
                var valorImpostos = calc.CalcularImposto(orcamento, new ISS(new ICMS(new ICC(new IKCV(new IHIT(new ICPP(new ImpostoMuitoAlto())))))));
                textImpostos.Text = Convert.ToString(valorImpostos);
                textValorDesconto.Text = Convert.ToString(valorDesconto);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível calcular os impostos do orcamento");
                textImpostos.Text = "";
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

        private void bindingOrcamento_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
