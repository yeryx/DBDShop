using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDShopLib
{
    class Class1
    {

            Client m_cliente;

            public void reducirStock(int idObjeto,string idVendedor, int cantidad)
        {
                List<ProductoDistribuidor> lista = m_cliente.GetProductosDistribuidores();
                
                for(int i=0; i < lista.Count; i++)
            {
                if(lista[i].idDistribuidor == idVendedor)
                {
                    if(lista[i].idProducto == idObjeto)
                    {

                        lista[i].numArticulos = (lista[i].numArticulos - cantidad);

                    }
                }

            }


        }

            public void crearVenta(string idVendedor,string idComprador, int idObjeto, int cantidad)
        {
            Venta ventita = new Venta();
            ventita.idComprador = idComprador;
            ventita.idVendedor = idVendedor;
            ventita.idproducto = idObjeto;
            ventita.cantidad = cantidad;

        }





    }
}
