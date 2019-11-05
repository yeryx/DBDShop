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
            listadistribuidores = cl.GetPedido();

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


            foreach (Distribuidor distribuidor in listadistribuidores)
            {
                CIF = distribuidor.CIF;
                nombre = distribuidor.nombre;
                direccion = distribuidor.direccion;
                numTlf = distribuidor.numTlf;
                email = distribuidor.email;
            }

        }


    }
}
