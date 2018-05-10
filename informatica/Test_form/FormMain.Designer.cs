namespace Test_form
{
    partial class FormMain
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
            System.Windows.Forms.Button btn_apri;
            btn_apri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_apri
            // 
            btn_apri.Location = new System.Drawing.Point(197, 227);
            btn_apri.Name = "btn_apri";
            btn_apri.Size = new System.Drawing.Size(75, 23);
            btn_apri.TabIndex = 0;
            btn_apri.Text = "Apri";
            btn_apri.UseVisualStyleBackColor = true;
            btn_apri.Click += new System.EventHandler(this.btn_apri_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(btn_apri);
            this.Name = "FormMain";
            this.Text = "Finestra Principale";
            this.ResumeLayout(false);

        }

        #endregion

    }
}

