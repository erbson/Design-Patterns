using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
   public  class DescontoPorCincoItens : IDesconto
    {

        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.valor * 0.1;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }



    }
}
