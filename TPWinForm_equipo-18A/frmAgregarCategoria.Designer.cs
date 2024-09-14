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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAgregarCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indique el nombre de la nueva Categoría:";
            // 
            // txtbAgregarCategoria
            // 
            this.txtbAgregarCategoria.Location = new System.Drawing.Point(208, 102);
            this.txtbAgregarCategoria.Name = "txtbAgregarCategoria";
            this.txtbAgregarCategoria.Size = new System.Drawing.Size(201, 20);
            this.txtbAgregarCategoria.TabIndex = 1;
            this.txtbAgregarCategoria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Agregar Categoría";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(63, 189);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 3;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(334, 189);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbAgregarCategoria);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarCategoria";
            this.Text = "frmAgregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbAgregarCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarCat;
    }
}