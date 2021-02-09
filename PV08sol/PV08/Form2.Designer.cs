namespace PV08
{
    partial class Form2
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
            this.lblformaDos = new System.Windows.Forms.Label();
            this.btncerrarforma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblformaDos
            // 
            this.lblformaDos.AutoSize = true;
            this.lblformaDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblformaDos.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblformaDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblformaDos.Location = new System.Drawing.Point(272, 151);
            this.lblformaDos.Name = "lblformaDos";
            this.lblformaDos.Size = new System.Drawing.Size(207, 42);
            this.lblformaDos.TabIndex = 0;
            this.lblformaDos.Text = "Forma Dos";
            // 
            // btncerrarforma
            // 
            this.btncerrarforma.Location = new System.Drawing.Point(564, 343);
            this.btncerrarforma.Name = "btncerrarforma";
            this.btncerrarforma.Size = new System.Drawing.Size(100, 23);
            this.btncerrarforma.TabIndex = 1;
            this.btncerrarforma.Text = "Cerrar";
            this.btncerrarforma.UseVisualStyleBackColor = true;
            this.btncerrarforma.Click += new System.EventHandler(this.btncerrarforma_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrarforma);
            this.Controls.Add(this.lblformaDos);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblformaDos;
        private System.Windows.Forms.Button btncerrarforma;
    }
}