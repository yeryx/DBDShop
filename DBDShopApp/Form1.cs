using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBDShopLib;


namespace DBDShopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Client m_client;
        Class1 class1;
        
        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> lista = new List<Product>();
            List<ProductoDistribuidor> distri = new List<ProductoDistribuidor>();
            string nombre = textBox1.Text;
            string comprador = textBox4.Text;
            string distribuidor = textBox3.Text;
            int compra = Convert.ToInt16(textBox2.Text);
            
            lista = m_client.GetProducts();
            distri = m_client.GetProductoDistribuidores();

            for (var i = 0; i < lista.Count; i++)
            {
                if (lista[i].descripcion.Equals(nombre))
                {
                    for (var j = 0; j < distri.Count; j++) {

                        if (distri[j].idProducto == lista[i].idProducto && distri[j].idDistribuidor == distribuidor)
                        {
                            if (distri[j].numArticulos > compra)
                            {

                                class1.reducirStock(lista[i].idProducto, distribuidor, compra);

                                ProductoPedido venta = new ProductoPedido();

                                venta = class1.crearVenta(distribuidor, comprador, lista[i].idProducto, compra);

                                class1.insertventa(venta);
                                

                            }
                        }
                    }
                    }
                    else
                    {
                        
                    }
                    i = lista.Count;
                }
            }

    }
    }

