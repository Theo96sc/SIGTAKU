﻿namespace FundacionTalitaKumi.Vista
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.panel_datos = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_cedula = new System.Windows.Forms.ComboBox();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_confirmarContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_botones = new System.Windows.Forms.TableLayoutPanel();
            this.button_guardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button_verConstrasena = new System.Windows.Forms.Button();
            this.panel_datos.SuspendLayout();
            this.panel_botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_datos
            // 
            this.panel_datos.AutoScroll = true;
            this.panel_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.panel_datos.ColumnCount = 4;
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.55635F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78219F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.71939F));
            this.panel_datos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.94206F));
            this.panel_datos.Controls.Add(this.comboBox_cedula, 1, 3);
            this.panel_datos.Controls.Add(this.textBox_usuario, 2, 3);
            this.panel_datos.Controls.Add(this.textBox_confirmarContrasena, 2, 5);
            this.panel_datos.Controls.Add(this.label1, 1, 5);
            this.panel_datos.Controls.Add(this.panel_botones, 0, 9);
            this.panel_datos.Controls.Add(this.label16, 1, 2);
            this.panel_datos.Controls.Add(this.textBox_contrasena, 2, 4);
            this.panel_datos.Controls.Add(this.label15, 1, 4);
            this.panel_datos.Controls.Add(this.label17, 1, 6);
            this.panel_datos.Controls.Add(this.button_verConstrasena, 3, 5);
            this.panel_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datos.Location = new System.Drawing.Point(0, 0);
            this.panel_datos.Margin = new System.Windows.Forms.Padding(0);
            this.panel_datos.Name = "panel_datos";
            this.panel_datos.RowCount = 10;
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_datos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_datos.Size = new System.Drawing.Size(839, 514);
            this.panel_datos.TabIndex = 23;
            // 
            // comboBox_cedula
            // 
            this.comboBox_cedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_cedula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_cedula.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cedula.FormattingEnabled = true;
            this.comboBox_cedula.Items.AddRange(new object[] {
            "Cédula de Ciudadanía:",
            "Pasaporte:"});
            this.comboBox_cedula.Location = new System.Drawing.Point(141, 65);
            this.comboBox_cedula.Name = "comboBox_cedula";
            this.comboBox_cedula.Size = new System.Drawing.Size(218, 29);
            this.comboBox_cedula.TabIndex = 88;
            this.comboBox_cedula.Text = "Tipo de Identificación*";
            this.comboBox_cedula.SelectedIndexChanged += new System.EventHandler(this.comboBox_cedula_SelectedIndexChanged);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.Location = new System.Drawing.Point(365, 66);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(310, 27);
            this.textBox_usuario.TabIndex = 87;
            // 
            // textBox_confirmarContrasena
            // 
            this.textBox_confirmarContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_confirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirmarContrasena.Location = new System.Drawing.Point(365, 186);
            this.textBox_confirmarContrasena.Name = "textBox_confirmarContrasena";
            this.textBox_confirmarContrasena.PasswordChar = '*';
            this.textBox_confirmarContrasena.Size = new System.Drawing.Size(310, 27);
            this.textBox_confirmarContrasena.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 60);
            this.label1.TabIndex = 86;
            this.label1.Text = "Confirmar Contraseña*: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.panel_botones.ColumnCount = 5;
            this.panel_datos.SetColumnSpan(this.panel_botones, 5);
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99851F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.panel_botones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005F));
            this.panel_botones.Controls.Add(this.button_guardar, 4, 0);
            this.panel_botones.Controls.Add(this.buttonCancelar, 3, 0);
            this.panel_botones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_botones.Location = new System.Drawing.Point(0, 400);
            this.panel_botones.Margin = new System.Windows.Forms.Padding(0);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.RowCount = 1;
            this.panel_botones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panel_botones.Size = new System.Drawing.Size(839, 114);
            this.panel_botones.TabIndex = 84;
            // 
            // button_guardar
            // 
            this.button_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.button_guardar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.Image = ((System.Drawing.Image)(resources.GetObject("button_guardar.Image")));
            this.button_guardar.Location = new System.Drawing.Point(675, 3);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(156, 110);
            this.button_guardar.TabIndex = 3;
            this.button_guardar.Text = "Guardar";
            this.button_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = global::FundacionTalitaKumi.Properties.Resources.cancelar;
            this.buttonCancelar.Location = new System.Drawing.Point(507, 3);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(154, 110);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_datos.SetColumnSpan(this.label16, 2);
            this.label16.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(141, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(534, 30);
            this.label16.TabIndex = 82;
            this.label16.Text = "Crear Usuario";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contrasena.Location = new System.Drawing.Point(365, 126);
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.PasswordChar = '*';
            this.textBox_contrasena.Size = new System.Drawing.Size(310, 27);
            this.textBox_contrasena.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(141, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(218, 60);
            this.label15.TabIndex = 79;
            this.label15.Text = "Contraseña*: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.panel_datos.SetColumnSpan(this.label17, 2);
            this.label17.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(141, 230);
            this.label17.Name = "label17";
            this.panel_datos.SetRowSpan(this.label17, 2);
            this.label17.Size = new System.Drawing.Size(534, 60);
            this.label17.TabIndex = 83;
            this.label17.Text = "La contraseña debe tener mínimo: 8 caracteres, una Mayúscula, una Minúscula y un " +
    "número.";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_verConstrasena
            // 
            this.button_verConstrasena.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_verConstrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(223)))));
            this.button_verConstrasena.Image = global::FundacionTalitaKumi.Properties.Resources.ver1;
            this.button_verConstrasena.Location = new System.Drawing.Point(681, 178);
            this.button_verConstrasena.Name = "button_verConstrasena";
            this.button_verConstrasena.Size = new System.Drawing.Size(52, 44);
            this.button_verConstrasena.TabIndex = 81;
            this.button_verConstrasena.UseVisualStyleBackColor = false;
            this.button_verConstrasena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_verConstrasena_MouseDown);
            this.button_verConstrasena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_verConstrasena_MouseUp);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 514);
            this.Controls.Add(this.panel_datos);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearUsuario";
            this.panel_datos.ResumeLayout(false);
            this.panel_datos.PerformLayout();
            this.panel_botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panel_datos;
        private System.Windows.Forms.TextBox textBox_confirmarContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panel_botones;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_contrasena;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button_verConstrasena;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.ComboBox comboBox_cedula;
    }
}