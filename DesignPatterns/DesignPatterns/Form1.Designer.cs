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
            this.textISS.Location = new System.Drawing.Point(172, 75);
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
            this.label3.Location = new System.Drawing.Point(171, 59);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
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
    }
}

