namespace Chronos.WF.Telas
{
    partial class FrmProjeto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAdicionaProjeto = new System.Windows.Forms.Button();
            this.txtNomeProjeto = new System.Windows.Forms.TextBox();
            this.txtPrefixoProjeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgProjetos = new System.Windows.Forms.DataGridView();
            this.dgvcEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvcExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvcNomeProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProjeto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrefixoMenu = new System.Windows.Forms.TextBox();
            this.txtNomeMenu = new System.Windows.Forms.TextBox();
            this.btAdicionaMenu = new System.Windows.Forms.Button();
            this.dgMenus = new System.Windows.Forms.DataGridView();
            this.dgvmEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvmExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProjetos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionaProjeto
            // 
            this.btAdicionaProjeto.BackColor = System.Drawing.Color.White;
            this.btAdicionaProjeto.FlatAppearance.BorderSize = 0;
            this.btAdicionaProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionaProjeto.Image = global::Chronos.WF.Properties.Resources.imgBotaoPequenoHover;
            this.btAdicionaProjeto.Location = new System.Drawing.Point(402, 32);
            this.btAdicionaProjeto.Name = "btAdicionaProjeto";
            this.btAdicionaProjeto.Size = new System.Drawing.Size(74, 28);
            this.btAdicionaProjeto.TabIndex = 0;
            this.btAdicionaProjeto.Text = "+ Adicionar";
            this.btAdicionaProjeto.UseVisualStyleBackColor = false;
            this.btAdicionaProjeto.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomeProjeto
            // 
            this.txtNomeProjeto.Location = new System.Drawing.Point(18, 37);
            this.txtNomeProjeto.MaxLength = 50;
            this.txtNomeProjeto.Name = "txtNomeProjeto";
            this.txtNomeProjeto.Size = new System.Drawing.Size(308, 20);
            this.txtNomeProjeto.TabIndex = 1;
            // 
            // txtPrefixoProjeto
            // 
            this.txtPrefixoProjeto.Location = new System.Drawing.Point(346, 37);
            this.txtPrefixoProjeto.MaxLength = 2;
            this.txtPrefixoProjeto.Name = "txtPrefixoProjeto";
            this.txtPrefixoProjeto.Size = new System.Drawing.Size(39, 20);
            this.txtPrefixoProjeto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Projeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prefixo";
            // 
            // dgProjetos
            // 
            this.dgProjetos.AllowUserToAddRows = false;
            this.dgProjetos.AllowUserToDeleteRows = false;
            this.dgProjetos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgProjetos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProjetos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProjetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcEditar,
            this.dgvcExcluir,
            this.dgvcNomeProjeto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProjetos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProjetos.Location = new System.Drawing.Point(71, 123);
            this.dgProjetos.Name = "dgProjetos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProjetos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgProjetos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProjetos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgProjetos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProjetos.Size = new System.Drawing.Size(489, 130);
            this.dgProjetos.TabIndex = 5;
            this.dgProjetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProjetos_CellContentClick);
            // 
            // dgvcEditar
            // 
            this.dgvcEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcEditar.FillWeight = 78.14275F;
            this.dgvcEditar.HeaderText = "...";
            this.dgvcEditar.Image = global::Chronos.WF.Properties.Resources.imgLapis;
            this.dgvcEditar.Name = "dgvcEditar";
            this.dgvcEditar.Width = 30;
            // 
            // dgvcExcluir
            // 
            this.dgvcExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcExcluir.FillWeight = 56.16979F;
            this.dgvcExcluir.HeaderText = "...";
            this.dgvcExcluir.Image = ((System.Drawing.Image)(resources.GetObject("dgvcExcluir.Image")));
            this.dgvcExcluir.Name = "dgvcExcluir";
            this.dgvcExcluir.Width = 30;
            // 
            // dgvcNomeProjeto
            // 
            this.dgvcNomeProjeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvcNomeProjeto.DataPropertyName = "NomeProjeto";
            this.dgvcNomeProjeto.FillWeight = 278.7092F;
            this.dgvcNomeProjeto.HeaderText = "Nome do Projeto";
            this.dgvcNomeProjeto.Name = "dgvcNomeProjeto";
            this.dgvcNomeProjeto.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrefixoProjeto);
            this.groupBox1.Controls.Add(this.txtNomeProjeto);
            this.groupBox1.Controls.Add(this.btAdicionaProjeto);
            this.groupBox1.Location = new System.Drawing.Point(71, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projetos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbProjeto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrefixoMenu);
            this.groupBox2.Controls.Add(this.txtNomeMenu);
            this.groupBox2.Controls.Add(this.btAdicionaMenu);
            this.groupBox2.Location = new System.Drawing.Point(71, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 128);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome do Projeto";
            // 
            // cmbProjeto
            // 
            this.cmbProjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjeto.FormattingEnabled = true;
            this.cmbProjeto.Location = new System.Drawing.Point(18, 47);
            this.cmbProjeto.Name = "cmbProjeto";
            this.cmbProjeto.Size = new System.Drawing.Size(308, 21);
            this.cmbProjeto.TabIndex = 11;
            this.cmbProjeto.SelectedValueChanged += new System.EventHandler(this.cmbProjeto_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prefixo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do Menu";
            // 
            // txtPrefixoMenu
            // 
            this.txtPrefixoMenu.Location = new System.Drawing.Point(346, 93);
            this.txtPrefixoMenu.MaxLength = 2;
            this.txtPrefixoMenu.Name = "txtPrefixoMenu";
            this.txtPrefixoMenu.Size = new System.Drawing.Size(39, 20);
            this.txtPrefixoMenu.TabIndex = 2;
            // 
            // txtNomeMenu
            // 
            this.txtNomeMenu.Location = new System.Drawing.Point(18, 93);
            this.txtNomeMenu.MaxLength = 50;
            this.txtNomeMenu.Name = "txtNomeMenu";
            this.txtNomeMenu.Size = new System.Drawing.Size(308, 20);
            this.txtNomeMenu.TabIndex = 1;
            // 
            // btAdicionaMenu
            // 
            this.btAdicionaMenu.BackColor = System.Drawing.Color.White;
            this.btAdicionaMenu.FlatAppearance.BorderSize = 0;
            this.btAdicionaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionaMenu.Image = global::Chronos.WF.Properties.Resources.imgBotaoPequenoHover;
            this.btAdicionaMenu.Location = new System.Drawing.Point(402, 88);
            this.btAdicionaMenu.Name = "btAdicionaMenu";
            this.btAdicionaMenu.Size = new System.Drawing.Size(74, 28);
            this.btAdicionaMenu.TabIndex = 0;
            this.btAdicionaMenu.Text = "+ Adicionar";
            this.btAdicionaMenu.UseVisualStyleBackColor = false;
            this.btAdicionaMenu.Click += new System.EventHandler(this.btAdicionaMenu_Click);
            // 
            // dgMenus
            // 
            this.dgMenus.AllowUserToAddRows = false;
            this.dgMenus.AllowUserToDeleteRows = false;
            this.dgMenus.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgMenus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMenus.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmEditar,
            this.dgvmExcluir,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMenus.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgMenus.Location = new System.Drawing.Point(71, 393);
            this.dgMenus.Name = "dgMenus";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMenus.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgMenus.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgMenus.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgMenus.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMenus.Size = new System.Drawing.Size(489, 130);
            this.dgMenus.TabIndex = 7;
            this.dgMenus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenus_CellContentClick);
            // 
            // dgvmEditar
            // 
            this.dgvmEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvmEditar.FillWeight = 78.14275F;
            this.dgvmEditar.HeaderText = "...";
            this.dgvmEditar.Image = global::Chronos.WF.Properties.Resources.imgLapis;
            this.dgvmEditar.Name = "dgvmEditar";
            this.dgvmEditar.Width = 30;
            // 
            // dgvmExcluir
            // 
            this.dgvmExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvmExcluir.FillWeight = 56.16979F;
            this.dgvmExcluir.HeaderText = "...";
            this.dgvmExcluir.Image = ((System.Drawing.Image)(resources.GetObject("dgvmExcluir.Image")));
            this.dgvmExcluir.Name = "dgvmExcluir";
            this.dgvmExcluir.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeMenu";
            this.dataGridViewTextBoxColumn1.FillWeight = 278.7092F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Menu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FrmProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(655, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgMenus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgProjetos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProjeto";
            this.Text = "Projeto";
            this.Load += new System.EventHandler(this.Projeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProjetos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionaProjeto;
        private System.Windows.Forms.TextBox txtNomeProjeto;
        private System.Windows.Forms.TextBox txtPrefixoProjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProjetos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewImageColumn dgvcEditar;
        private System.Windows.Forms.DataGridViewImageColumn dgvcExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNomeProjeto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrefixoMenu;
        private System.Windows.Forms.TextBox txtNomeMenu;
        private System.Windows.Forms.Button btAdicionaMenu;
        private System.Windows.Forms.DataGridView dgMenus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProjeto;
        private System.Windows.Forms.DataGridViewImageColumn dgvmEditar;
        private System.Windows.Forms.DataGridViewImageColumn dgvmExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}