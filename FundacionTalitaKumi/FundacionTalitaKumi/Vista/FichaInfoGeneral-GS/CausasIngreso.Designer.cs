namespace FundacionTalitaKumi.Vista.FichaInfoGeneral_GS
{
    partial class CausasIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CausasIngreso));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_botones = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_guardar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.panel_datos = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_motivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_ordenJudicial = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_botones.SuspendLayout();
            this.panel_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_botones, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel_datos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.03738F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.96262F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 642);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.panel_botones.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.panel_botones, 6);
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9977F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9997F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9997F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9997F));
            this.panel_botones.Controls.Add(this.buttonCancelar, 0, 0);
            this.panel_botones.Controls.Add(this.button_actualizar, 0, 0);
            this.panel_botones.Controls.Add(this.button_guardar, 1, 0);
            this.panel_botones.Controls.Add(this.button_limpiar, 3, 0);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_botones.Location = new System.Drawing.Point(0, 501);
            this.panel_botones.Margin = new System.Windows.Forms.Padding(0);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.RowCount = 1;
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_botones.Size = new System.Drawing.Size(1056, 141);
            this.panel_botones.TabIndex = 73;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::FundacionTalitaKumi.Properties.Resources.cancelar;
            this.buttonCancelar.Location = new System.Drawing.Point(306, 16);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(178, 122);
            this.buttonCancelar.TabIndex = 9;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click_1);
            // 
            // button_actualizar
            // 
            this.button_actualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_actualizar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.Image = global::FundacionTalitaKumi.Properties.Resources.actualizar;
            this.button_actualizar.Location = new System.Drawing.Point(42, 16);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(178, 122);
            this.button_actualizar.TabIndex = 6;
            this.button_actualizar.Text = "Actualizar Datos";
            this.button_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_guardar
            // 
            this.button_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_guardar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.Location = new System.Drawing.Point(570, 16);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(178, 122);
            this.button_guardar.TabIndex = 3;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click_1);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_limpiar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("button_limpiar.Image")));
            this.button_limpiar.Location = new System.Drawing.Point(834, 16);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(178, 122);
            this.button_limpiar.TabIndex = 4;
            this.button_limpiar.Text = "Limpiar Datos";
            this.button_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_limpiar.UseVisualStyleBackColor = false;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click_1);
            // 
            // panel_datos
            // 
            this.panel_datos.AutoScroll = true;
            this.panel_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.panel_datos.ColumnCount = 6;
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82505F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.82505F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.74629F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.21858F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.711969F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67306F));
            this.panel_datos.Controls.Add(this.textBox_motivo, 3, 3);
            this.panel_datos.Controls.Add(this.label8, 2, 3);
            this.panel_datos.Controls.Add(this.label11, 2, 2);
            this.panel_datos.Controls.Add(this.comboBox_ordenJudicial, 3, 2);
            this.panel_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos.Location = new System.Drawing.Point(0, 0);
            this.panel_datos.Margin = new System.Windows.Forms.Padding(0);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.RowCount = 5;
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_datos.Size = new System.Drawing.Size(1056, 501);
            this.panel_datos.TabIndex = 21;
            // 
            // textBox_motivo
            // 
            this.textBox_motivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_motivo.Location = new System.Drawing.Point(492, 180);
            this.textBox_motivo.Multiline = true;
            this.textBox_motivo.Name = "textBox_motivo";
            this.textBox_motivo.Size = new System.Drawing.Size(302, 138);
            this.textBox_motivo.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(273, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 162);
            this.label8.TabIndex = 71;
            this.label8.Text = "Motivos de Ingreso:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(273, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 118);
            this.label11.TabIndex = 58;
            this.label11.Text = "La jóven ingresó por Orden Judicial:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_ordenJudicial
            // 
            this.comboBox_ordenJudicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ordenJudicial.Enabled = false;
            this.comboBox_ordenJudicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_ordenJudicial.FormattingEnabled = true;
            this.comboBox_ordenJudicial.Items.AddRange(new object[] {
            "SÍ",
            "NO"});
            this.comboBox_ordenJudicial.Location = new System.Drawing.Point(492, 96);
            this.comboBox_ordenJudicial.Name = "comboBox_ordenJudicial";
            this.comboBox_ordenJudicial.Size = new System.Drawing.Size(302, 24);
            this.comboBox_ordenJudicial.TabIndex = 1;
            // 
            // CausasIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CausasIngreso";
            this.Text = "Causas de Ingreso a la Fundación";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_botones.ResumeLayout(false);
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel panel_botones;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.TableLayoutPanel panel_datos;
        private System.Windows.Forms.TextBox textBox_motivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_ordenJudicial;
    }
}