namespace WindowsFormsApp4
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
            this.txt_try = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_alto = new System.Windows.Forms.Label();
            this.lbl_baixo = new System.Windows.Forms.Label();
            this.Submeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_try
            // 
            this.txt_try.Location = new System.Drawing.Point(153, 70);
            this.txt_try.Name = "txt_try";
            this.txt_try.Size = new System.Drawing.Size(100, 20);
            this.txt_try.TabIndex = 0;
            this.txt_try.TextChanged += new System.EventHandler(this.txt_try_TextChanged);
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(71, 70);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 1;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_alto
            // 
            this.lbl_alto.AutoSize = true;
            this.lbl_alto.Location = new System.Drawing.Point(292, 69);
            this.lbl_alto.Name = "lbl_alto";
            this.lbl_alto.Size = new System.Drawing.Size(50, 13);
            this.lbl_alto.TabIndex = 2;
            this.lbl_alto.Text = "Mais Alto";
            this.lbl_alto.Click += new System.EventHandler(this.lbl_alto_Click);
            // 
            // lbl_baixo
            // 
            this.lbl_baixo.AutoSize = true;
            this.lbl_baixo.Location = new System.Drawing.Point(292, 82);
            this.lbl_baixo.Name = "lbl_baixo";
            this.lbl_baixo.Size = new System.Drawing.Size(58, 13);
            this.lbl_baixo.TabIndex = 3;
            this.lbl_baixo.Text = "Mais Baixo";
            // 
            // Submeter
            // 
            this.Submeter.Location = new System.Drawing.Point(166, 127);
            this.Submeter.Name = "Submeter";
            this.Submeter.Size = new System.Drawing.Size(75, 23);
            this.Submeter.TabIndex = 4;
            this.Submeter.Text = "Submeter";
            this.Submeter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.Submeter);
            this.Controls.Add(this.lbl_baixo);
            this.Controls.Add(this.lbl_alto);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_try);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_try;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_alto;
        private System.Windows.Forms.Label lbl_baixo;
        private System.Windows.Forms.Button Submeter;
    }
}

