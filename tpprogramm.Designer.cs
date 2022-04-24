
namespace trabajoprogram
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmess = new System.Windows.Forms.TextBox();
            this.btcargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.bttmes = new System.Windows.Forms.Button();
            this.bttaño = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // txtmess
            // 
            this.txtmess.Location = new System.Drawing.Point(12, 66);
            this.txtmess.Name = "txtmess";
            this.txtmess.Size = new System.Drawing.Size(100, 20);
            this.txtmess.TabIndex = 5;
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(193, 147);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(75, 23);
            this.btcargar.TabIndex = 4;
            this.btcargar.Text = "cargar";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "DIA";
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(181, 66);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(100, 20);
            this.txtdia.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "AÑO";
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(344, 66);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(100, 20);
            this.txtaño.TabIndex = 12;
            // 
            // bttmes
            // 
            this.bttmes.Location = new System.Drawing.Point(27, 147);
            this.bttmes.Name = "bttmes";
            this.bttmes.Size = new System.Drawing.Size(75, 23);
            this.bttmes.TabIndex = 14;
            this.bttmes.Text = "cargar";
            this.bttmes.UseVisualStyleBackColor = true;
            this.bttmes.Click += new System.EventHandler(this.bttmes_Click);
            // 
            // bttaño
            // 
            this.bttaño.Location = new System.Drawing.Point(369, 147);
            this.bttaño.Name = "bttaño";
            this.bttaño.Size = new System.Drawing.Size(75, 23);
            this.bttaño.TabIndex = 15;
            this.bttaño.Text = "cargar";
            this.bttaño.UseVisualStyleBackColor = true;
            this.bttaño.Click += new System.EventHandler(this.bttaño_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttaño);
            this.Controls.Add(this.bttmes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmess);
            this.Controls.Add(this.btcargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmess;
        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Button bttmes;
        private System.Windows.Forms.Button bttaño;
    }
}

