﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TestDatos
{
    public Client client;
    public List<Cliente> clientes = client.GetCliente();

    public void verClientes() {
        foreach (Cliente cliente in clientes) {
            string DNI=cliente.getDNI();
            string Nombre=cliente.getNombre();
            string Apellido=cliente.getApellido;

            Console.WriteLine(stuff);
        }
    }
}
