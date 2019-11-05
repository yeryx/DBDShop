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
            foreach (Cliente cliente in listaClientes) {
                dni = cliente.DNI;
                nombre = cliente.Nombre;
                apellidos = cliente.Apellidos;

                Console.WriteLine("DNI: " + dni + " Nombre: " + nombre + " Apellidos: " + apellidos);
            }


        }

          
            
        
     
    }   
}
