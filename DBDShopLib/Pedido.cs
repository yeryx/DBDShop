using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Pedido

{

    public int idpedido ;
    public DateTime fecha;
    public string idCliente ;

    public Pedido()
	{
        idpedido = 0;
       fecha = DateTime.Now;
       idCliente = 0;
	}
}
