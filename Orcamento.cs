using System.Collections.Generic;

namespace Padrao
{
    public class Orcamento
    {

        public double valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public  Orcamento(double valor)
        {

            this.valor = valor;
            this.Itens = new List<Item>();

        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}