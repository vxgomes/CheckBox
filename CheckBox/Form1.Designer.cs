namespace CheckBox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMaca = new System.Windows.Forms.CheckBox();
            this.checkBoxPera = new System.Windows.Forms.CheckBox();
            this.checkBoxBanana = new System.Windows.Forms.CheckBox();
            this.checkBoxUva = new System.Windows.Forms.CheckBox();
            this.checkBoxAbacaxi = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha a fruta:";
            // 
            // checkBoxMaca
            // 
            this.checkBoxMaca.AutoSize = true;
            this.checkBoxMaca.Location = new System.Drawing.Point(84, 155);
            this.checkBoxMaca.Name = "checkBoxMaca";
            this.checkBoxMaca.Size = new System.Drawing.Size(63, 20);
            this.checkBoxMaca.TabIndex = 1;
            this.checkBoxMaca.Text = "Maçã";
            this.checkBoxMaca.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxMaca.UseVisualStyleBackColor = true;
            // 
            // checkBoxPera
            // 
            this.checkBoxPera.AutoSize = true;
            this.checkBoxPera.Location = new System.Drawing.Point(84, 193);
            this.checkBoxPera.Name = "checkBoxPera";
            this.checkBoxPera.Size = new System.Drawing.Size(58, 20);
            this.checkBoxPera.TabIndex = 1;
            this.checkBoxPera.Text = "Pera";
            this.checkBoxPera.UseVisualStyleBackColor = true;
            // 
            // checkBoxBanana
            // 
            this.checkBoxBanana.AutoSize = true;
            this.checkBoxBanana.Location = new System.Drawing.Point(84, 232);
            this.checkBoxBanana.Name = "checkBoxBanana";
            this.checkBoxBanana.Size = new System.Drawing.Size(76, 20);
            this.checkBoxBanana.TabIndex = 1;
            this.checkBoxBanana.Text = "Banana";
            this.checkBoxBanana.UseVisualStyleBackColor = true;
            // 
            // checkBoxUva
            // 
            this.checkBoxUva.AutoSize = true;
            this.checkBoxUva.Location = new System.Drawing.Point(84, 275);
            this.checkBoxUva.Name = "checkBoxUva";
            this.checkBoxUva.Size = new System.Drawing.Size(54, 20);
            this.checkBoxUva.TabIndex = 1;
            this.checkBoxUva.Text = "Uva";
            this.checkBoxUva.UseVisualStyleBackColor = true;
            // 
            // checkBoxAbacaxi
            // 
            this.checkBoxAbacaxi.AutoSize = true;
            this.checkBoxAbacaxi.Location = new System.Drawing.Point(84, 317);
            this.checkBoxAbacaxi.Name = "checkBoxAbacaxi";
            this.checkBoxAbacaxi.Size = new System.Drawing.Size(78, 20);
            this.checkBoxAbacaxi.TabIndex = 1;
            this.checkBoxAbacaxi.Text = "Abacaxi";
            this.checkBoxAbacaxi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Escolha a Fruta ao lado e clique aqui!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxAbacaxi);
            this.Controls.Add(this.checkBoxUva);
            this.Controls.Add(this.checkBoxBanana);
            this.Controls.Add(this.checkBoxPera);
            this.Controls.Add(this.checkBoxMaca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMaca;
        private System.Windows.Forms.CheckBox checkBoxPera;
        private System.Windows.Forms.CheckBox checkBoxBanana;
        private System.Windows.Forms.CheckBox checkBoxUva;
        private System.Windows.Forms.CheckBox checkBoxAbacaxi;
        private System.Windows.Forms.Button button1;
    }
}

