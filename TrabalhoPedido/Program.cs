using System;
using ItemPedido;
using Pedido;
using System.Collections.Generic;


namespace Pedido
{
    class Program 
    {
        static void Main(string[] args)
        {
            pedido lista = new pedido();
            string opcao = "s";
           do{
               item_pedido item = new item_pedido();

              Console.WriteLine("Informe o produto:");
              item.descricao = Console.ReadLine();

              Console.WriteLine("Informe a quantidade desejada:");
              item.quantidade = int.Parse(Console.ReadLine());

              Console.WriteLine("Informe o valor do produto:");
              item.valor_unitario = double.Parse(Console.ReadLine());
               
              lista.adicionar(item);

              Console.WriteLine("Deseja adicionar outro produto? (s/n)");
              opcao = Console.ReadLine();

              if (opcao == "n")
               {
                 Console.WriteLine("total do pedido: "+lista.totalizar());
               }

              
           }while(opcao == "s");
        }
    }
}
