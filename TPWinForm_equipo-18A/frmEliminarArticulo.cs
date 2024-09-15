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
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm_equipo_18A
{
    public partial class frmEliminarArticulo : Form
    {
        private Articulo articulo = null;
        private Imagen imagen = null;
        public frmEliminarArticulo(Articulo articulo, Imagen imagen)
        {
            InitializeComponent();
            this.articulo= articulo;
            this.imagen = imagen;
            Marca marca = articulo.Marca;
            Categoria categoria = articulo.Categoria;
            Imagen imagen1 = imagen;

            lbCodigo.Text = articulo.Codigo;
            lbNombre.Text = articulo.Nombre;
            lbMarca.Text = marca.ToString();
            lbCategoria.Text = categoria.ToString();
            lbPrecio.Text = articulo.Precio.ToString();
            rtbDescripcion.Text = articulo.Descripcion;
            
            if (!(imagen == null))
            {
                cargarImagen(imagen.ToString());
            }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://upload.wikimedia.org/wikipedia/commons/a/a3/Image-not-found.png");
            }
        }

        private void btnEliminarFisica_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                DialogResult retorno = MessageBox.Show("¿Esta seguro que quiere eliminar este articulo? Está realizando una baja física, por lo que se borrará el Articulo en su totalidad.", "Eliminación de Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (retorno == DialogResult.Yes)
                {
                    negocio.eliminar(articulo.IdArticulo);
                    MessageBox.Show("El articulo fue eliminado correctamente!");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
