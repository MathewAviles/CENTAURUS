namespace CapaPresentacion
{
    partial class FrmNegocio
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btngardarcambios = new FontAwesome.Sharp.IconButton();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombrenegocio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubir = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Detalle del Negocio";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 522);
            this.label1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btngardarcambios);
            this.groupBox1.Controls.Add(this.txtruc);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtnombrenegocio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnsubir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pblogo);
            this.groupBox1.Location = new System.Drawing.Point(265, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 277);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // btngardarcambios
            // 
            this.btngardarcambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngardarcambios.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btngardarcambios.IconColor = System.Drawing.Color.Black;
            this.btngardarcambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngardarcambios.IconSize = 30;
            this.btngardarcambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngardarcambios.Location = new System.Drawing.Point(251, 223);
            this.btngardarcambios.Name = "btngardarcambios";
            this.btngardarcambios.Size = new System.Drawing.Size(290, 33);
            this.btngardarcambios.TabIndex = 8;
            this.btngardarcambios.Text = "Guardar Cambios";
            this.btngardarcambios.UseVisualStyleBackColor = true;
            this.btngardarcambios.Click += new System.EventHandler(this.btngardarcambios_Click);
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(251, 121);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(290, 22);
            this.txtruc.TabIndex = 7;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(251, 185);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(290, 22);
            this.txtdireccion.TabIndex = 7;
            // 
            // txtnombrenegocio
            // 
            this.txtnombrenegocio.Location = new System.Drawing.Point(251, 59);
            this.txtnombrenegocio.Name = "txtnombrenegocio";
            this.txtnombrenegocio.Size = new System.Drawing.Size(290, 22);
            this.txtnombrenegocio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "RUC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del Negocio:";
            // 
            // btnsubir
            // 
            this.btnsubir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnsubir.IconColor = System.Drawing.Color.Black;
            this.btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsubir.IconSize = 30;
            this.btnsubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubir.Location = new System.Drawing.Point(37, 223);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(190, 33);
            this.btnsubir.TabIndex = 2;
            this.btnsubir.Text = "Subir";
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logo";
            // 
            // pblogo
            // 
            this.pblogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pblogo.Location = new System.Drawing.Point(37, 59);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(190, 148);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(262, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(615, 45);
            this.label6.TabIndex = 50;
            // 
            // FrmNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 583);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmNegocio";
            this.Text = "FrmNegocio";
            this.Load += new System.EventHandler(this.FrmNegocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnsubir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pblogo;
        private FontAwesome.Sharp.IconButton btngardarcambios;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombrenegocio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}