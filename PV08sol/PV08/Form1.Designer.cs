namespace PV08
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
            this.btnllamaraformaDos = new System.Windows.Forms.Button();
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnllamaraformaDos
            // 
            this.btnllamaraformaDos.Location = new System.Drawing.Point(583, 377);
            this.btnllamaraformaDos.Name = "btnllamaraformaDos";
            this.btnllamaraformaDos.Size = new System.Drawing.Size(170, 43);
            this.btnllamaraformaDos.TabIndex = 0;
            this.btnllamaraformaDos.Text = "Llamar a forma Dos";
            this.btnllamaraformaDos.UseVisualStyleBackColor = true;
            this.btnllamaraformaDos.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFormaUno
            // 
            this.lblFormaUno.AutoSize = true;
            this.lblFormaUno.BackColor = System.Drawing.Color.Red;
            this.lblFormaUno.Font = new System.Drawing.Font("Franchise", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaUno.Location = new System.Drawing.Point(262, 118);
            this.lblFormaUno.Name = "lblFormaUno";
            this.lblFormaUno.Size = new System.Drawing.Size(264, 56);
            this.lblFormaUno.TabIndex = 1;
            this.lblFormaUno.Text = "Forma Uno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormaUno);
            this.Controls.Add(this.btnllamaraformaDos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnllamaraformaDos;
        private System.Windows.Forms.Label lblFormaUno;
    }
}

