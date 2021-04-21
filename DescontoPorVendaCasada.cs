using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public class DescontoPorVendaCasada : IDesconto

    {

        public IDesconto Proximo { get; set; }
      

        public double Desconta(Orcamento orcamento)
        {

            if (aconteceuVendaCasadaEm(orcamento)) return orcamento.valor * 0.05;
            else return Proximo.Desconta(orcamento);
        }

        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return existe("CANETA", orcamento) && existe("LAPIS", orcamento);
        }

        private bool existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem)) return true;
            }
            return false;
        }
    }
}
