using System.Collections.Generic;
using System;

namespace atividade02.Models
{
    public class Pedido
    {
        private List<ItemPedido> itemPedidos;

        public Pedido(){
            itemPedidos = new List<ItemPedido>();
        } // construtor da classe

        public void Inserir(ItemPedido pedido)
        {
                itemPedidos.Add(pedido);
        }

        public List<ItemPedido> Listar()
        {
            return itemPedidos;
        }
                public double TotalPedido()
        {
            double TotalPedido = 0;
            foreach (var item in itemPedidos)
            {
                TotalPedido = TotalPedido + (item.Quantidade * item.Valor);
            }

            return TotalPedido;
        }
    }
}