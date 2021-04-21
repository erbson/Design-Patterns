using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {

                return MaximaTaxacao(orcamento);

            }
            else
            {


                return MinimaTaxacao(orcamento);


            }

        }

        public abstract double MinimaTaxacao(Orcamento orcamento);
       

        public abstract double MaximaTaxacao(Orcamento orcamento);
        

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
       
    }
}
