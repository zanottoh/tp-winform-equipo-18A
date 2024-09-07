using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_18A
{
    internal class Articulo
    {
        public string Nombre{ get; set; }
        public string Descripcion { get; set; }
        public Marca Marca{ get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio{ get; set; }
    }
}
