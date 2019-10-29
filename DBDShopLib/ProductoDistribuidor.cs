using System;

public class ProductoDistribuidor
{
    public int idProducto;
    public string idDistribuidor;
    public int numArticulos;
    public ProductoDistribuidor()
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
