using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
   public  interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
