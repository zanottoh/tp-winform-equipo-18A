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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbAgregarMarca.Text))
                {
                    MessageBox.Show("Ingrese una Marca", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string cadena = txtbAgregarMarca.Text;

                foreach (char caracter in cadena)
                {
                    if (char.IsNumber(caracter))
                    {
                        MessageBox.Show("Coloque solo letras", "Solo letras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                AccesoDatos datos = new AccesoDatos();

                string consulta = "INSERT INTO MARCAS (Descripcion) VALUES ('" + txtbAgregarMarca.Text + "')";

                datos.setearConsulta(consulta);
                datos.ejecutarAccion();

                MessageBox.Show("¡Marca Agregada Exitosamente!");
                this.Close();

            }
            catch (FormatException)
            {

            }
        }
    }
}
