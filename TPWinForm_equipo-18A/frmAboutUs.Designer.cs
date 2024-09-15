namespace TPWinForm_equipo_18A
{
    partial class frmAboutUs
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
            this.lbAboutUs = new System.Windows.Forms.Label();
            this.lbMatias = new System.Windows.Forms.Label();
            this.lbHernan = new System.Windows.Forms.Label();
            this.lbBautista = new System.Windows.Forms.Label();
            this.lnkMatias = new System.Windows.Forms.LinkLabel();
            this.lnkHernan = new System.Windows.Forms.LinkLabel();
            this.lnkBautista = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbAboutUs
            // 
            this.lbAboutUs.AutoSize = true;
            this.lbAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAboutUs.Location = new System.Drawing.Point(137, 20);
            this.lbAboutUs.Name = "lbAboutUs";
            this.lbAboutUs.Size = new System.Drawing.Size(108, 25);
            this.lbAboutUs.TabIndex = 4;
            this.lbAboutUs.Text = "About Us";
            // 
            // lbMatias
            // 
            this.lbMatias.AutoSize = true;
            this.lbMatias.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatias.Location = new System.Drawing.Point(73, 100);
            this.lbMatias.Name = "lbMatias";
            this.lbMatias.Size = new System.Drawing.Size(95, 15);
            this.lbMatias.TabIndex = 5;
            this.lbMatias.Text = "Matias Fourcade:";
            // 
            // lbHernan
            // 
            this.lbHernan.AutoSize = true;
            this.lbHernan.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHernan.Location = new System.Drawing.Point(73, 134);
            this.lbHernan.Name = "lbHernan";
            this.lbHernan.Size = new System.Drawing.Size(90, 15);
            this.lbHernan.TabIndex = 6;
            this.lbHernan.Text = "Hernan Zanotto:";
            // 
            // lbBautista
            // 
            this.lbBautista.AutoSize = true;
            this.lbBautista.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBautista.Location = new System.Drawing.Point(60, 170);
            this.lbBautista.Name = "lbBautista";
            this.lbBautista.Size = new System.Drawing.Size(103, 15);
            this.lbBautista.TabIndex = 7;
            this.lbBautista.Text = "Bautista Cavallero:";
            // 
            // lnkMatias
            // 
            this.lnkMatias.AutoSize = true;
            this.lnkMatias.Location = new System.Drawing.Point(210, 101);
            this.lnkMatias.Name = "lnkMatias";
            this.lnkMatias.Size = new System.Drawing.Size(48, 13);
            this.lnkMatias.TabIndex = 9;
            this.lnkMatias.TabStop = true;
            this.lnkMatias.Text = "LinkedIn";
            this.lnkMatias.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMatias_LinkClicked);
            // 
            // lnkHernan
            // 
            this.lnkHernan.AutoSize = true;
            this.lnkHernan.Location = new System.Drawing.Point(210, 136);
            this.lnkHernan.Name = "lnkHernan";
            this.lnkHernan.Size = new System.Drawing.Size(48, 13);
            this.lnkHernan.TabIndex = 10;
            this.lnkHernan.TabStop = true;
            this.lnkHernan.Text = "LinkedIn";
            this.lnkHernan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHernan_LinkClicked);
            // 
            // lnkBautista
            // 
            this.lnkBautista.AutoSize = true;
            this.lnkBautista.Location = new System.Drawing.Point(210, 171);
            this.lnkBautista.Name = "lnkBautista";
            this.lnkBautista.Size = new System.Drawing.Size(48, 13);
            this.lnkBautista.TabIndex = 11;
            this.lnkBautista.TabStop = true;
            this.lnkBautista.Text = "LinkedIn";
            this.lnkBautista.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBautista_LinkClicked);
            // 
            // frmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 250);
            this.Controls.Add(this.lnkBautista);
            this.Controls.Add(this.lnkHernan);
            this.Controls.Add(this.lnkMatias);
            this.Controls.Add(this.lbBautista);
            this.Controls.Add(this.lbHernan);
            this.Controls.Add(this.lbMatias);
            this.Controls.Add(this.lbAboutUs);
            this.Name = "frmAboutUs";
            this.Text = "About us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAboutUs;
        private System.Windows.Forms.Label lbMatias;
        private System.Windows.Forms.Label lbHernan;
        private System.Windows.Forms.Label lbBautista;
        private System.Windows.Forms.LinkLabel lnkMatias;
        private System.Windows.Forms.LinkLabel lnkHernan;
        private System.Windows.Forms.LinkLabel lnkBautista;
    }
}