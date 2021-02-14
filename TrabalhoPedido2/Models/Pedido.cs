using System.Collections.Generic;

namespace TrabalhoPedido2.Models
{
    public class Pedido
    {
        private List<ItemPedido> lista = new List<ItemPedido>();

        public void Incluir(ItemPedido item){
            lista.Add(item);
        }

        public List<ItemPedido> Listar(){
            return lista;
        }
        public double Total(){
            double t = 0;

            foreach (ItemPedido i in lista){
                t = t + (i.Valor_Unitario*i.Quantidade);
            }
            return t;
        }
    }
}