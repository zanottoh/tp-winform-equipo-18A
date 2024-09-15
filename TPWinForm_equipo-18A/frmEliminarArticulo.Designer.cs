namespace TPWinForm_equipo_18A
{
    partial class frmEliminarArticulo
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
            this.lblEliminar = new System.Windows.Forms.Label();
            this.btnEliminarFisica = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCodigoEstandar = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbNombreEstandar = new System.Windows.Forms.Label();
            this.lbMarcaEstandar = new System.Windows.Forms.Label();
            this.lbCategoriaEstandar = new System.Windows.Forms.Label();
            this.lbPrecioEstandar = new System.Windows.Forms.Label();
            this.lbDescripcionEstandar = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(79, 21);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(253, 25);
            this.lblEliminar.TabIndex = 0;
            this.lblEliminar.Text = "Eliminación de Articulo";
            // 
            // btnEliminarFisica
            // 
            this.btnEliminarFisica.Location = new System.Drawing.Point(58, 384);
            this.btnEliminarFisica.Name = "btnEliminarFisica";
            this.btnEliminarFisica.Size = new System.Drawing.Size(162, 23);
            this.btnEliminarFisica.TabIndex = 1;
            this.btnEliminarFisica.Text = "Eliminar";
            this.btnEliminarFisica.UseVisualStyleBackColor = true;
            this.btnEliminarFisica.Click += new System.EventHandler(this.btnEliminarFisica_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(270, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(162, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCodigoEstandar
            // 
            this.lbCodigoEstandar.AutoSize = true;
            this.lbCodigoEstandar.Location = new System.Drawing.Point(81, 71);
            this.lbCodigoEstandar.Name = "lbCodigoEstandar";
            this.lbCodigoEstandar.Size = new System.Drawing.Size(96, 13);
            this.lbCodigoEstandar.TabIndex = 4;
            this.lbCodigoEstandar.Text = "Codigo de Articulo:";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(183, 71);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 6;
            this.lbCodigo.Text = "Codigo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(183, 102);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Nombre";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(183, 132);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(37, 13);
            this.lbMarca.TabIndex = 8;
            this.lbMarca.Text = "Marca";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(183, 162);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(52, 13);
            this.lbCategoria.TabIndex = 9;
            this.lbCategoria.Text = "Categoria";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(183, 191);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(37, 13);
            this.lbPrecio.TabIndex = 10;
            this.lbPrecio.Text = "Precio";
            // 
            // lbNombreEstandar
            // 
            this.lbNombreEstandar.AutoSize = true;
            this.lbNombreEstandar.Location = new System.Drawing.Point(130, 102);
            this.lbNombreEstandar.Name = "lbNombreEstandar";
            this.lbNombreEstandar.Size = new System.Drawing.Size(47, 13);
            this.lbNombreEstandar.TabIndex = 11;
            this.lbNombreEstandar.Text = "Nombre:";
            // 
            // lbMarcaEstandar
            // 
            this.lbMarcaEstandar.AutoSize = true;
            this.lbMarcaEstandar.Location = new System.Drawing.Point(137, 132);
            this.lbMarcaEstandar.Name = "lbMarcaEstandar";
            this.lbMarcaEstandar.Size = new System.Drawing.Size(40, 13);
            this.lbMarcaEstandar.TabIndex = 12;
            this.lbMarcaEstandar.Text = "Marca:";
            // 
            // lbCategoriaEstandar
            // 
            this.lbCategoriaEstandar.AutoSize = true;
            this.lbCategoriaEstandar.Location = new System.Drawing.Point(122, 162);
            this.lbCategoriaEstandar.Name = "lbCategoriaEstandar";
            this.lbCategoriaEstandar.Size = new System.Drawing.Size(55, 13);
            this.lbCategoriaEstandar.TabIndex = 13;
            this.lbCategoriaEstandar.Text = "Categoria:";
            // 
            // lbPrecioEstandar
            // 
            this.lbPrecioEstandar.AutoSize = true;
            this.lbPrecioEstandar.Location = new System.Drawing.Point(137, 191);
            this.lbPrecioEstandar.Name = "lbPrecioEstandar";
            this.lbPrecioEstandar.Size = new System.Drawing.Size(40, 13);
            this.lbPrecioEstandar.TabIndex = 14;
            this.lbPrecioEstandar.Text = "Precio:";
            // 
            // lbDescripcionEstandar
            // 
            this.lbDescripcionEstandar.AutoSize = true;
            this.lbDescripcionEstandar.Location = new System.Drawing.Point(111, 220);
            this.lbDescripcionEstandar.Name = "lbDescripcionEstandar";
            this.lbDescripcionEstandar.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcionEstandar.TabIndex = 15;
            this.lbDescripcionEstandar.Text = "Descripcion:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Enabled = false;
            this.rtbDescripcion.Location = new System.Drawing.Point(114, 248);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.ReadOnly = true;
            this.rtbDescripcion.Size = new System.Drawing.Size(274, 96);
            this.rtbDescripcion.TabIndex = 16;
            this.rtbDescripcion.Text = "";
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(428, 65);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(285, 279);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 17;
            this.pbImagen.TabStop = false;
            // 
            // frmEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 448);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.rtbDescripcion);
            this.Controls.Add(this.lbDescripcionEstandar);
            this.Controls.Add(this.lbPrecioEstandar);
            this.Controls.Add(this.lbCategoriaEstandar);
            this.Controls.Add(this.lbMarcaEstandar);
            this.Controls.Add(this.lbNombreEstandar);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbCodigoEstandar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarFisica);
            this.Controls.Add(this.lblEliminar);
            this.Name = "frmEliminarArticulo";
            this.Text = "frmEliminarArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminarFisica;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbCodigoEstandar;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbNombreEstandar;
        private System.Windows.Forms.Label lbMarcaEstandar;
        private System.Windows.Forms.Label lbCategoriaEstandar;
        private System.Windows.Forms.Label lbPrecioEstandar;
        private System.Windows.Forms.Label lbDescripcionEstandar;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}