using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
   public  class ICPP : TemplateDeImpostoCondicional
    {


        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor >= 500;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.07;
        }
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.05;
        }
    }
}
