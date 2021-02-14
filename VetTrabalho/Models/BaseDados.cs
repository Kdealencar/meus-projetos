using System.Collections.Generic;

namespace VetTrabalho.Models
{
    public static class BaseDados
    {
        private static List<Cliente> lista = new List<Cliente>();

        public static void Incluir(Cliente cadastro)
        {
            lista.Add(cadastro);
        }

        public static List<Cliente> Listar()
        {
            return lista;
        }
    }
}