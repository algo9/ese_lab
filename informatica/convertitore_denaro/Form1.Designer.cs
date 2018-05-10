namespace convertitore_denaro
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
            this.txt_euro = new System.Windows.Forms.TextBox();
            this.txt_dollari = new System.Windows.Forms.TextBox();
            this.btn_conv_doll = new System.Windows.Forms.Button();
            this.btn_conv_eu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_euro
            // 
            this.txt_euro.Location = new System.Drawing.Point(59, 43);
            this.txt_euro.Name = "txt_euro";
            this.txt_euro.Size = new System.Drawing.Size(61, 20);
            this.txt_euro.TabIndex = 1;
            // 
            // txt_dollari
            // 
            this.txt_dollari.Location = new System.Drawing.Point(59, 91);
            this.txt_dollari.Name = "txt_dollari";
            this.txt_dollari.Size = new System.Drawing.Size(61, 20);
            this.txt_dollari.TabIndex = 2;
            // 
            // btn_conv_doll
            // 
            this.btn_conv_doll.Location = new System.Drawing.Point(179, 41);
            this.btn_conv_doll.Name = "btn_conv_doll";
            this.btn_conv_doll.Size = new System.Drawing.Size(75, 23);
            this.btn_conv_doll.TabIndex = 3;
            this.btn_conv_doll.Text = "converti";
            this.btn_conv_doll.UseVisualStyleBackColor = true;
            this.btn_conv_doll.Click += new System.EventHandler(this.btn_conv_doll_Click);
            // 
            // btn_conv_eu
            // 
            this.btn_conv_eu.Location = new System.Drawing.Point(179, 88);
            this.btn_conv_eu.Name = "btn_conv_eu";
            this.btn_conv_eu.Size = new System.Drawing.Size(75, 23);
            this.btn_conv_eu.TabIndex = 4;
            this.btn_conv_eu.Text = "converti";
            this.btn_conv_eu.UseVisualStyleBackColor = true;
            this.btn_conv_eu.Click += new System.EventHandler(this.btn_conv_eu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "dollari";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_conv_eu);
            this.Controls.Add(this.btn_conv_doll);
            this.Controls.Add(this.txt_dollari);
            this.Controls.Add(this.txt_euro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_euro;
        private System.Windows.Forms.TextBox txt_dollari;
        private System.Windows.Forms.Button btn_conv_doll;
        private System.Windows.Forms.Button btn_conv_eu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

