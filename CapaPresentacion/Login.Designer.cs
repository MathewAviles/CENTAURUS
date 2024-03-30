namespace CapaPresentacion
{
    partial class Login
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
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_CANCELAR = new FontAwesome.Sharp.IconButton();
            this.BTN_INGRESAR = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 285);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(-2, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEMA DE VENTAS";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Tomato;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 139;
            this.iconPictureBox1.Location = new System.Drawing.Point(36, 29);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(143, 139);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(297, 105);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(179, 22);
            this.txt_cedula.TabIndex = 3;
            this.txt_cedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(297, 163);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(179, 22);
            this.txt_contraseña.TabIndex = 4;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "NÚMERO DE CÉDULA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CONTRASEÑA";
            // 
            // BTN_CANCELAR
            // 
            this.BTN_CANCELAR.BackColor = System.Drawing.Color.Red;
            this.BTN_CANCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CANCELAR.ForeColor = System.Drawing.Color.Black;
            this.BTN_CANCELAR.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.BTN_CANCELAR.IconColor = System.Drawing.Color.Black;
            this.BTN_CANCELAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_CANCELAR.Location = new System.Drawing.Point(528, 220);
            this.BTN_CANCELAR.Name = "BTN_CANCELAR";
            this.BTN_CANCELAR.Size = new System.Drawing.Size(179, 53);
            this.BTN_CANCELAR.TabIndex = 7;
            this.BTN_CANCELAR.Text = "CANCELAR";
            this.BTN_CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_CANCELAR.UseVisualStyleBackColor = false;
            this.BTN_CANCELAR.Click += new System.EventHandler(this.BTN_CANCELAR_Click);
            // 
            // BTN_INGRESAR
            // 
            this.BTN_INGRESAR.BackColor = System.Drawing.Color.SpringGreen;
            this.BTN_INGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_INGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_INGRESAR.ForeColor = System.Drawing.Color.Black;
            this.BTN_INGRESAR.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.BTN_INGRESAR.IconColor = System.Drawing.Color.Black;
            this.BTN_INGRESAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_INGRESAR.Location = new System.Drawing.Point(297, 220);
            this.BTN_INGRESAR.Name = "BTN_INGRESAR";
            this.BTN_INGRESAR.Size = new System.Drawing.Size(179, 53);
            this.BTN_INGRESAR.TabIndex = 8;
            this.BTN_INGRESAR.Text = "INGRESAR";
            this.BTN_INGRESAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_INGRESAR.UseVisualStyleBackColor = false;
            this.BTN_INGRESAR.Click += new System.EventHandler(this.BTNINGRESAR_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.BTN_INGRESAR);
            this.Controls.Add(this.BTN_CANCELAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BTN_CANCELAR;
        private FontAwesome.Sharp.IconButton BTN_INGRESAR;
    }
}