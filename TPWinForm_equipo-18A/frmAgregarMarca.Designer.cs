namespace TPWinForm_equipo_18A
{
    partial class frmAgregarMarca
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
            this.lbAgregarMarca = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtbAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAgregarMarca
            // 
            this.lbAgregarMarca.AutoSize = true;
            this.lbAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgregarMarca.Location = new System.Drawing.Point(128, 9);
            this.lbAgregarMarca.Name = "lbAgregarMarca";
            this.lbAgregarMarca.Size = new System.Drawing.Size(167, 25);
            this.lbAgregarMarca.TabIndex = 3;
            this.lbAgregarMarca.Text = "Agregar Marca";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(23, 105);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(186, 13);
            this.lbMarca.TabIndex = 4;
            this.lbMarca.Text = "Indique el nombre de la nueva Marca:";
            // 
            // txtbAgregarMarca
            // 
            this.txtbAgregarMarca.Location = new System.Drawing.Point(224, 102);
            this.txtbAgregarMarca.Name = "txtbAgregarMarca";
            this.txtbAgregarMarca.Size = new System.Drawing.Size(201, 20);
            this.txtbAgregarMarca.TabIndex = 5;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(92, 173);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 6;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(263, 173);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 7;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 270);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.txtbAgregarMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbAgregarMarca);
            this.Name = "frmAgregarMarca";
            this.Text = "Agregar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAgregarMarca;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtbAgregarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
    }
}