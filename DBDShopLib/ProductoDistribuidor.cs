using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ProductoDistribuidor
{
    public int idProducto;
    public string idDistribuidor;
    public int numArticulos;
    public ProductiDistribuidor()
	{
    idProducto = 0;
    idDistribuidor = null;
    numArticulos = 0;
}

    public int getNumArticulos()
    {
        return numArticulos;
    }
}
