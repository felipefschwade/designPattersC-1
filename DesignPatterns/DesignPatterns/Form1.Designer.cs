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
            this.textICMS = new System.Windows.Forms.TextBox();
            this.textISS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcularImpostos = new System.Windows.Forms.Button();
            this.textICC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdiciona = new System.Windows.Forms.Button();
            this.textNomeItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textValorItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMostraListaItens = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textValorDesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textICPP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textIKCV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textIHIT = new System.Windows.Forms.TextBox();
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
            // textICMS
            // 
            this.textICMS.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textICMS.Location = new System.Drawing.Point(302, 20);
            this.textICMS.Name = "textICMS";
            this.textICMS.ReadOnly = true;
            this.textICMS.Size = new System.Drawing.Size(100, 20);
            this.textICMS.TabIndex = 2;
            this.textICMS.UseWaitCursor = true;
            // 
            // textISS
            // 
            this.textISS.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textISS.Location = new System.Drawing.Point(302, 62);
            this.textISS.Name = "textISS";
            this.textISS.ReadOnly = true;
            this.textISS.Size = new System.Drawing.Size(100, 20);
            this.textISS.TabIndex = 3;
            this.textISS.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor do ICMS";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor do ISS";
            this.label3.UseWaitCursor = true;
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
            // textICC
            // 
            this.textICC.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textICC.Location = new System.Drawing.Point(302, 102);
            this.textICC.Name = "textICC";
            this.textICC.ReadOnly = true;
            this.textICC.Size = new System.Drawing.Size(100, 20);
            this.textICC.TabIndex = 7;
            this.textICC.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do ICC";
            this.label4.UseWaitCursor = true;
            // 
            // buttonAdiciona
            // 
            this.buttonAdiciona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdiciona.Location = new System.Drawing.Point(12, 227);
            this.buttonAdiciona.Name = "buttonAdiciona";
            this.buttonAdiciona.Size = new System.Drawing.Size(96, 23);
            this.buttonAdiciona.TabIndex = 11;
            this.buttonAdiciona.Text = "Adicionar";
            this.buttonAdiciona.UseVisualStyleBackColor = true;
            this.buttonAdiciona.Click += new System.EventHandler(this.buttonAdiciona_Click);
            // 
            // textNomeItem
            // 
            this.textNomeItem.Location = new System.Drawing.Point(8, 197);
            this.textNomeItem.Name = "textNomeItem";
            this.textNomeItem.Size = new System.Drawing.Size(100, 20);
            this.textNomeItem.TabIndex = 10;
            this.textNomeItem.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Item";
            this.label5.UseWaitCursor = true;
            // 
            // textValorItem
            // 
            this.textValorItem.Location = new System.Drawing.Point(8, 158);
            this.textValorItem.Name = "textValorItem";
            this.textValorItem.Size = new System.Drawing.Size(100, 20);
            this.textValorItem.TabIndex = 13;
            this.textValorItem.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor do Item";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valor do Orçamento";
            this.label7.UseWaitCursor = true;
            // 
            // buttonMostraListaItens
            // 
            this.buttonMostraListaItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMostraListaItens.Location = new System.Drawing.Point(12, 258);
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
            this.label8.Location = new System.Drawing.Point(362, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valor do Desconto";
            this.label8.UseWaitCursor = true;
            // 
            // textValorDesconto
            // 
            this.textValorDesconto.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textValorDesconto.Location = new System.Drawing.Point(357, 141);
            this.textValorDesconto.Name = "textValorDesconto";
            this.textValorDesconto.ReadOnly = true;
            this.textValorDesconto.Size = new System.Drawing.Size(100, 20);
            this.textValorDesconto.TabIndex = 16;
            this.textValorDesconto.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor do ICPP";
            this.label9.UseWaitCursor = true;
            // 
            // textICPP
            // 
            this.textICPP.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textICPP.Location = new System.Drawing.Point(420, 20);
            this.textICPP.Name = "textICPP";
            this.textICPP.ReadOnly = true;
            this.textICPP.Size = new System.Drawing.Size(100, 20);
            this.textICPP.TabIndex = 18;
            this.textICPP.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Valor do IKCV";
            this.label10.UseWaitCursor = true;
            // 
            // textIKCV
            // 
            this.textIKCV.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textIKCV.Location = new System.Drawing.Point(420, 62);
            this.textIKCV.Name = "textIKCV";
            this.textIKCV.ReadOnly = true;
            this.textIKCV.Size = new System.Drawing.Size(100, 20);
            this.textIKCV.TabIndex = 20;
            this.textIKCV.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Valor do IHIT";
            this.label11.UseWaitCursor = true;
            // 
            // textIHIT
            // 
            this.textIHIT.Cursor = System.Windows.Forms.Cursors.No;
            this.textIHIT.Location = new System.Drawing.Point(420, 102);
            this.textIHIT.Name = "textIHIT";
            this.textIHIT.ReadOnly = true;
            this.textIHIT.Size = new System.Drawing.Size(100, 20);
            this.textIHIT.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 302);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textIHIT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textIKCV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textICPP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textValorDesconto);
            this.Controls.Add(this.buttonMostraListaItens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textValorItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAdiciona);
            this.Controls.Add(this.textNomeItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textICC);
            this.Controls.Add(this.calcularImpostos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textISS);
            this.Controls.Add(this.textICMS);
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
        private System.Windows.Forms.TextBox textICMS;
        private System.Windows.Forms.TextBox textISS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcularImpostos;
        private System.Windows.Forms.TextBox textICC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdiciona;
        private System.Windows.Forms.TextBox textNomeItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textValorItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMostraListaItens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textValorDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textICPP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textIKCV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textIHIT;
    }
}

