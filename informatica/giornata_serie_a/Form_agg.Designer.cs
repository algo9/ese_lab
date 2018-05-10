namespace giornata_serie_a
{
    partial class Form_agg
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
            this.nu_par = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_casa = new System.Windows.Forms.Button();
            this.btn_osp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nu_par)).BeginInit();
            this.SuspendLayout();
            // 
            // nu_par
            // 
            this.nu_par.Location = new System.Drawing.Point(111, 49);
            this.nu_par.Name = "nu_par";
            this.nu_par.Size = new System.Drawing.Size(78, 20);
            this.nu_par.TabIndex = 0;
            this.nu_par.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nu_par.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "partita";
            // 
            // btn_casa
            // 
            this.btn_casa.Location = new System.Drawing.Point(35, 115);
            this.btn_casa.Name = "btn_casa";
            this.btn_casa.Size = new System.Drawing.Size(75, 23);
            this.btn_casa.TabIndex = 4;
            this.btn_casa.Text = "goal casa";
            this.btn_casa.UseVisualStyleBackColor = true;
            this.btn_casa.Click += new System.EventHandler(this.btn_casa_Click);
            // 
            // btn_osp
            // 
            this.btn_osp.Location = new System.Drawing.Point(143, 115);
            this.btn_osp.Name = "btn_osp";
            this.btn_osp.Size = new System.Drawing.Size(75, 23);
            this.btn_osp.TabIndex = 5;
            this.btn_osp.Text = "goal ospiti";
            this.btn_osp.UseVisualStyleBackColor = true;
            this.btn_osp.Click += new System.EventHandler(this.btn_osp_Click);
            // 
            // Form_agg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_osp);
            this.Controls.Add(this.btn_casa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nu_par);
            this.Name = "Form_agg";
            this.Text = "Aggiorna";
            ((System.ComponentModel.ISupportInitialize)(this.nu_par)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nu_par;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_casa;
        private System.Windows.Forms.Button btn_osp;
    }
}