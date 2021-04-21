using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public class ISS : Imposto
    {
        double Imposto.Calcula(Orcamento orcamento)
        {
            return orcamento.valor * 0.10;
        }
    }
}
