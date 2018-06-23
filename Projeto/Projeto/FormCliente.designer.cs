namespace ProjetoC
{
    partial class FormCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.labelcasas = new System.Windows.Forms.Label();
            this.labelarrendamentos = new System.Windows.Forms.Label();
            this.listboxcasas = new System.Windows.Forms.ListBox();
            this.listboxarrendamentos = new System.Windows.Forms.ListBox();
            this.listboxaquisicoes = new System.Windows.Forms.ListBox();
            this.labelaquisicoes = new System.Windows.Forms.Label();
            this.labeldetalhes = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbnif = new System.Windows.Forms.TextBox();
            this.tbmorada = new System.Windows.Forms.TextBox();
            this.tbcontacto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnapagar = new System.Windows.Forms.Button();
            this.datagridclientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(131, 52);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnfiltrar.TabIndex = 1;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // labelcasas
            // 
            this.labelcasas.AutoSize = true;
            this.labelcasas.Location = new System.Drawing.Point(415, 250);
            this.labelcasas.Name = "labelcasas";
            this.labelcasas.Size = new System.Drawing.Size(36, 13);
            this.labelcasas.TabIndex = 3;
            this.labelcasas.Text = "Casas";
            // 
            // labelarrendamentos
            // 
            this.labelarrendamentos.AutoSize = true;
            this.labelarrendamentos.Location = new System.Drawing.Point(415, 380);
            this.labelarrendamentos.Name = "labelarrendamentos";
            this.labelarrendamentos.Size = new System.Drawing.Size(78, 13);
            this.labelarrendamentos.TabIndex = 4;
            this.labelarrendamentos.Text = "Arrendamentos";
            // 
            // listboxcasas
            // 
            this.listboxcasas.FormattingEnabled = true;
            this.listboxcasas.Location = new System.Drawing.Point(420, 266);
            this.listboxcasas.Name = "listboxcasas";
            this.listboxcasas.Size = new System.Drawing.Size(230, 95);
            this.listboxcasas.TabIndex = 6;
            this.listboxcasas.SelectedIndexChanged += new System.EventHandler(this.listboxcasas_SelectedIndexChanged);
            // 
            // listboxarrendamentos
            // 
            this.listboxarrendamentos.FormattingEnabled = true;
            this.listboxarrendamentos.Location = new System.Drawing.Point(420, 396);
            this.listboxarrendamentos.Name = "listboxarrendamentos";
            this.listboxarrendamentos.Size = new System.Drawing.Size(230, 95);
            this.listboxarrendamentos.TabIndex = 7;
            // 
            // listboxaquisicoes
            // 
            this.listboxaquisicoes.FormattingEnabled = true;
            this.listboxaquisicoes.Location = new System.Drawing.Point(420, 520);
            this.listboxaquisicoes.Name = "listboxaquisicoes";
            this.listboxaquisicoes.Size = new System.Drawing.Size(230, 95);
            this.listboxaquisicoes.TabIndex = 8;
            this.listboxaquisicoes.SelectedIndexChanged += new System.EventHandler(this.listboxaquisicoes_SelectedIndexChanged);
            // 
            // labelaquisicoes
            // 
            this.labelaquisicoes.AutoSize = true;
            this.labelaquisicoes.Location = new System.Drawing.Point(417, 504);
            this.labelaquisicoes.Name = "labelaquisicoes";
            this.labelaquisicoes.Size = new System.Drawing.Size(58, 13);
            this.labelaquisicoes.TabIndex = 9;
            this.labelaquisicoes.Text = "Aquisições";
            // 
            // labeldetalhes
            // 
            this.labeldetalhes.AutoSize = true;
            this.labeldetalhes.Location = new System.Drawing.Point(382, 100);
            this.labeldetalhes.Name = "labeldetalhes";
            this.labeldetalhes.Size = new System.Drawing.Size(49, 13);
            this.labeldetalhes.TabIndex = 10;
            this.labeldetalhes.Text = "Detalhes";
            // 
            // tbnome
            // 
            this.tbnome.Enabled = false;
            this.tbnome.Location = new System.Drawing.Point(457, 117);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(204, 20);
            this.tbnome.TabIndex = 11;
            this.tbnome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbnif
            // 
            this.tbnif.Enabled = false;
            this.tbnif.Location = new System.Drawing.Point(457, 143);
            this.tbnif.Name = "tbnif";
            this.tbnif.Size = new System.Drawing.Size(204, 20);
            this.tbnif.TabIndex = 12;
            this.tbnif.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbmorada
            // 
            this.tbmorada.Enabled = false;
            this.tbmorada.Location = new System.Drawing.Point(457, 169);
            this.tbmorada.Name = "tbmorada";
            this.tbmorada.Size = new System.Drawing.Size(204, 20);
            this.tbmorada.TabIndex = 13;
            this.tbmorada.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbcontacto
            // 
            this.tbcontacto.Enabled = false;
            this.tbcontacto.Location = new System.Drawing.Point(457, 195);
            this.tbcontacto.Name = "tbcontacto";
            this.tbcontacto.Size = new System.Drawing.Size(204, 20);
            this.tbcontacto.TabIndex = 14;
            this.tbcontacto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "NIF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Morada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Contacto";
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(457, 221);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 19;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(586, 221);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 20;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nome",
            "NIF",
            "Contacto"});
            this.comboBox1.Location = new System.Drawing.Point(13, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(12, 621);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(347, 23);
            this.btnapagar.TabIndex = 23;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // datagridclientes
            // 
            this.datagridclientes.AllowUserToOrderColumns = true;
            this.datagridclientes.AutoGenerateColumns = false;
            this.datagridclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.NIF,
            this.Contacto});
            this.datagridclientes.DataSource = this.form1BindingSource;
            this.datagridclientes.Location = new System.Drawing.Point(12, 100);
            this.datagridclientes.Name = "datagridclientes";
            this.datagridclientes.Size = new System.Drawing.Size(347, 515);
            this.datagridclientes.TabIndex = 24;
            this.datagridclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridclientes_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // NIF
            // 
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(376, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 525);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 668);
            this.Controls.Add(this.datagridclientes);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcontacto);
            this.Controls.Add(this.tbmorada);
            this.Controls.Add(this.tbnif);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.labeldetalhes);
            this.Controls.Add(this.labelaquisicoes);
            this.Controls.Add(this.listboxaquisicoes);
            this.Controls.Add(this.listboxarrendamentos);
            this.Controls.Add(this.listboxcasas);
            this.Controls.Add(this.labelarrendamentos);
            this.Controls.Add(this.labelcasas);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCliente";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.Label labelcasas;
        private System.Windows.Forms.Label labelarrendamentos;
        private System.Windows.Forms.ListBox listboxcasas;
        private System.Windows.Forms.ListBox listboxarrendamentos;
        private System.Windows.Forms.ListBox listboxaquisicoes;
        private System.Windows.Forms.Label labelaquisicoes;
        private System.Windows.Forms.Label labeldetalhes;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbnif;
        private System.Windows.Forms.TextBox tbmorada;
        private System.Windows.Forms.TextBox tbcontacto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.DataGridView datagridclientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoScrollDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autoSizeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoSizeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoValidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formBorderStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelButtonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn helpButtonDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMdiContainerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn keyPreviewDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maximizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn minimizeBoxDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rightToLeftLayoutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showInTaskbarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn showIconDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGripStyleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn topMostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transparencyKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoScrollMinSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibleRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn allowDropDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anchorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn backgroundImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backgroundImageLayoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn causesValidationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contextMenuStripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBindingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightToLeftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useWaitCursorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paddingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
    }
}

