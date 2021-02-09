namespace PV08
{
    partial class frmUno
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
            this.btnLlamaraformaDos = new System.Windows.Forms.Button();
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLlamaraformaTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamaraformaDos
            // 
            this.btnLlamaraformaDos.BackColor = System.Drawing.Color.Fuchsia;
            this.btnLlamaraformaDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamaraformaDos.Location = new System.Drawing.Point(388, 359);
            this.btnLlamaraformaDos.Name = "btnLlamaraformaDos";
            this.btnLlamaraformaDos.Size = new System.Drawing.Size(172, 61);
            this.btnLlamaraformaDos.TabIndex = 0;
            this.btnLlamaraformaDos.Text = "Llamar a forma Dos";
            this.btnLlamaraformaDos.UseVisualStyleBackColor = false;
            this.btnLlamaraformaDos.Click += new System.EventHandler(this.button1_Click);
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
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(113, 377);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(128, 43);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLlamaraformaTres
            // 
            this.btnLlamaraformaTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLlamaraformaTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamaraformaTres.Location = new System.Drawing.Point(603, 359);
            this.btnLlamaraformaTres.Name = "btnLlamaraformaTres";
            this.btnLlamaraformaTres.Size = new System.Drawing.Size(172, 61);
            this.btnLlamaraformaTres.TabIndex = 3;
            this.btnLlamaraformaTres.Text = "Llamar a forma Tres";
            this.btnLlamaraformaTres.UseVisualStyleBackColor = false;
            this.btnLlamaraformaTres.Click += new System.EventHandler(this.btnLlamaraformaTres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamaraformaTres);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblFormaUno);
            this.Controls.Add(this.btnLlamaraformaDos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlamaraformaDos;
        private System.Windows.Forms.Label lblFormaUno;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLlamaraformaTres;
    }
}

