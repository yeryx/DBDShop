using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDShopLib
{
    public class Distribuidor

    {
        public string CIF;
        public string nombre;
        public string direccion;
        public int numTlf ;
        public string email;

        public string getCIF()
        {
            return CIF;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string getDireccion()
        {
            return direccion;
        }

        public int getNumTlf()
        {
            return numTlf;
        }

        public string getEmail()
        {
            return email;
        }
      


    }