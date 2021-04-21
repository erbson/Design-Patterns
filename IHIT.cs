using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {

            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.getNome);
            }

            return false;



        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
