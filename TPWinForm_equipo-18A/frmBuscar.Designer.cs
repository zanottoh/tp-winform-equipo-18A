namespace TPWinForm_equipo_18A
{
    partial class frmBuscar
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
            this.txtBoxNombreBusqueda = new System.Windows.Forms.TextBox();
            this.cbCategoriaBusqueda = new System.Windows.Forms.ComboBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarcaBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBoxIdBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBusquedaAvanzada = new System.Windows.Forms.DataGridView();
            this.pbBusquedaAvanzada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaAvanzada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusquedaAvanzada)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNombreBusqueda
            // 
            this.txtBoxNombreBusqueda.Location = new System.Drawing.Point(274, 221);
            this.txtBoxNombreBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNombreBusqueda.Name = "txtBoxNombreBusqueda";
            this.txtBoxNombreBusqueda.Size = new System.Drawing.Size(170, 20);
            this.txtBoxNombreBusqueda.TabIndex = 0;
            // 
            // cbCategoriaBusqueda
            // 
            this.cbCategoriaBusqueda.FormattingEnabled = true;
            this.cbCategoriaBusqueda.Location = new System.Drawing.Point(274, 100);
            this.cbCategoriaBusqueda.Name = "cbCategoriaBusqueda";
            this.cbCategoriaBusqueda.Size = new System.Drawing.Size(170, 21);
            this.cbCategoriaBusqueda.TabIndex = 15;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(126, 103);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(127, 15);
            this.lblBusqueda.TabIndex = 16;
            this.lblBusqueda.Text = "Selecciona Categoría:";
            this.lblBusqueda.Click += new System.EventHandler(this.lblBusqueda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Selecciona Marca:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbMarcaBusqueda
            // 
            this.cbMarcaBusqueda.FormattingEnabled = true;
            this.cbMarcaBusqueda.Location = new System.Drawing.Point(274, 141);
            this.cbMarcaBusqueda.Name = "cbMarcaBusqueda";
            this.cbMarcaBusqueda.Size = new System.Drawing.Size(170, 21);
            this.cbMarcaBusqueda.TabIndex = 18;
            this.cbMarcaBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbParametro2_SelectedIndexChanged);
            // 
            // txtBoxIdBusqueda
            // 
            this.txtBoxIdBusqueda.Location = new System.Drawing.Point(274, 184);
            this.txtBoxIdBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxIdBusqueda.Name = "txtBoxIdBusqueda";
            this.txtBoxIdBusqueda.Size = new System.Drawing.Size(170, 20);
            this.txtBoxIdBusqueda.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "Búsqueda Avanzada";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(274, 263);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 39);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Código Artículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre:";
            // 
            // dgvBusquedaAvanzada
            // 
            this.dgvBusquedaAvanzada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaAvanzada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBusquedaAvanzada.Location = new System.Drawing.Point(21, 354);
            this.dgvBusquedaAvanzada.MultiSelect = false;
            this.dgvBusquedaAvanzada.Name = "dgvBusquedaAvanzada";
            this.dgvBusquedaAvanzada.RowHeadersWidth = 51;
            this.dgvBusquedaAvanzada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaAvanzada.Size = new System.Drawing.Size(739, 113);
            this.dgvBusquedaAvanzada.TabIndex = 24;
            // 
            // pbBusquedaAvanzada
            // 
            this.pbBusquedaAvanzada.Location = new System.Drawing.Point(766, 191);
            this.pbBusquedaAvanzada.Name = "pbBusquedaAvanzada";
            this.pbBusquedaAvanzada.Size = new System.Drawing.Size(304, 276);
            this.pbBusquedaAvanzada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBusquedaAvanzada.TabIndex = 25;
            this.pbBusquedaAvanzada.TabStop = false;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 594);
            this.Controls.Add(this.pbBusquedaAvanzada);
            this.Controls.Add(this.dgvBusquedaAvanzada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxIdBusqueda);
            this.Controls.Add(this.cbMarcaBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.cbCategoriaBusqueda);
            this.Controls.Add(this.txtBoxNombreBusqueda);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBuscar";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaAvanzada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBusquedaAvanzada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNombreBusqueda;
        private System.Windows.Forms.ComboBox cbCategoriaBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarcaBusqueda;
        private System.Windows.Forms.TextBox txtBoxIdBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBusquedaAvanzada;
        private System.Windows.Forms.PictureBox pbBusquedaAvanzada;
    }
}