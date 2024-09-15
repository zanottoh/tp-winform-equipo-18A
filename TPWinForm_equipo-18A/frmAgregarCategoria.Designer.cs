namespace TPWinForm_equipo_18A
{
    partial class frmAgregarCategoria
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
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtbAgregarCategoria = new System.Windows.Forms.TextBox();
            this.lbAgregarCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(12, 105);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(203, 13);
            this.lbCategoria.TabIndex = 0;
            this.lbCategoria.Text = "Indique el nombre de la nueva Categoría:";
            // 
            // txtbAgregarCategoria
            // 
            this.txtbAgregarCategoria.Location = new System.Drawing.Point(224, 102);
            this.txtbAgregarCategoria.Name = "txtbAgregarCategoria";
            this.txtbAgregarCategoria.Size = new System.Drawing.Size(201, 20);
            this.txtbAgregarCategoria.TabIndex = 1;
            this.txtbAgregarCategoria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbAgregarCategoria
            // 
            this.lbAgregarCategoria.AutoSize = true;
            this.lbAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarCategoria.Location = new System.Drawing.Point(112, 9);
            this.lbAgregarCategoria.Name = "lbAgregarCategoria";
            this.lbAgregarCategoria.Size = new System.Drawing.Size(204, 25);
            this.lbAgregarCategoria.TabIndex = 2;
            this.lbAgregarCategoria.Text = "Agregar Categoría";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(92, 173);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(263, 173);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCat.TabIndex = 4;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // frmAgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 270);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lbAgregarCategoria);
            this.Controls.Add(this.txtbAgregarCategoria);
            this.Controls.Add(this.lbCategoria);
            this.Name = "frmAgregarCategoria";
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtbAgregarCategoria;
        private System.Windows.Forms.Label lbAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarCat;
    }
}