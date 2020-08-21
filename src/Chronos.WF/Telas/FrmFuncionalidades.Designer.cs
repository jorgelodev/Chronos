namespace Chronos.WF.Telas
{
    partial class FrmFuncionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionalidades));
            this.dgFuncionalidades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoFuncionalidade = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btAdicionaProjeto = new System.Windows.Forms.Button();
            this.dgvcEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvcExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvcCodigoFuncionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcNomeProjeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFuncionalidades
            // 
            this.dgFuncionalidades.AllowUserToAddRows = false;
            this.dgFuncionalidades.AllowUserToDeleteRows = false;
            this.dgFuncionalidades.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgFuncionalidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFuncionalidades.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFuncionalidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcEditar,
            this.dgvcExcluir,
            this.dgvcCodigoFuncionalidade,
            this.dgvcNomeProjeto,
            this.NomeMenu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFuncionalidades.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgFuncionalidades.Location = new System.Drawing.Point(38, 73);
            this.dgFuncionalidades.Name = "dgFuncionalidades";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgFuncionalidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgFuncionalidades.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgFuncionalidades.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgFuncionalidades.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgFuncionalidades.Size = new System.Drawing.Size(709, 231);
            this.dgFuncionalidades.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código Funcionalidade";
            // 
            // txtCodigoFuncionalidade
            // 
            this.txtCodigoFuncionalidade.Location = new System.Drawing.Point(38, 39);
            this.txtCodigoFuncionalidade.MaxLength = 50;
            this.txtCodigoFuncionalidade.Name = "txtCodigoFuncionalidade";
            this.txtCodigoFuncionalidade.Size = new System.Drawing.Size(114, 20);
            this.txtCodigoFuncionalidade.TabIndex = 7;
            this.txtCodigoFuncionalidade.Enter += new System.EventHandler(this.txtCodigoFuncionalidade_Enter);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 78.14275F;
            this.dataGridViewImageColumn1.HeaderText = "...";
            this.dataGridViewImageColumn1.Image = global::Chronos.WF.Properties.Resources.imgLapis;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 56.16979F;
            this.dataGridViewImageColumn2.HeaderText = "...";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // btAdicionaProjeto
            // 
            this.btAdicionaProjeto.BackColor = System.Drawing.Color.White;
            this.btAdicionaProjeto.FlatAppearance.BorderSize = 0;
            this.btAdicionaProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionaProjeto.Image = global::Chronos.WF.Properties.Resources.imgBotaoPequenoHover;
            this.btAdicionaProjeto.Location = new System.Drawing.Point(673, 310);
            this.btAdicionaProjeto.Name = "btAdicionaProjeto";
            this.btAdicionaProjeto.Size = new System.Drawing.Size(74, 28);
            this.btAdicionaProjeto.TabIndex = 6;
            this.btAdicionaProjeto.Text = "+ Adicionar";
            this.btAdicionaProjeto.UseVisualStyleBackColor = false;
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
            // dgvcCodigoFuncionalidade
            // 
            this.dgvcCodigoFuncionalidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcCodigoFuncionalidade.DataPropertyName = "CodigoFuncionalidade";
            this.dgvcCodigoFuncionalidade.FillWeight = 364.8877F;
            this.dgvcCodigoFuncionalidade.HeaderText = "Código Funcionalidade";
            this.dgvcCodigoFuncionalidade.Name = "dgvcCodigoFuncionalidade";
            this.dgvcCodigoFuncionalidade.Width = 150;
            // 
            // dgvcNomeProjeto
            // 
            this.dgvcNomeProjeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcNomeProjeto.DataPropertyName = "NomeProjeto";
            this.dgvcNomeProjeto.FillWeight = 13.8215F;
            this.dgvcNomeProjeto.HeaderText = "Projeto";
            this.dgvcNomeProjeto.Name = "dgvcNomeProjeto";
            this.dgvcNomeProjeto.ReadOnly = true;
            this.dgvcNomeProjeto.Width = 150;
            // 
            // NomeMenu
            // 
            this.NomeMenu.DataPropertyName = "NomeMenu";
            this.NomeMenu.HeaderText = "Menu";
            this.NomeMenu.Name = "NomeMenu";
            // 
            // FrmFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgFuncionalidades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoFuncionalidade);
            this.Controls.Add(this.btAdicionaProjeto);
            this.Name = "FrmFuncionalidades";
            this.Load += new System.EventHandler(this.FrmFuncionalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFuncionalidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoFuncionalidade;
        private System.Windows.Forms.Button btAdicionaProjeto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dgvcEditar;
        private System.Windows.Forms.DataGridViewImageColumn dgvcExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcCodigoFuncionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNomeProjeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMenu;
    }
}