namespace TPWinForm_equipo_18A
{
    partial class frmList
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblElegirProducto = new System.Windows.Forms.Label();
            this.cbCategoriaList = new System.Windows.Forms.ComboBox();
            this.dgbListar = new System.Windows.Forms.DataGridView();
            this.pBArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(372, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(335, 36);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Listado de Productos: ";
            // 
            // lblElegirProducto
            // 
            this.lblElegirProducto.AutoSize = true;
            this.lblElegirProducto.Location = new System.Drawing.Point(26, 75);
            this.lblElegirProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElegirProducto.Name = "lblElegirProducto";
            this.lblElegirProducto.Size = new System.Drawing.Size(283, 16);
            this.lblElegirProducto.TabIndex = 13;
            this.lblElegirProducto.Text = "Elija la categoria de producto que quiere listar:";
            // 
            // cbCategoriaList
            // 
            this.cbCategoriaList.FormattingEnabled = true;
            this.cbCategoriaList.Location = new System.Drawing.Point(326, 72);
            this.cbCategoriaList.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoriaList.Name = "cbCategoriaList";
            this.cbCategoriaList.Size = new System.Drawing.Size(209, 24);
            this.cbCategoriaList.TabIndex = 14;
            this.cbCategoriaList.SelectedIndexChanged += new System.EventHandler(this.cbEleccionArticulo_SelectedIndexChanged);
            // 
            // dgbListar
            // 
            this.dgbListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListar.Location = new System.Drawing.Point(29, 130);
            this.dgbListar.Name = "dgbListar";
            this.dgbListar.RowHeadersWidth = 51;
            this.dgbListar.RowTemplate.Height = 24;
            this.dgbListar.Size = new System.Drawing.Size(964, 319);
            this.dgbListar.TabIndex = 15;
            // 
            // pBArticulo
            // 
            this.pBArticulo.Location = new System.Drawing.Point(1009, 130);
            this.pBArticulo.Name = "pBArticulo";
            this.pBArticulo.Size = new System.Drawing.Size(346, 319);
            this.pBArticulo.TabIndex = 16;
            this.pBArticulo.TabStop = false;
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 501);
            this.Controls.Add(this.pBArticulo);
            this.Controls.Add(this.dgbListar);
            this.Controls.Add(this.cbCategoriaList);
            this.Controls.Add(this.lblElegirProducto);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmList";
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbListar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblElegirProducto;
        private System.Windows.Forms.ComboBox cbCategoriaList;
        private System.Windows.Forms.DataGridView dgbListar;
        private System.Windows.Forms.PictureBox pBArticulo;

    }
}