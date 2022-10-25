using System.Collections;
using rt.Models;

namespace rt.Services
{
    public class Servicios
    {
        public ArrayList generarClientes()
        {
            ArrayList clientes = new ArrayList();
            clientes.Add(new Cliente("11", "Juan", "juan@gmail.com"));
            clientes.Add(new Cliente("12", "Pedro", "pedro@gmail.com"));
            clientes.Add(new Cliente("13", "Maria", "maria@gmail.com"));
            clientes.Add(new Cliente("14", "Jose", "jose@gmail.com"));
            clientes.Add(new Cliente("15", "Luis", "luis@gmail.com"));
            clientes.Add(new Cliente("16", "Ana", "ana@gmail.com"));
            clientes.Add(new Cliente("17", "Luisa", "luisa@gmail.com"));
            clientes.Add(new Cliente("18", "Carlos", "carlos@gmail.com"));
            clientes.Add(new Cliente("19", "Antony", "antony@gmail.com"));
            return clientes;
        }
        public ArrayList generarEquifax()
        {
            ArrayList equifax = new ArrayList();
            equifax.Add(new Equifax("11", 190));
            equifax.Add(new Equifax("12", 200));
            equifax.Add(new Equifax("13", 190));
            equifax.Add(new Equifax("15", 210));
            equifax.Add(new Equifax("16", 199));
            equifax.Add(new Equifax("17", 201));
            equifax.Add(new Equifax("18", 150));
            return equifax;
        }
    }
}