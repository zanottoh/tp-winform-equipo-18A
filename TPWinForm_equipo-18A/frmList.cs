using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace TPWinForm_equipo_18A
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }


        public void FiltrarArticulosPorCategoria(int categoriaId)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                // Obtener los artículos filtrados por categoría
                List<Articulo> listaFiltrada = negocio.listarPorCategoria(categoriaId);

                // Actualizar el DataGridView con los artículos filtrados
                dgbListar.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      
        

        private void frmList_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {



      



                /// Cargar las categorías en el ComboBox
                cbCategoriaList.DataSource = categoriaNegocio.listar();
                cbCategoriaList.DisplayMember = "descripcion"; // El campo que se mostrará
                cbCategoriaList.ValueMember = "id"; // El campo que se utilizará como valor (id)

                // Seleccionar la primera categoría por defecto
                if (cbCategoriaList.Items.Count > 0)
                {
                    cbCategoriaList.SelectedIndex = 0; // Seleccionar el primer ítem

                    // Obtener la categoria..
                    Categoria categoriaSeleccionada = (Categoria)cbCategoriaList.SelectedItem;

                    // Llamar al método que filtra los artículos por categoría
                    List<Articulo> listaArticulos = articuloNegocio.listarPorCategoria(categoriaSeleccionada.id);

                    // Actualizar el DataGridView con los artículos filtrados
                    dgbListar.DataSource = listaArticulos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbEleccionArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la categoría seleccionada
            Categoria categoriaSeleccionada = (Categoria)cbCategoriaList.SelectedItem;

            // Llamar al método que filtra los artículos por categoría
            FiltrarArticulosPorCategoria(categoriaSeleccionada.id);
        }
    }
}
