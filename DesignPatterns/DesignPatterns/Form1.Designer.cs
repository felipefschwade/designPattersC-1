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
            // 
            // textOrcamento
            // 
            this.textOrcamento.Location = new System.Drawing.Point(12, 29);
            this.textOrcamento.Name = "textOrcamento";
            this.textOrcamento.ReadOnly = true;
            this.textOrcamento.Size = new System.Drawing.Size(100, 20);
            this.textOrcamento.TabIndex = 1;
            // 
            // textICMS
            // 
            this.textICMS.Cursor = System.Windows.Forms.Cursors.No;
            this.textICMS.Location = new System.Drawing.Point(172, 29);
            this.textICMS.Name = "textICMS";
            this.textICMS.ReadOnly = true;
            this.textICMS.Size = new System.Drawing.Size(100, 20);
            this.textICMS.TabIndex = 2;
            // 
            // textISS
            // 
            this.textISS.Cursor = System.Windows.Forms.Cursors.No;
            this.textISS.Location = new System.Drawing.Point(172, 71);
            this.textISS.Name = "textISS";
            this.textISS.ReadOnly = true;
            this.textISS.Size = new System.Drawing.Size(100, 20);
            this.textISS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor do ICMS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor do ISS";
            // 
            // calcularImpostos
            // 
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
            this.textICC.Cursor = System.Windows.Forms.Cursors.No;
            this.textICC.Location = new System.Drawing.Point(172, 111);
            this.textICC.Name = "textICC";
            this.textICC.ReadOnly = true;
            this.textICC.Size = new System.Drawing.Size(100, 20);
            this.textICC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor do ICC";
            // 
            // buttonAdiciona
            // 
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome do Item";
            // 
            // textValorItem
            // 
            this.textValorItem.Location = new System.Drawing.Point(8, 158);
            this.textValorItem.Name = "textValorItem";
            this.textValorItem.Size = new System.Drawing.Size(100, 20);
            this.textValorItem.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor do Item";
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
            // 
            // buttonMostraListaItens
            // 
            this.buttonMostraListaItens.Location = new System.Drawing.Point(12, 258);
            this.buttonMostraListaItens.Name = "buttonMostraListaItens";
            this.buttonMostraListaItens.Size = new System.Drawing.Size(96, 23);
            this.buttonMostraListaItens.TabIndex = 15;
            this.buttonMostraListaItens.Text = "Lista Atual";
            this.buttonMostraListaItens.UseVisualStyleBackColor = true;
            this.buttonMostraListaItens.Click += new System.EventHandler(this.buttonMostraListaItens_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

