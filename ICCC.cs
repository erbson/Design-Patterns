using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
   public  class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
           if(orcamento.valor < 1000)
            {
                return orcamento.valor * 0.5;

            }
            if (orcamento.valor >= 1000  || orcamento.valor >= 3000 )
            {
                return orcamento.valor * 07;

            }

          
                return (orcamento.valor * 07 ) + 30;
         




        }
    }
}
