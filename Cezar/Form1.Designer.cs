namespace Cezar
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.encrypt_BTN = new System.Windows.Forms.Button();
            this.decrypt_BTN = new System.Windows.Forms.Button();
            this.input_TB = new System.Windows.Forms.TextBox();
            this.output_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.key_NUM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.key_NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // encrypt_BTN
            // 
            this.encrypt_BTN.Location = new System.Drawing.Point(147, 313);
            this.encrypt_BTN.Name = "encrypt_BTN";
            this.encrypt_BTN.Size = new System.Drawing.Size(75, 23);
            this.encrypt_BTN.TabIndex = 0;
            this.encrypt_BTN.Text = "Szyfruj";
            this.encrypt_BTN.UseVisualStyleBackColor = true;
            this.encrypt_BTN.Click += new System.EventHandler(this.encrypt_BTN_Click);
            // 
            // decrypt_BTN
            // 
            this.decrypt_BTN.Location = new System.Drawing.Point(506, 313);
            this.decrypt_BTN.Name = "decrypt_BTN";
            this.decrypt_BTN.Size = new System.Drawing.Size(75, 23);
            this.decrypt_BTN.TabIndex = 1;
            this.decrypt_BTN.Text = "Deszyfruj";
            this.decrypt_BTN.UseVisualStyleBackColor = true;
            this.decrypt_BTN.Click += new System.EventHandler(this.decrypt_BTN_Click);
            // 
            // input_TB
            // 
            this.input_TB.Location = new System.Drawing.Point(147, 56);
            this.input_TB.Multiline = true;
            this.input_TB.Name = "input_TB";
            this.input_TB.Size = new System.Drawing.Size(434, 117);
            this.input_TB.TabIndex = 2;
            this.input_TB.TextChanged += new System.EventHandler(this.input_TB_TextChanged);
            // 
            // output_TB
            // 
            this.output_TB.Location = new System.Drawing.Point(147, 179);
            this.output_TB.Multiline = true;
            this.output_TB.Name = "output_TB";
            this.output_TB.ReadOnly = true;
            this.output_TB.Size = new System.Drawing.Size(434, 109);
            this.output_TB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Przesuniecie";
            // 
            // key_NUM
            // 
            this.key_NUM.Location = new System.Drawing.Point(234, 16);
            this.key_NUM.Maximum = new decimal(new int[] {
            73,
            0,
            0,
            0});
            this.key_NUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.key_NUM.Name = "key_NUM";
            this.key_NUM.Size = new System.Drawing.Size(97, 20);
            this.key_NUM.TabIndex = 8;
            this.key_NUM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.key_NUM.ValueChanged += new System.EventHandler(this.key_NUM_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.key_NUM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_TB);
            this.Controls.Add(this.input_TB);
            this.Controls.Add(this.decrypt_BTN);
            this.Controls.Add(this.encrypt_BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.key_NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt_BTN;
        private System.Windows.Forms.Button decrypt_BTN;
        private System.Windows.Forms.TextBox input_TB;
        private System.Windows.Forms.TextBox output_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown key_NUM;
    }
}

