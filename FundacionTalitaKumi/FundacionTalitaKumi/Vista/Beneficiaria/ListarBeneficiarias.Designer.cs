﻿namespace FundacionTalitaKumi.Vista
{
    partial class ListarBeneficiarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarBeneficiarias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_datoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_buscarPor = new System.Windows.Forms.ComboBox();
            this.button_listar = new System.Windows.Forms.Button();
            this.panel_botones = new System.Windows.Forms.TableLayoutPanel();
            this.button_regresar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.dataGridView_llenarBeneficiarias = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_llenarBeneficiarias)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_botones, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_llenarBeneficiarias, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.32653F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.67347F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 677);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.44304F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.48787F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20216F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_buscarPor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_listar, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(742, 132);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_datoConsulta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(265, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 87);
            this.panel1.TabIndex = 14;
            // 
            // textBox_datoConsulta
            // 
            this.textBox_datoConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_datoConsulta.Location = new System.Drawing.Point(6, 32);
            this.textBox_datoConsulta.Name = "textBox_datoConsulta";
            this.textBox_datoConsulta.Size = new System.Drawing.Size(262, 22);
            this.textBox_datoConsulta.TabIndex = 2;
            this.textBox_datoConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_datoConsulta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_buscarPor
            // 
            this.comboBox_buscarPor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox_buscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_buscarPor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_buscarPor.FormattingEnabled = true;
            this.comboBox_buscarPor.Items.AddRange(new object[] {
            "Todos:",
            "Año de Entrada:",
            "Año de Salida:",
            "Edad:"});
            this.comboBox_buscarPor.Location = new System.Drawing.Point(3, 72);
            this.comboBox_buscarPor.Name = "comboBox_buscarPor";
            this.comboBox_buscarPor.Size = new System.Drawing.Size(236, 28);
            this.comboBox_buscarPor.TabIndex = 1;
            this.comboBox_buscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox_buscarPor_SelectedIndexChanged);
            // 
            // button_listar
            // 
            this.button_listar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_listar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listar.Image = global::FundacionTalitaKumi.Properties.Resources.listar1;
            this.button_listar.Location = new System.Drawing.Point(557, 43);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(174, 79);
            this.button_listar.TabIndex = 12;
            this.button_listar.Text = "Listar";
            this.button_listar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_listar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_listar.UseVisualStyleBackColor = false;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click_1);
            // 
            // panel_botones
            // 
            this.panel_botones.AutoScroll = true;
            this.panel_botones.ColumnCount = 3;
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panel_botones.Controls.Add(this.button_regresar, 2, 0);
            this.panel_botones.Controls.Add(this.button_limpiar, 1, 0);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_botones.Location = new System.Drawing.Point(5, 534);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.RowCount = 1;
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_botones.Size = new System.Drawing.Size(928, 138);
            this.panel_botones.TabIndex = 11;
            // 
            // button_regresar
            // 
            this.button_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_regresar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.Image = ((System.Drawing.Image)(resources.GetObject("button_regresar.Image")));
            this.button_regresar.Location = new System.Drawing.Point(700, 3);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(146, 132);
            this.button_regresar.TabIndex = 5;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_limpiar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.Location = new System.Drawing.Point(378, 3);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(171, 132);
            this.button_limpiar.TabIndex = 6;
            this.button_limpiar.Text = "Limpiar Datos";
            this.button_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_limpiar.UseVisualStyleBackColor = false;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // dataGridView_llenarBeneficiarias
            // 
            this.dataGridView_llenarBeneficiarias.AllowUserToAddRows = false;
            this.dataGridView_llenarBeneficiarias.AllowUserToDeleteRows = false;
            this.dataGridView_llenarBeneficiarias.AllowUserToResizeColumns = false;
            this.dataGridView_llenarBeneficiarias.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.dataGridView_llenarBeneficiarias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_llenarBeneficiarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_llenarBeneficiarias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_llenarBeneficiarias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.dataGridView_llenarBeneficiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_llenarBeneficiarias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_llenarBeneficiarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_llenarBeneficiarias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.dataGridView_llenarBeneficiarias.Location = new System.Drawing.Point(5, 145);
            this.dataGridView_llenarBeneficiarias.Name = "dataGridView_llenarBeneficiarias";
            this.dataGridView_llenarBeneficiarias.RowTemplate.Height = 24;
            this.dataGridView_llenarBeneficiarias.Size = new System.Drawing.Size(928, 381);
            this.dataGridView_llenarBeneficiarias.TabIndex = 12;
            // 
            // ListarBeneficiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(938, 677);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarBeneficiarias";
            this.Text = "ListarBeneficiarias";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_llenarBeneficiarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_buscarPor;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.TableLayoutPanel panel_botones;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.DataGridView dataGridView_llenarBeneficiarias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_datoConsulta;
    }
}