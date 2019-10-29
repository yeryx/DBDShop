using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDShopLib
{
    public class Product
    {
        public int Id = 0;
        public string Name = null;


        //no estoy seguro de hacer esto aqui o crear una clase donde relacionarlo si hubiese distribuidores se haria ahi
        public Double precio = 0.00;
        public int stock = 0;


        public int getId()
        {
            return Id;
        }
        public string getName()
        {
            return Name;
        }

        public Double getPrecio()
        {
            return precio;
        }

        public int getStock()
        {
            return stock;
        }

        public void setStock(int s)
        {
            stock = s;
        }
    }
}
