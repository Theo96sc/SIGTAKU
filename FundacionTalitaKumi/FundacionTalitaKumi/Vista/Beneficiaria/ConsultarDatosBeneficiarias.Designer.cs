namespace FundacionTalitaKumi.Vista.Beneficiaria
{
    partial class ConsultarDatosBeneficiarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarDatosBeneficiarias));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Beneficiaria = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_buscarPor = new System.Windows.Forms.ComboBox();
            this.textBox_datoConsulta = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.panel_general = new System.Windows.Forms.TableLayoutPanel();
            this.button_regresar = new System.Windows.Forms.Button();
            this.label_subtitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel_siguiente = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.panel_datos = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Beneficiaria)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_general.SuspendLayout();
            this.tableLayoutPanel_siguiente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.94089F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.05911F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_general, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 616);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView_Beneficiaria, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46512F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.53488F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 616);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView_Beneficiaria
            // 
            this.dataGridView_Beneficiaria.AllowUserToAddRows = false;
            this.dataGridView_Beneficiaria.AllowUserToDeleteRows = false;
            this.dataGridView_Beneficiaria.AllowUserToResizeColumns = false;
            this.dataGridView_Beneficiaria.AllowUserToResizeRows = false;
            this.dataGridView_Beneficiaria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Beneficiaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Beneficiaria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Beneficiaria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.dataGridView_Beneficiaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Beneficiaria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Beneficiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Beneficiaria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Beneficiaria.Location = new System.Drawing.Point(2, 128);
            this.dataGridView_Beneficiaria.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Beneficiaria.Name = "dataGridView_Beneficiaria";
            this.dataGridView_Beneficiaria.ReadOnly = true;
            this.dataGridView_Beneficiaria.RowTemplate.Height = 24;
            this.dataGridView_Beneficiaria.Size = new System.Drawing.Size(218, 486);
            this.dataGridView_Beneficiaria.TabIndex = 9;
            this.dataGridView_Beneficiaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Personal_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_buscarPor, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_datoConsulta, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button_buscar, 2, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.2F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(212, 118);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_buscarPor
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.comboBox_buscarPor, 3);
            this.comboBox_buscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_buscarPor.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_buscarPor.FormattingEnabled = true;
            this.comboBox_buscarPor.Items.AddRange(new object[] {
            "Código de Beneficiaria:",
            "Apellidos:",
            "Identificación:"});
            this.comboBox_buscarPor.Location = new System.Drawing.Point(3, 31);
            this.comboBox_buscarPor.Name = "comboBox_buscarPor";
            this.comboBox_buscarPor.Size = new System.Drawing.Size(200, 28);
            this.comboBox_buscarPor.TabIndex = 1;
            this.comboBox_buscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox_buscarPor_SelectedIndexChanged);
            // 
            // textBox_datoConsulta
            // 
            this.textBox_datoConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel3.SetColumnSpan(this.textBox_datoConsulta, 2);
            this.textBox_datoConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_datoConsulta.Location = new System.Drawing.Point(3, 64);
            this.textBox_datoConsulta.Name = "textBox_datoConsulta";
            this.textBox_datoConsulta.Size = new System.Drawing.Size(134, 22);
            this.textBox_datoConsulta.TabIndex = 2;
            this.textBox_datoConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_datoConsulta_KeyPress);
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_buscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.button_buscar.FlatAppearance.BorderSize = 0;
            this.button_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_buscar.Image = ((System.Drawing.Image)(resources.GetObject("button_buscar.Image")));
            this.button_buscar.Location = new System.Drawing.Point(143, 64);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(54, 50);
            this.button_buscar.TabIndex = 3;
            this.button_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // panel_general
            // 
            this.panel_general.ColumnCount = 1;
            this.panel_general.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_general.Controls.Add(this.button_regresar, 0, 3);
            this.panel_general.Controls.Add(this.label_subtitulo, 0, 1);
            this.panel_general.Controls.Add(this.tableLayoutPanel_siguiente, 0, 0);
            this.panel_general.Controls.Add(this.panel_datos, 0, 2);
            this.panel_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_general.Location = new System.Drawing.Point(222, 0);
            this.panel_general.Margin = new System.Windows.Forms.Padding(0);
            this.panel_general.Name = "panel_general";
            this.panel_general.RowCount = 4;
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_general.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_general.Size = new System.Drawing.Size(707, 616);
            this.panel_general.TabIndex = 2;
            // 
            // button_regresar
            // 
            this.button_regresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_regresar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.Image = ((System.Drawing.Image)(resources.GetObject("button_regresar.Image")));
            this.button_regresar.Location = new System.Drawing.Point(571, 498);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(133, 115);
            this.button_regresar.TabIndex = 30;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_regresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click_1);
            // 
            // label_subtitulo
            // 
            this.label_subtitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_subtitulo.AutoSize = true;
            this.label_subtitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_subtitulo.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtitulo.Location = new System.Drawing.Point(3, 70);
            this.label_subtitulo.Name = "label_subtitulo";
            this.label_subtitulo.Size = new System.Drawing.Size(701, 40);
            this.label_subtitulo.TabIndex = 29;
            this.label_subtitulo.Text = "Subtitulo";
            this.label_subtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_siguiente
            // 
            this.tableLayoutPanel_siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.tableLayoutPanel_siguiente.ColumnCount = 2;
            this.tableLayoutPanel_siguiente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_siguiente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_siguiente.Controls.Add(this.buttonAnterior, 0, 0);
            this.tableLayoutPanel_siguiente.Controls.Add(this.button_siguiente, 1, 0);
            this.tableLayoutPanel_siguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_siguiente.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_siguiente.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_siguiente.Name = "tableLayoutPanel_siguiente";
            this.tableLayoutPanel_siguiente.RowCount = 1;
            this.tableLayoutPanel_siguiente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_siguiente.Size = new System.Drawing.Size(707, 70);
            this.tableLayoutPanel_siguiente.TabIndex = 28;
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.buttonAnterior.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnterior.Image = global::FundacionTalitaKumi.Properties.Resources.anterior1;
            this.buttonAnterior.Location = new System.Drawing.Point(3, 12);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(81, 55);
            this.buttonAnterior.TabIndex = 29;
            this.buttonAnterior.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonAnterior.UseVisualStyleBackColor = false;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_siguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_siguiente.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_siguiente.Image = global::FundacionTalitaKumi.Properties.Resources.siguiente1;
            this.button_siguiente.Location = new System.Drawing.Point(623, 12);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(81, 55);
            this.button_siguiente.TabIndex = 28;
            this.button_siguiente.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_siguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_siguiente.UseVisualStyleBackColor = false;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // panel_datos
            // 
            this.panel_datos.ColumnCount = 1;
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos.Location = new System.Drawing.Point(0, 110);
            this.panel_datos.Margin = new System.Windows.Forms.Padding(0);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.RowCount = 1;
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_datos.Size = new System.Drawing.Size(707, 385);
            this.panel_datos.TabIndex = 27;
            // 
            // ConsultarDatosBeneficiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 616);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarDatosBeneficiarias";
            this.Text = "ConsultarDatosBeneficiarias";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Beneficiaria)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel_general.ResumeLayout(false);
            this.panel_general.PerformLayout();
            this.tableLayoutPanel_siguiente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView_Beneficiaria;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_buscarPor;
        private System.Windows.Forms.TextBox textBox_datoConsulta;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.TableLayoutPanel panel_general;
        private System.Windows.Forms.TableLayoutPanel panel_datos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_siguiente;
        public System.Windows.Forms.Button button_siguiente;
        public System.Windows.Forms.Button button_regresar;
        public System.Windows.Forms.Button buttonAnterior;
        public System.Windows.Forms.Label label_subtitulo;
    }
}