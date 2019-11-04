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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> lista = new List<Product>();
            string nombre = textBox1.Text;
            int compra = Convert.ToInt16(textBox2.Text);
            /*
            lista = m_client.GetProducts();
            for (var i = 0; i < lista.Count; i++)
            {
                if (lista[i].Name.Equals(nombre))
                {
                    if (lista[i]. > compra)
                    {
                        int nuevostock = lista[i].stock - compra;
                        lista[i].setStock(nuevostock);


                        Venta venta = new Venta();
                        venta.idproducto = lista[i].Id;
                        venta.cantidad = compra;
                        venta.idComprador = Convert.ToInt16(textBox3.Text);
                        venta.idVendedor = Convert.ToInt16(textBox4.Text);

                        
                    }
                    else
                    {
                        
                    }
                    i = lista.Count;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        */
        }
    }
}
