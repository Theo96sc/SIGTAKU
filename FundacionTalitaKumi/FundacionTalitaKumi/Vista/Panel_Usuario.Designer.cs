namespace FundacionTalitaKumi.Vista
{
    partial class Panel_Usuario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_cargo = new System.Windows.Forms.Label();
            this.label_NyA = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_cargo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_NyA, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_hora, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.69006F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.12865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.39181F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::FundacionTalitaKumi.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label_cargo
            // 
            this.label_cargo.AutoSize = true;
            this.label_cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_cargo.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cargo.Location = new System.Drawing.Point(0, 193);
            this.label_cargo.Margin = new System.Windows.Forms.Padding(0);
            this.label_cargo.Name = "label_cargo";
            this.label_cargo.Size = new System.Drawing.Size(800, 68);
            this.label_cargo.TabIndex = 1;
            this.label_cargo.Text = "Cargo";
            this.label_cargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_NyA
            // 
            this.label_NyA.AutoSize = true;
            this.label_NyA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_NyA.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NyA.Location = new System.Drawing.Point(0, 261);
            this.label_NyA.Margin = new System.Windows.Forms.Padding(0);
            this.label_NyA.Name = "label_NyA";
            this.label_NyA.Size = new System.Drawing.Size(800, 82);
            this.label_NyA.TabIndex = 2;
            this.label_NyA.Text = "Nombre y Apellido";
            this.label_NyA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hora
            // 
            this.label_hora.AutoSize = true;
            this.label_hora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_hora.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.Location = new System.Drawing.Point(0, 343);
            this.label_hora.Margin = new System.Windows.Forms.Padding(0);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(800, 107);
            this.label_hora.TabIndex = 3;
            this.label_hora.Text = "Fecha y Hora";
            this.label_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(197)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_Usuario";
            this.Text = "Panel_Usuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_cargo;
        private System.Windows.Forms.Label label_NyA;
        private System.Windows.Forms.Label label_hora;
    }
}