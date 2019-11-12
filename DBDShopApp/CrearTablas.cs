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
    public partial class CrearTablas : Form
    {
        public CrearTablas()
        {
            InitializeComponent();

            m_client = new Client("NLphb4HrH0", "NLphb4HrH0", "VM8GYV3qZ7");
            textBox1.Text = "Connected to database";
        }

        Client m_client;

        private void button2_Click(object sender, EventArgs e)
        {
            m_client.InsertTestData();
            textBox1.Text = "Test data inserted in the database";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Product> products = m_client.GetProducts();
            listBox1.Items.Clear();
            foreach (Product product in products)
            {
              // listBox1.Items.Add(product.Name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
