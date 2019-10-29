using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DBDShopLib
{
    public class Client
    {
        MySqlConnection m_connection = null;

        public Client(string databasename, string username, string password, string server= "remotemysql.com")
        {
            databasename = "g7EnbLEqTh";
            username = "g7EnbLEqTh";
            password = "ix3rJtQ1jg";
          
            m_connection = new MySqlConnection();
            m_connection.ConnectionString =
            "Server=" + server + ";" +
            "database=" + databasename + ";" +
            "UID=" + username + ";" +
            "password=" + password + ";";
            m_connection.Open();
        }


        public void InsertTestData()
        {
            string query = "CREATE TABLE IF NOT EXISTS Products (Id int,Name TEXT)";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            cmd.ExecuteNonQuery();
            query = "INSERT INTO Products VALUES(1,'Nocilla');";
            cmd = new MySqlCommand(query, m_connection);
            cmd.ExecuteNonQuery();
            query = "INSERT INTO Products VALUES(2,'Patata');";
            cmd = new MySqlCommand(query, m_connection);
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            string query = "SELECT idPedido,descripcion, precio FROM Products";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                int id= int.Parse(reader.GetValue(0).ToString());
                string name = reader.GetValue(1).ToString();

                Product product = new Product();

                product.idProducto = id;
                product.descripcion = descripcion;
                producto.precio=precio;
                products.Add(product);
            }
            reader.Close();
            return products;
        }

        public void DeleteProducts(List<Product> products)
        {
            foreach(Product product in products)
            {
                string query = "DELETE FROM Products WHERE idProducto =" + product.idProducto + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }

        public List<Cliente> GetCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            string query ="SELECT DNI,nombre,apellido from Cliente ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                
                string DNI= reader.GetValue(0).ToString();
                string nombre = reader.GetValue(1).ToString();
                string apellido=reader.GetValue(2).ToString();

                Cliente cliente = new Cliente();

                product.DNI = DNI;
                product.nombre = nombre;
                producto.apellido=apellido;
                products.Add(cliente);
            }
            reader.Close();
            return products;
        }
         public void DeleteProducts(List<Cliente> clientes)
        {
            foreach(Cliente cliente in clientes)
            {
                string query = "DELETE FROM Cliente WHERE DNI =" + cliente.DNI + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }


         public List<Distribuidor> GetVendedores()
        {
            List<Distribuidor> vendedores = new List<Distribuidor>();

            string query ="SELECT CIF,nombre,direccion,numTlf,email from Distribuidor ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                
                string CIF= ireader.GetValue(0).ToString();
                string nombre = reader.GetValue(1).ToString();
                string direccion=reader.GetValue(2).ToString();
                string numTlf=reader.GetValue(3).ToString();
                string email=reader.GetValue(4).ToStrinf();

                Distribuidor vendedor = new Distribuidor();

                vendedor.CIF = CIF;
                vendedor.nombre = nombre;
                vendedor.direccion=direccion;
                vendedor.numTlf=numTlf;
                vendedor.email=email;

                products.Add(vendedor);
            }
            reader.Close();
            return products;
        }

         public void DeleteProducts(List<Vendedor> vendedores)
        {
            foreach(Vendedor vendedor in vendedores)
            {
                string query = "DELETE FROM Vendedor WHERE CIF =" + vendedor.CIF + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }

         public List<ProductoDistribuidor> GetProductoDistribuidores()
        {
            List<ProductoDistribuidor> productosDeLosDistribuidores = new List<ProductoDistribuidor>();

            string query ="SELECT idProducto,idDistribuidor,numArticulos from ProductoDistribuidor ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                
                int idProducto= int.Parse(reader.GetValue(0).ToString());
                string  idDistribuidor = reader.GetValue(1).ToString();
                int numArticulos= int.Parse(reader.GetValue(2).ToString());

                ProductoDistribuidor productoDistribuidor = new ProductoDistribuidor();

                productoDistribuidor.idProducto = CIF;
                productoDistribuidor.idDistribuidor = nombre;
                productoDistribuidor.numArticulos=direccion;
                
                products.Add(productoDistribuidor);
            }
            reader.Close();
            return products;
        }

         public void DeleteProducts(List<ProductoDistribuidor> productosDeLosDistribuidores)
        {
            foreach(ProductoDistribuidor producto in productosDeLosDistribuidores)
            {
                string query = "DELETE FROM ProductoDistribuidor WHERE CIF =" + producto.idProducto + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }

        
         public List<ProductoDistribuidor> GetProductoDistribuidores()
        {
            List<ProductoDistribuidor> productosDeLosDistribuidores = new List<ProductoDistribuidor>();

            string query ="SELECT idProducto,idPedido,cantidad,idVendedor from ProductoPedido ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
             
                int idProducto= int.Parse(reader.GetValue(0).ToString());
                int  idPedido =  int.Parse(reader.GetValue(1).ToString());
                int cantidad= int.Parse(reader.GetValue(3).ToString());
                string idVendedor= reader.GetValue(4).ToString();

                ProductoPedido productoPedido = new ProductoPedido();

                productoPedido.idProducto = idProducto;
                productoPedido.idPedido = idPedido;
                productoPedido.cantidad=cantidad;
                productoPedido.idVendedor=idVendedor;

                products.Add(productoPedido);
            }
            reader.Close();
            return products;
        }

         public void DeleteProducts(List<ProductoPedido> productoPedidos)
        {
            foreach(ProductoPedido producto in productoPedidos)
            {
                string query = "DELETE FROM ProductoDistribuidor WHERE CIF =" + producto.idProducto + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }

    }
}
