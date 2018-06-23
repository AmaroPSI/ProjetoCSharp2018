namespace Projeto
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.pbclientes = new System.Windows.Forms.PictureBox();
            this.pbcasa = new System.Windows.Forms.PictureBox();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // pbclientes
            // 
            this.pbclientes.Image = ((System.Drawing.Image)(resources.GetObject("pbclientes.Image")));
            this.pbclientes.Location = new System.Drawing.Point(78, 214);
            this.pbclientes.Name = "pbclientes";
            this.pbclientes.Size = new System.Drawing.Size(181, 172);
            this.pbclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclientes.TabIndex = 0;
            this.pbclientes.TabStop = false;
            this.pbclientes.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbcasa
            // 
            this.pbcasa.Image = ((System.Drawing.Image)(resources.GetObject("pbcasa.Image")));
            this.pbcasa.Location = new System.Drawing.Point(454, 214);
            this.pbcasa.Name = "pbcasa";
            this.pbcasa.Size = new System.Drawing.Size(181, 172);
            this.pbcasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcasa.TabIndex = 1;
            this.pbcasa.TabStop = false;
            this.pbcasa.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(269, 12);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(181, 172);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 453);
            this.Controls.Add(this.img);
            this.Controls.Add(this.pbcasa);
            this.Controls.Add(this.pbclientes);
            this.Name = "Index";
            this.Text = "Página Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pbclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbclientes;
        private System.Windows.Forms.PictureBox pbcasa;
        private System.Windows.Forms.PictureBox img;
    }
}

