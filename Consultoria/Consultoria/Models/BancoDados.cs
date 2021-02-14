using System.Collections.Generic;

namespace Consultoria.Models
{
    public static class BaseDados
    {
        private static List<Cliente> lista = new List<Cliente>();

        public static void Incluir(Cliente cadastro)
        {
            lista.Add(cadastro);
        }
 
}
}