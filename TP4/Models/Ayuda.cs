namespace TP4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

class Ayuda
{
    public Ayuda()
    {
        
    }

    public List<Cadete> Contenido()
    {
        List<Cadete> ListadoCadetes = new List<Cadete>();
        List<Cliente> ListadoClientesN = new List<Cliente>();
        List<Pedido> ListadoPedidosN = new List<Pedido>();
        string[] lineas = File.ReadAllLines(@"C:\Taller2\tl2-tp4-2022-Tahiel24\TP4\CSV\Cadetes.csv");
        List<string> contenido = new List<string>();

        foreach (var i in lineas)
        {
            string[] fila = i.Split(",");
            int num = Convert.ToInt32(fila[0]);
            Cadete nuevoCadete = new Cadete(num, fila[1], fila[2], fila[3]);
            ListadoCadetes.Add(nuevoCadete);
        }

        return ListadoCadetes;
    }

    
}

