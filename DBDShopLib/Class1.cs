using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DBDShopLib
{
    class Class1
    {

            Client m_cliente;

            public void reducirStock(int idObjeto,string idVendedor, int cantidad)
        {
                List<ProductoDistribuidor> lista = m_cliente.GetProductoDistribuidores();
                
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
            ProductoPedido ventita = new ProductoPedido();
            
            ventita.idVendedor = idVendedor;
            ventita.idProducto = idObjeto;
            ventita.cantidad = cantidad;
            

            Pedido pedidito = new Pedido();
            pedidito.idpedido = 1;
            pedidito.idCliente = idComprador;

            ventita.pedido = pedidito;

        }

       
          public void insertventa(ProductoPedido venta)
        {
            MySqlConnection connection = new MySqlConnection("datasource=remotemysql.com;port=3306;username=g7EnbLEqTH;password=ix3rJtQ1jg");

            string insertar = ("Insert into Venta");




        }



    }
}
