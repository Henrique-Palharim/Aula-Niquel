namespace CacaNiquel
{
    partial class frmMegaSena
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
            this.brSortearNumeros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidadeCartoes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // brSortearNumeros
            // 
            this.brSortearNumeros.Location = new System.Drawing.Point(224, 254);
            this.brSortearNumeros.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.brSortearNumeros.Name = "brSortearNumeros";
            this.brSortearNumeros.Size = new System.Drawing.Size(133, 87);
            this.brSortearNumeros.TabIndex = 1;
            this.brSortearNumeros.Text = "Sortear Números";
            this.brSortearNumeros.UseVisualStyleBackColor = true;
            this.brSortearNumeros.Click += new System.EventHandler(this.brSortearNumeros_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade de Cartões:";
            // 
            // txtQuantidadeCartoes
            // 
            this.txtQuantidadeCartoes.Location = new System.Drawing.Point(327, 25);
            this.txtQuantidadeCartoes.Name = "txtQuantidadeCartoes";
            this.txtQuantidadeCartoes.Size = new System.Drawing.Size(219, 35);
            this.txtQuantidadeCartoes.TabIndex = 3;
            // 
            // frmMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(593, 386);
            this.Controls.Add(this.txtQuantidadeCartoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brSortearNumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmMegaSena";
            this.Text = "Mega Sena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brSortearNumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidadeCartoes;
    }
}