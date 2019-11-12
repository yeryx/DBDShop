using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DBDShopLib
{
    public class Client
    {
        MySqlConnection m_connection = null;

        public Client(string databasename = "g7EnbLEqTh", string username = "g7EnbLEqTh", string password = "ix3rJtQ1jg", string server= "remotemysql.com")
        {
          
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

            string query = "SELECT idProducto ,descripcion ,precio FROM Products";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                int id= int.Parse(reader.GetValue(0).ToString());
                string descripcion = reader.GetValue(1).ToString();
                float precio = float.Parse(reader.GetValue(2).ToString());


                Product product = new Product();

                product.idProducto = id;
                product.descripcion = descripcion;
                product.precio= precio;
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

            string query ="SELECT DNI,Nombre,ApellidoS from Cliente ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                
                string DNI= reader.GetValue(0).ToString();
                string nombre = reader.GetValue(1).ToString();
                string apellido=reader.GetValue(2).ToString();

                Cliente cliente = new Cliente();

                cliente.DNI = DNI;
                cliente.Nombre = nombre;
                cliente.Apellidos =apellido;

                clientes.Add(cliente);
            }
            reader.Close();
            return clientes;
        }
         public void DeleteClientes(List<Cliente> clientes)
        {
            foreach(Cliente cliente in clientes)
            {
                string query = "DELETE FROM Cliente WHERE DNI =" + cliente.DNI + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }


         public List<Distribuidor> GetDistribuidores()
        {
            List<Distribuidor> vendedores = new List<Distribuidor>();

            string query ="SELECT CIF,nombre,direccion,numTlf,email from Distribuidor ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
            {
                
                string CIF= reader.GetValue(0).ToString();
                string nombre = reader.GetValue(1).ToString();
                string direccion=reader.GetValue(2).ToString();
                int numTlf=int.Parse(reader.GetValue(3).ToString());
                string email=reader.GetValue(4).ToString();

                Distribuidor vendedor = new Distribuidor();

                vendedor.CIF = CIF;
                vendedor.nombre = nombre;
                vendedor.direccion=direccion;
                vendedor.numTlf=numTlf;
                vendedor.email=email;

                vendedores.Add(vendedor);
            }
            reader.Close();
            return vendedores;
        }

         public void DeleteDistribuidores(List<Distribuidor> vendedores)
        {
            foreach(Distribuidor vendedor in vendedores)
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

                productoDistribuidor.idProducto = idProducto;
                productoDistribuidor.idDistribuidor = idDistribuidor;
                productoDistribuidor.numArticulos=numArticulos;
                
                productosDeLosDistribuidores.Add(productoDistribuidor);
            }
            reader.Close();
            return productosDeLosDistribuidores;
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

        
         public List<ProductoPedido> getProductoPedido()
        {
            List<ProductoPedido> productosPedido = new List<ProductoPedido>();

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
                productoPedido.cantidad=cantidad;
                productoPedido.idDistribuidor=idVendedor;

                Pedido pedido = new Pedido();
                pedido.idPedido = idPedido;

                productoPedido.pedido = pedido;

                productosPedido.Add(productoPedido);
            }
            reader.Close();
            return productosPedido;
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

        public List<Pedido> getPedido()
        {
            List<Pedido> pedidos = new List<Pedido>();

            string query = "SELECT idPedido,fecha,idCliente from Pedido ";
            MySqlCommand cmd = new MySqlCommand(query, m_connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int idPedido = int.Parse(reader.GetValue(0).ToString());
                DateTime fecha = DateTime.Parse(reader.GetValue(1).ToString());
                string idCliente = reader.GetValue(2).ToString();

                Pedido pedido = new Pedido();

                pedido.idPedido = idPedido;
                pedido.fecha = fecha;
                pedido.idCliente = idCliente;

                pedidos.Add(pedido);
            }
            reader.Close();
            return pedidos;
        }

        public void DeletePedido(List<ProductoPedido> productoPedidos)
        {
            foreach (ProductoPedido producto in productoPedidos)
            {
                string query = "DELETE FROM ProductoDistribuidor WHERE CIF =" + producto.idProducto + ";";
                MySqlCommand cmd = new MySqlCommand(query, m_connection);
                cmd.ExecuteNonQuery();

            }
        }

    }
}
