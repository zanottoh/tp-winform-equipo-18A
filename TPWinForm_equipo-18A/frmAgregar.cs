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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            try
            {
                Articulo artNuevo = new Articulo();
                string marca, categoria;
                Imagen imagenArticuloNuevo = new Imagen();

                artNuevo.Nombre = tbNombre.Text;
                artNuevo.Precio = decimal.Parse(tbPrecio.Text);
                artNuevo.Descripcion = tbDescripcion.Text;

                marca = cmbMarca.Text;
                categoria = cmbCategoria.Text;

                artNuevo.Nombre = tbNombre.Text;
                artNuevo.Precio = decimal.Parse(tbPrecio.Text);
                artNuevo.Descripcion = tbDescripcion.Text;

                marca = cmbMarca.Text;
                categoria = cmbCategoria.Text;

                /*
                traer marcas marcas y categorias de db, para comparar y
                agregar correspondiente
                */


                // Agregar imagen


                // escritura del articulo en la db
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
