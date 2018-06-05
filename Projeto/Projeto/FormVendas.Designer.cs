namespace FormVendas
{
    partial class FormVendas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbproprietario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbvalorbase = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbcomissaobase = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbestado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datapicker = new System.Windows.Forms.DateTimePicker();
            this.tbvalornegociado = new System.Windows.Forms.TextBox();
            this.tbvalorcomissao = new System.Windows.Forms.TextBox();
            this.cbcomprador = new System.Windows.Forms.ComboBox();
            this.btnefetivarvenda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comprador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Proprietário:";
            // 
            // lbproprietario
            // 
            this.lbproprietario.AutoSize = true;
            this.lbproprietario.Location = new System.Drawing.Point(105, 79);
            this.lbproprietario.Name = "lbproprietario";
            this.lbproprietario.Size = new System.Drawing.Size(65, 13);
            this.lbproprietario.TabIndex = 3;
            this.lbproprietario.Text = "(proprietario)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Base:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbvalorbase
            // 
            this.lbvalorbase.AutoSize = true;
            this.lbvalorbase.Location = new System.Drawing.Point(105, 113);
            this.lbvalorbase.Name = "lbvalorbase";
            this.lbvalorbase.Size = new System.Drawing.Size(62, 13);
            this.lbvalorbase.TabIndex = 5;
            this.lbvalorbase.Text = "(valor base)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comissão Base:";
            // 
            // lbcomissaobase
            // 
            this.lbcomissaobase.AutoSize = true;
            this.lbcomissaobase.Location = new System.Drawing.Point(124, 146);
            this.lbcomissaobase.Name = "lbcomissaobase";
            this.lbcomissaobase.Size = new System.Drawing.Size(57, 13);
            this.lbcomissaobase.TabIndex = 7;
            this.lbcomissaobase.Text = "(comissao)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data de Venda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Valor Negociado:";
            // 
            // lbestado
            // 
            this.lbestado.AutoSize = true;
            this.lbestado.Location = new System.Drawing.Point(85, 43);
            this.lbestado.Name = "lbestado";
            this.lbestado.Size = new System.Drawing.Size(93, 13);
            this.lbestado.TabIndex = 10;
            this.lbestado.Text = "(estado de venda)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Valor da Comissão:";
            // 
            // datapicker
            // 
            this.datapicker.Location = new System.Drawing.Point(124, 204);
            this.datapicker.Name = "datapicker";
            this.datapicker.Size = new System.Drawing.Size(180, 20);
            this.datapicker.TabIndex = 12;
            // 
            // tbvalornegociado
            // 
            this.tbvalornegociado.Location = new System.Drawing.Point(131, 240);
            this.tbvalornegociado.Name = "tbvalornegociado";
            this.tbvalornegociado.Size = new System.Drawing.Size(173, 20);
            this.tbvalornegociado.TabIndex = 13;
            // 
            // tbvalorcomissao
            // 
            this.tbvalorcomissao.Location = new System.Drawing.Point(131, 273);
            this.tbvalorcomissao.Name = "tbvalorcomissao";
            this.tbvalorcomissao.Size = new System.Drawing.Size(173, 20);
            this.tbvalorcomissao.TabIndex = 14;
            // 
            // cbcomprador
            // 
            this.cbcomprador.FormattingEnabled = true;
            this.cbcomprador.Location = new System.Drawing.Point(103, 304);
            this.cbcomprador.Name = "cbcomprador";
            this.cbcomprador.Size = new System.Drawing.Size(201, 21);
            this.cbcomprador.TabIndex = 15;
            // 
            // btnefetivarvenda
            // 
            this.btnefetivarvenda.Location = new System.Drawing.Point(39, 340);
            this.btnefetivarvenda.Name = "btnefetivarvenda";
            this.btnefetivarvenda.Size = new System.Drawing.Size(265, 23);
            this.btnefetivarvenda.TabIndex = 16;
            this.btnefetivarvenda.Text = "Efetivar Venda";
            this.btnefetivarvenda.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto.Properties.Resources.Cash_icon;
            this.pictureBox1.Location = new System.Drawing.Point(248, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnefetivarvenda);
            this.Controls.Add(this.cbcomprador);
            this.Controls.Add(this.tbvalorcomissao);
            this.Controls.Add(this.tbvalornegociado);
            this.Controls.Add(this.datapicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbestado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbcomissaobase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbvalorbase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbproprietario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVendas";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbproprietario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbvalorbase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbcomissaobase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbestado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datapicker;
        private System.Windows.Forms.TextBox tbvalornegociado;
        private System.Windows.Forms.TextBox tbvalorcomissao;
        private System.Windows.Forms.ComboBox cbcomprador;
        private System.Windows.Forms.Button btnefetivarvenda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

