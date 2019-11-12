using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DBDShopLib;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class DBDShopTests
    {


        /* [TestMethod]
         public void AddAndTestData()
         {
             //Connect to the test database
             Client client = new Client("NLphb4HrH0", "NLphb4HrH0", "VM8GYV3qZ7");
             //Get all the existing products
             List<Product> products = client.GetProducts();
             //Delete all the products
             client.DeleteProducts(products);
             //Check we deleted all the products
             products = client.GetProducts();
             Assert.IsTrue(products.Count == 0);

             //Insert test data
             client.InsertTestData();
             //Check they were correctly inserted
             products = client.GetProducts();
             Assert.IsTrue(products.Count == 2);
         }
         */
        [TestMethod]
        public void TestClientes()
        {
            Client cl = new Client();
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = cl.GetCliente();

            string dni = null;
            string nombre = null;
            string apellidos = null;
            foreach (Cliente cliente in listaClientes)
            {
                dni = cliente.DNI;
                nombre = cliente.Nombre;
                apellidos = cliente.Apellidos;

                Console.WriteLine("DNI: " + dni + " Nombre: " + nombre + " Apellidos: " + apellidos);
            }
        }

             [TestMethod]
        public void TestProductos()
        {
            Client cl = new Client();
            List<Product> listaProductos = new List<Product>();
            listaProductos = cl.GetProducts();

            int idProducto = 0;
            string descripcion = null;
            float precio = 0.0f;
            foreach (Product producto in listaProductos)
            {
                idProducto = producto.idProducto;
                descripcion = producto.descripcion;
                precio = producto.precio;
            }

        }

        [TestMethod]
        public void TestProductoDistribuidor()
        {
            Client cl = new Client();
            List<ProductoDistribuidor> listadistribuidores = new List<ProductoDistribuidor>();
            listadistribuidores = cl.GetProductoDistribuidores();

            int idProducto = 0;
            string idDistribuidor = null;
            int numArticulos = 0;

            foreach (ProductoDistribuidor prodDist in listadistribuidores)
            {
                idProducto = prodDist.idProducto;
                idDistribuidor = prodDist.idDistribuidor;
                numArticulos = prodDist.numArticulos;
            }

        }

        [TestMethod]
        public void TestDistribuidor()
         {
            Client cl = new Client();
            List<Distribuidor> listadistribuidores = new List<Distribuidor>();
            listadistribuidores = cl.GetDistribuidores();

            string CIF = null;
            string nombre = null;
            string direccion = null;
            int numTlf = 0;
            string email = null;

            foreach (Distribuidor distribuidor in listadistribuidores)
            {
                CIF = distribuidor.CIF;
                nombre = distribuidor.nombre;
                direccion = distribuidor.direccion;
                numTlf = distribuidor.numTlf;
                email = distribuidor.email;
            }

        }

        [TestMethod]
        public void TestPedido()
        {
            Client cl = new Client();
            List<Pedido> listaPedidos = new List<Pedido>();
            listaPedidos = cl.getPedido();

            int idPedido = 0;
            DateTime fecha;
            string idCliente = null;


            foreach (Pedido pedido in listaPedidos)
            {
                idPedido = pedido.idPedido;
                fecha = pedido.fecha;
                idCliente = pedido.idCliente;
            }

        }

        [TestMethod]
        public void TestProductoPedido()
        {
            Client cl = new Client();
            List<ProductoPedido> listaProductosDelPedido = new List<ProductoPedido>();
            listaProductosDelPedido = cl.getProductoPedido();

            int idPedido = 0;
            int idProducto = 0;
            int cantidad = 0;
            string idDistribuidor = null;


            foreach ( ProductoPedido prodPedido in listaProductosDelPedido)
            {
                idProducto = prodPedido.idProducto;
                idPedido = prodPedido.pedido.idPedido;
                cantidad = prodPedido.cantidad;
                idDistribuidor = prodPedido.idDistribuidor;
            }

        }

        /***************************************************************************************************/


        [TestMethod]
        public void TestBorrarProductoDistribuidor()
        {
            Client cl = new Client();
            List<ProductoDistribuidor> listaProdDistribuidor = new List<ProductoDistribuidor>();
            listaProdDistribuidor = cl.GetProductoDistribuidores();

            cl.DeleteProductoDistribuidores(listaProdDistribuidor);

        }
        [TestMethod]
        public void TestBorrarProductoPedido()
        {
            Client cl = new Client();
            List<ProductoPedido> listaProdPedidos = new List<ProductoPedido>();
            listaProdPedidos = cl.getProductoPedido();

            cl.DeleteProductoPedido(listaProdPedidos);

        }
        [TestMethod]
        public void TestBorrarPedido()
        {
            Client cl = new Client();
            List<Pedido> listaPedidos = new List<Pedido>();
            listaPedidos = cl.getPedido();

            cl.DeletePedido(listaPedidos);

        }

        [TestMethod]
        public void TestBorrarDistribuidor()
        {
            Client cl = new Client();
            List<Distribuidor> listaDistribuidores = new List<Distribuidor>();
            listaDistribuidores = cl.GetDistribuidores();

            cl.DeleteDistribuidores(listaDistribuidores);

        }

        [TestMethod]
        public void TestBorrarCliente()
        {
            Client cl = new Client();
            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = cl.GetCliente();

            cl.DeleteClientes(listaClientes);

        }




        [TestMethod]
        public void TestBorrarProducto()
        {
            Client cl = new Client();
            List<Product> listaPedidos = new List<Product>();
            listaPedidos = cl.GetProducts();

            cl.DeleteProducts(listaPedidos);


          
        }


    }
}
