namespace convertitore_temperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_far = new System.Windows.Forms.TextBox();
            this.btn_conv_fa = new System.Windows.Forms.Button();
            this.btn_conv_ce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_celsius
            // 
            this.txt_celsius.Location = new System.Drawing.Point(59, 43);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(61, 20);
            this.txt_celsius.TabIndex = 1;
            // 
            // txt_far
            // 
            this.txt_far.Location = new System.Drawing.Point(59, 91);
            this.txt_far.Name = "txt_far";
            this.txt_far.Size = new System.Drawing.Size(61, 20);
            this.txt_far.TabIndex = 2;
            // 
            // btn_conv_fa
            // 
            this.btn_conv_fa.Location = new System.Drawing.Point(179, 41);
            this.btn_conv_fa.Name = "btn_conv_fa";
            this.btn_conv_fa.Size = new System.Drawing.Size(75, 23);
            this.btn_conv_fa.TabIndex = 3;
            this.btn_conv_fa.Text = "converti";
            this.btn_conv_fa.UseVisualStyleBackColor = true;
            this.btn_conv_fa.Click += new System.EventHandler(this.btn_conv_fa_Click);
            // 
            // btn_conv_ce
            // 
            this.btn_conv_ce.Location = new System.Drawing.Point(179, 88);
            this.btn_conv_ce.Name = "btn_conv_ce";
            this.btn_conv_ce.Size = new System.Drawing.Size(75, 23);
            this.btn_conv_ce.TabIndex = 4;
            this.btn_conv_ce.Text = "converti";
            this.btn_conv_ce.UseVisualStyleBackColor = true;
            this.btn_conv_ce.Click += new System.EventHandler(this.btn_conv_ce_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_conv_ce);
            this.Controls.Add(this.btn_conv_fa);
            this.Controls.Add(this.txt_far);
            this.Controls.Add(this.txt_celsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_far;
        private System.Windows.Forms.Button btn_conv_fa;
        private System.Windows.Forms.Button btn_conv_ce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

