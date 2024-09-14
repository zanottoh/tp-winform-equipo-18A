namespace TPWinForm_equipo_18A
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcaToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgbPrincipal = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.pbxImagenSeleccion = new System.Windows.Forms.PictureBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoriaToolstrip,
            this.agregarMarcaToolstrip});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // agregarCategoriaToolstrip
            // 
            this.agregarCategoriaToolstrip.Name = "agregarCategoriaToolstrip";
            this.agregarCategoriaToolstrip.Size = new System.Drawing.Size(170, 22);
            this.agregarCategoriaToolstrip.Text = "Agregar Categoría";
            this.agregarCategoriaToolstrip.Click += new System.EventHandler(this.agregarCategoriaToolstrip_Click);
            // 
            // agregarMarcaToolstrip
            // 
            this.agregarMarcaToolstrip.Name = "agregarMarcaToolstrip";
            this.agregarMarcaToolstrip.Size = new System.Drawing.Size(170, 22);
            this.agregarMarcaToolstrip.Text = "Agregar Marca";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgbPrincipal
            // 
            this.dgbPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbPrincipal.Location = new System.Drawing.Point(62, 152);
            this.dgbPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.dgbPrincipal.MultiSelect = false;
            this.dgbPrincipal.Name = "dgbPrincipal";
            this.dgbPrincipal.ReadOnly = true;
            this.dgbPrincipal.RowHeadersWidth = 51;
            this.dgbPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgbPrincipal.RowTemplate.Height = 24;
            this.dgbPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbPrincipal.Size = new System.Drawing.Size(655, 214);
            this.dgbPrincipal.TabIndex = 4;
            this.dgbPrincipal.SelectionChanged += new System.EventHandler(this.dgbPrincipal_SelectionChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(304, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Listado de Artículos";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(309, 380);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 32);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(624, 380);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 32);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(62, 380);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 31);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar por Categoría:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filtrar por Marca:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(160, 91);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(134, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(160, 122);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(134, 21);
            this.cbMarca.TabIndex = 13;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(597, 118);
            this.btnBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(2);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(120, 20);
            this.btnBusquedaAvanzada.TabIndex = 14;
            this.btnBusquedaAvanzada.Text = "Busqueda avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // pbxImagenSeleccion
            // 
            this.pbxImagenSeleccion.Location = new System.Drawing.Point(794, 35);
            this.pbxImagenSeleccion.Name = "pbxImagenSeleccion";
            this.pbxImagenSeleccion.Size = new System.Drawing.Size(325, 316);
            this.pbxImagenSeleccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenSeleccion.TabIndex = 15;
            this.pbxImagenSeleccion.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(309, 91);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 16;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(309, 121);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(103, 23);
            this.btnLimpiarFiltro.TabIndex = 17;
            this.btnLimpiarFiltro.Text = "Limpiar Filtros";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 479);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.pbxImagenSeleccion);
            this.Controls.Add(this.btnBusquedaAvanzada);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgbPrincipal);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrincipal";
            this.Text = "Gestor de Articulos";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenSeleccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolstrip;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolstrip;
        private System.Windows.Forms.DataGridView dgbPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.PictureBox pbxImagenSeleccion;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}

