namespace PV08
{
    partial class frmDos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblformaDos
            // 
            this.lblformaDos.AutoSize = true;
            this.lblformaDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblformaDos.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblformaDos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblformaDos.Location = new System.Drawing.Point(283, 139);
            this.lblformaDos.Name = "lblformaDos";
            this.lblformaDos.Size = new System.Drawing.Size(207, 42);
            this.lblformaDos.TabIndex = 0;
            this.lblformaDos.Text = "Forma Dos";
            // 
            // btncerrarforma
            // 
            this.btncerrarforma.Location = new System.Drawing.Point(58, 338);
            this.btncerrarforma.Name = "btncerrarforma";
            this.btncerrarforma.Size = new System.Drawing.Size(132, 58);
            this.btncerrarforma.TabIndex = 1;
            this.btncerrarforma.Text = "Cerrar";
            this.btncerrarforma.UseVisualStyleBackColor = true;
            this.btncerrarforma.Click += new System.EventHandler(this.btncerrarforma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PV08.Properties.Resources.jordan;
            this.pictureBox1.Location = new System.Drawing.Point(537, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btncerrarforma);
            this.Controls.Add(this.lblformaDos);
            this.Name = "frmDos";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblformaDos;
        private System.Windows.Forms.Button btncerrarforma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}