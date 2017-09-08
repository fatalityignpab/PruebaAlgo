namespace Prueba2
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
            this.lblHola = new System.Windows.Forms.Label();
            this.btnApretar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.BackColor = System.Drawing.Color.OldLace;
            this.lblHola.Location = new System.Drawing.Point(140, 67);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(10, 13);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = " ";
            // 
            // btnApretar
            // 
            this.btnApretar.Location = new System.Drawing.Point(108, 105);
            this.btnApretar.Name = "btnApretar";
            this.btnApretar.Size = new System.Drawing.Size(75, 23);
            this.btnApretar.TabIndex = 1;
            this.btnApretar.Text = "Aprietame";
            this.btnApretar.UseVisualStyleBackColor = true;
            this.btnApretar.Click += new System.EventHandler(this.daClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 203);
            this.Controls.Add(this.btnApretar);
            this.Controls.Add(this.lblHola);
            this.Name = "Form1";
            this.Text = "Saludame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Button btnApretar;
    }
}

