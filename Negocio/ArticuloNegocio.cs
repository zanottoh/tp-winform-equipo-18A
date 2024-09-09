using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				//datos.setearConsulta();
				datos.ejecutarLectura();


			
				return lista;
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }

		public void agregar(Articulo nuevo)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("Insert into ARTICULOS VALUES('"+nuevo.Codigo+"', '"+nuevo.Nombre+"', '"+nuevo.Descripcion+"',"+nuevo.Marca.IdMarca+" ,"+nuevo.Categoria.id+","+nuevo.Precio+")");
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}
    }
}
