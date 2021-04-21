using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.55; 
        }
    }
}
