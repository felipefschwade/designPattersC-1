namespace DesignPatterns
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textOrcamento = new System.Windows.Forms.TextBox();
            this.textImpostos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calcularImpostos = new System.Windows.Forms.Button();
            this.buttonAdiciona = new System.Windows.Forms.Button();
            this.textNomeItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textValorItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMostraListaItens = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textValorDesconto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Orçamento";
            this.label1.UseWaitCursor = true;
            // 
            // textOrcamento
            // 
            this.textOrcamento.Location = new System.Drawing.Point(12, 29);
            this.textOrcamento.Name = "textOrcamento";
            this.textOrcamento.ReadOnly = true;
            this.textOrcamento.Size = new System.Drawing.Size(100, 20);
            this.textOrcamento.TabIndex = 1;
            this.textOrcamento.UseWaitCursor = true;
            // 
            // textImpostos
            // 
            this.textImpostos.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textImpostos.Location = new System.Drawing.Point(394, 29);
            this.textImpostos.Name = "textImpostos";
            this.textImpostos.ReadOnly = true;
            this.textImpostos.Size = new System.Drawing.Size(100, 20);
            this.textImpostos.TabIndex = 2;
            this.textImpostos.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor dos Impostos";
            this.label2.UseWaitCursor = true;
            // 
            // calcularImpostos
            // 
            this.calcularImpostos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcularImpostos.Location = new System.Drawing.Point(16, 59);
            this.calcularImpostos.Name = "calcularImpostos";
            this.calcularImpostos.Size = new System.Drawing.Size(96, 23);
            this.calcularImpostos.TabIndex = 6;
            this.calcularImpostos.Text = "Calcular";
            this.calcularImpostos.UseVisualStyleBackColor = true;
            this.calcularImpostos.Click += new System.EventHandler(this.calcularImpostos_Click);
            // 
            // buttonAdiciona
            // 
            this.buttonAdiciona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdiciona.Location = new System.Drawing.Point(200, 92);
            this.buttonAdiciona.Name = "buttonAdiciona";
            this.buttonAdiciona.Size = new System.Drawing.Size(96, 23);
            this.buttonAdiciona.TabIndex = 11;
            this.buttonAdiciona.Text = "Adicionar";
            this.buttonAdiciona.UseVisualStyleBackColor = true;
            this.buttonAdiciona.Click += new System.EventHandler(this.buttonAdiciona_Click);
            // 
            // textNomeItem
            // 
            this.textNomeItem.Location = new System.Drawing.Point(196, 62);
            this.textNomeItem.Name = "textNomeItem";
            this.textNomeItem.Size = new System.Drawing.Size(100, 20);
            this.textNomeItem.TabIndex = 10;
            this.textNomeItem.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Item";
            this.label5.UseWaitCursor = true;
            // 
            // textValorItem
            // 
            this.textValorItem.Location = new System.Drawing.Point(196, 23);
            this.textValorItem.Name = "textValorItem";
            this.textValorItem.Size = new System.Drawing.Size(100, 20);
            this.textValorItem.TabIndex = 13;
            this.textValorItem.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor do Item";
            this.label6.UseWaitCursor = true;
            // 
            // buttonMostraListaItens
            // 
            this.buttonMostraListaItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostraListaItens.Location = new System.Drawing.Point(200, 123);
            this.buttonMostraListaItens.Name = "buttonMostraListaItens";
            this.buttonMostraListaItens.Size = new System.Drawing.Size(96, 23);
            this.buttonMostraListaItens.TabIndex = 15;
            this.buttonMostraListaItens.Text = "Lista Atual";
            this.buttonMostraListaItens.UseVisualStyleBackColor = true;
            this.buttonMostraListaItens.Click += new System.EventHandler(this.buttonMostraListaItens_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valor do Desconto";
            this.label8.UseWaitCursor = true;
            // 
            // textValorDesconto
            // 
            this.textValorDesconto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textValorDesconto.Location = new System.Drawing.Point(394, 71);
            this.textValorDesconto.Name = "textValorDesconto";
            this.textValorDesconto.ReadOnly = true;
            this.textValorDesconto.Size = new System.Drawing.Size(100, 20);
            this.textValorDesconto.TabIndex = 16;
            this.textValorDesconto.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(506, 302);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textValorDesconto);
            this.Controls.Add(this.buttonMostraListaItens);
            this.Controls.Add(this.textValorItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAdiciona);
            this.Controls.Add(this.textNomeItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcularImpostos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textImpostos);
            this.Controls.Add(this.textOrcamento);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Orçamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOrcamento;
        private System.Windows.Forms.TextBox textImpostos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcularImpostos;
        private System.Windows.Forms.Button buttonAdiciona;
        private System.Windows.Forms.TextBox textNomeItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textValorItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMostraListaItens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textValorDesconto;
    }
}

