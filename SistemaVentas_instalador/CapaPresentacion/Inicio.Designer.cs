namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MENUUSUARIOS = new FontAwesome.Sharp.IconMenuItem();
            this.MENUMANTENEDOR = new FontAwesome.Sharp.IconMenuItem();
            this.submenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.submenuProductos = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUVENTAS = new FontAwesome.Sharp.IconMenuItem();
            this.submenuRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            this.submenuVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MENUCLIENTES = new FontAwesome.Sharp.IconMenuItem();
            this.MENUREPORTES = new FontAwesome.Sharp.IconMenuItem();
            this.submenureporteventas = new System.Windows.Forms.ToolStripMenuItem();
            this.MENUACERCADE = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.TutuloSistema = new System.Windows.Forms.Label();
            this.CONTENEDOR = new System.Windows.Forms.Panel();
            this.lbl_TituloUsuario = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MENUUSUARIOS,
            this.MENUMANTENEDOR,
            this.MENUVENTAS,
            this.MENUCLIENTES,
            this.MENUREPORTES,
            this.MENUACERCADE});
            this.menu.Location = new System.Drawing.Point(0, 54);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1178, 78);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // MENUUSUARIOS
            // 
            this.MENUUSUARIOS.AutoSize = false;
            this.MENUUSUARIOS.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.MENUUSUARIOS.IconChar = FontAwesome.Sharp.IconChar.User;
            this.MENUUSUARIOS.IconColor = System.Drawing.Color.Black;
            this.MENUUSUARIOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENUUSUARIOS.IconSize = 55;
            this.MENUUSUARIOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENUUSUARIOS.Name = "MENUUSUARIOS";
            this.MENUUSUARIOS.Size = new System.Drawing.Size(85, 74);
            this.MENUUSUARIOS.Text = "USUARIO";
            this.MENUUSUARIOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MENUUSUARIOS.Click += new System.EventHandler(this.MENUUSUARIOS_Click);
            // 
            // MENUMANTENEDOR
            // 
            this.MENUMANTENEDOR.AutoSize = false;
            this.MENUMANTENEDOR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuCategoria,
            this.submenuProductos,
            this.SubmenuNegocio});
            this.MENUMANTENEDOR.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.MENUMANTENEDOR.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.MENUMANTENEDOR.IconColor = System.Drawing.Color.Black;
            this.MENUMANTENEDOR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENUMANTENEDOR.IconSize = 55;
            this.MENUMANTENEDOR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENUMANTENEDOR.Name = "MENUMANTENEDOR";
            this.MENUMANTENEDOR.Size = new System.Drawing.Size(105, 74);
            this.MENUMANTENEDOR.Text = "MANTENEDOR";
            this.MENUMANTENEDOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuCategoria
            // 
            this.submenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuCategoria.IconColor = System.Drawing.Color.Black;
            this.submenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuCategoria.Name = "submenuCategoria";
            this.submenuCategoria.Size = new System.Drawing.Size(144, 26);
            this.submenuCategoria.Text = "Categorias";
            this.submenuCategoria.Click += new System.EventHandler(this.submenuCategoria_Click);
            // 
            // submenuProductos
            // 
            this.submenuProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuProductos.IconColor = System.Drawing.Color.Black;
            this.submenuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuProductos.Name = "submenuProductos";
            this.submenuProductos.Size = new System.Drawing.Size(144, 26);
            this.submenuProductos.Text = "Productos";
            this.submenuProductos.Click += new System.EventHandler(this.submenuProductos_Click);
            // 
            // SubmenuNegocio
            // 
            this.SubmenuNegocio.Name = "SubmenuNegocio";
            this.SubmenuNegocio.Size = new System.Drawing.Size(144, 26);
            this.SubmenuNegocio.Text = "Negocio";
            this.SubmenuNegocio.Click += new System.EventHandler(this.SubmenuNegocio_Click);
            // 
            // MENUVENTAS
            // 
            this.MENUVENTAS.AutoSize = false;
            this.MENUVENTAS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuRegistrarVenta,
            this.submenuVerDetalleVenta});
            this.MENUVENTAS.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.MENUVENTAS.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.MENUVENTAS.IconColor = System.Drawing.Color.Black;
            this.MENUVENTAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENUVENTAS.IconSize = 55;
            this.MENUVENTAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENUVENTAS.Name = "MENUVENTAS";
            this.MENUVENTAS.Size = new System.Drawing.Size(85, 74);
            this.MENUVENTAS.Text = "VENTAS";
            this.MENUVENTAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuRegistrarVenta
            // 
            this.submenuRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.submenuRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuRegistrarVenta.Name = "submenuRegistrarVenta";
            this.submenuRegistrarVenta.Size = new System.Drawing.Size(156, 26);
            this.submenuRegistrarVenta.Text = "Registrar";
            this.submenuRegistrarVenta.Click += new System.EventHandler(this.submenuRegistrarVenta_Click);
            // 
            // submenuVerDetalleVenta
            // 
            this.submenuVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuVerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.submenuVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuVerDetalleVenta.Name = "submenuVerDetalleVenta";
            this.submenuVerDetalleVenta.Size = new System.Drawing.Size(156, 26);
            this.submenuVerDetalleVenta.Text = "Detalle Venta";
            this.submenuVerDetalleVenta.Click += new System.EventHandler(this.submenuVerDetalleVenta_Click);
            // 
            // MENUCLIENTES
            // 
            this.MENUCLIENTES.AutoSize = false;
            this.MENUCLIENTES.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.MENUCLIENTES.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MENUCLIENTES.IconColor = System.Drawing.Color.Black;
            this.MENUCLIENTES.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENUCLIENTES.IconSize = 55;
            this.MENUCLIENTES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENUCLIENTES.Name = "MENUCLIENTES";
            this.MENUCLIENTES.Size = new System.Drawing.Size(85, 74);
            this.MENUCLIENTES.Text = "CLIENTES";
            this.MENUCLIENTES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MENUCLIENTES.Click += new System.EventHandler(this.MENUCLIENTES_Click);
            // 
            // MENUREPORTES
            // 
            this.MENUREPORTES.AutoSize = false;
            this.MENUREPORTES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenureporteventas});
            this.MENUREPORTES.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.MENUREPORTES.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.MENUREPORTES.IconColor = System.Drawing.Color.Black;
            this.MENUREPORTES.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENUREPORTES.IconSize = 55;
            this.MENUREPORTES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENUREPORTES.Name = "MENUREPORTES";
            this.MENUREPORTES.Size = new System.Drawing.Size(85, 74);
            this.MENUREPORTES.Text = "REPORTES";
            this.MENUREPORTES.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenureporteventas
            // 
            this.submenureporteventas.Name = "submenureporteventas";
            this.submenureporteventas.Size = new System.Drawing.Size(182, 26);
            this.submenureporteventas.Text = "Reporte de Ventas";
            this.submenureporteventas.Click += new System.EventHandler(this.submenureporteventas_Click);
            // 
            // MENUACERCADE
            // 
            this.MENUACERCADE.AutoSize = false;
            this.MENUACERCADE.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.MENUACERCADE.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.MENUACERCADE.IconColor = System.Drawing.Color.Black;
            this.MENUACERCADE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MENUACERCADE.IconSize = 55;
            this.MENUACERCADE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MENUACERCADE.Name = "MENUACERCADE";
            this.MENUACERCADE.Size = new System.Drawing.Size(85, 74);
            this.MENUACERCADE.Text = "ACERCA DE";
            this.MENUACERCADE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MENUACERCADE.Click += new System.EventHandler(this.MENUACERCADE_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.Tomato;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1178, 54);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // TutuloSistema
            // 
            this.TutuloSistema.AutoSize = true;
            this.TutuloSistema.BackColor = System.Drawing.Color.Tomato;
            this.TutuloSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutuloSistema.Location = new System.Drawing.Point(13, 13);
            this.TutuloSistema.Name = "TutuloSistema";
            this.TutuloSistema.Size = new System.Drawing.Size(436, 29);
            this.TutuloSistema.TabIndex = 2;
            this.TutuloSistema.Text = "SISTEMA DE VENTAS CENTAURUS";
            this.TutuloSistema.Click += new System.EventHandler(this.TutuloSistema_Click);
            // 
            // CONTENEDOR
            // 
            this.CONTENEDOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CONTENEDOR.Location = new System.Drawing.Point(0, 132);
            this.CONTENEDOR.Name = "CONTENEDOR";
            this.CONTENEDOR.Size = new System.Drawing.Size(1178, 612);
            this.CONTENEDOR.TabIndex = 3;
            // 
            // lbl_TituloUsuario
            // 
            this.lbl_TituloUsuario.AutoSize = true;
            this.lbl_TituloUsuario.BackColor = System.Drawing.Color.Tomato;
            this.lbl_TituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloUsuario.Location = new System.Drawing.Point(953, 24);
            this.lbl_TituloUsuario.Name = "lbl_TituloUsuario";
            this.lbl_TituloUsuario.Size = new System.Drawing.Size(64, 18);
            this.lbl_TituloUsuario.TabIndex = 4;
            this.lbl_TituloUsuario.Text = "Usuario:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Tomato;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(1013, 24);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(16, 18);
            this.lbl_Usuario.TabIndex = 5;
            this.lbl_Usuario.Text = "..";
            this.lbl_Usuario.Click += new System.EventHandler(this.lbl_Usuario_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Tomato;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.Location = new System.Drawing.Point(1095, 10);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(47, 41);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_TituloUsuario);
            this.Controls.Add(this.CONTENEDOR);
            this.Controls.Add(this.TutuloSistema);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label TutuloSistema;
        private FontAwesome.Sharp.IconMenuItem MENUUSUARIOS;
        private FontAwesome.Sharp.IconMenuItem MENUMANTENEDOR;
        private FontAwesome.Sharp.IconMenuItem MENUVENTAS;
        private FontAwesome.Sharp.IconMenuItem MENUCLIENTES;
        private FontAwesome.Sharp.IconMenuItem MENUREPORTES;
        private FontAwesome.Sharp.IconMenuItem MENUACERCADE;
        private System.Windows.Forms.Panel CONTENEDOR;
        private System.Windows.Forms.Label lbl_TituloUsuario;
        private System.Windows.Forms.Label lbl_Usuario;
        private FontAwesome.Sharp.IconMenuItem submenuCategoria;
        private FontAwesome.Sharp.IconMenuItem submenuProductos;
        private FontAwesome.Sharp.IconMenuItem submenuRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem submenuVerDetalleVenta;
        private System.Windows.Forms.ToolStripMenuItem SubmenuNegocio;
        private System.Windows.Forms.ToolStripMenuItem submenureporteventas;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}

