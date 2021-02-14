using System;
using System.Collections.Generic;
using ItemPedido;

namespace Pedido
{
    public class pedido
    {
       private List<item_pedido> lista= new List<item_pedido>();
        
        public void adicionar(item_pedido item)
        {
         lista.Add(item); 
        }
        public double totalizar()
        {    
            double total=0;
            for(int i=0; i < lista.Count; i++)
            {
                total=total+lista[i].valor_unitario*lista[i].quantidade;
            }
              return total;  
        }
    }
}