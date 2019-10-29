using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDShopLib
{
    public class ListaVentas
    {
        
        private static ListaVentas mListaVentas = new ListaVentas();
        private List<Venta> ListaVenta;

        public ListaVentas()
        {
            ListaVenta = new List<Venta>();
        }

        public static ListaVentas GetListaVentas()
        {
            return mListaVentas;
        }

        public List<Venta> geetListaVentas()
        {
            return ListaVenta;
        }
      

    }
}
