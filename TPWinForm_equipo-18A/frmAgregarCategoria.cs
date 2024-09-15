using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_18A
{
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbAgregarCategoria.Text))
                {
                    MessageBox.Show("Ingrese una categoría", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } 
                string cadena = txtbAgregarCategoria.Text;

                foreach (char caracter in cadena)
                {
                    if (char.IsNumber(caracter)) { 
                    MessageBox.Show("Coloque solo letras", "Solo letras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; }
                }

                AccesoDatos datos = new AccesoDatos();

                string consulta = "INSERT INTO CATEGORIAS (Descripcion) VALUES ('" + txtbAgregarCategoria.Text + "')";

                datos.setearConsulta(consulta);
                datos.ejecutarAccion();

                MessageBox.Show("¡Categoría Agregada Exitosamente!");
                this.Close();

            }
            catch (FormatException)
            {
                
            }
        }

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
