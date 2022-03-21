using System;
using System.Collections.Generic;
using System.Linq;

namespace atividade02.Models
{
    public static class Dados{

   public static Pedido PedidoAtual { get; set;}

    static Dados()

   {

       PedidoAtual = new Pedido();

   }

}
}