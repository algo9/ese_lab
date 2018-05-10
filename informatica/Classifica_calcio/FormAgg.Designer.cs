namespace Classifica_calcio
{
    partial class FormAgg
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
            this.n_partita = new System.Windows.Forms.NumericUpDown();
            this.goal = new System.Windows.Forms.ComboBox();
            this.btn_aggiorna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_partita)).BeginInit();
            this.SuspendLayout();
            // 
            // n_partita
            // 
            this.n_partita.Location = new System.Drawing.Point(106, 51);
            this.n_partita.Name = "n_partita";
            this.n_partita.Size = new System.Drawing.Size(120, 20);
            this.n_partita.TabIndex = 0;
            this.n_partita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n_partita.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // goal
            // 
            this.goal.FormattingEnabled = true;
            this.goal.Items.AddRange(new object[] {
            "Casa",
            "Ospiti"});
            this.goal.Location = new System.Drawing.Point(105, 106);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(121, 21);
            this.goal.TabIndex = 1;
            // 
            // btn_aggiorna
            // 
            this.btn_aggiorna.Location = new System.Drawing.Point(151, 209);
            this.btn_aggiorna.Name = "btn_aggiorna";
            this.btn_aggiorna.Size = new System.Drawing.Size(75, 23);
            this.btn_aggiorna.TabIndex = 2;
            this.btn_aggiorna.Text = "Aggiorna";
            this.btn_aggiorna.UseVisualStyleBackColor = true;
            this.btn_aggiorna.Click += new System.EventHandler(this.btn_aggiorna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "N. partita";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Goal";
            // 
            // FormAgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_aggiorna);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.n_partita);
            this.Name = "FormAgg";
            this.Text = "FormAgg";
            ((System.ComponentModel.ISupportInitialize)(this.n_partita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown n_partita;
        private System.Windows.Forms.ComboBox goal;
        private System.Windows.Forms.Button btn_aggiorna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}