﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Padrao
{
    public class CalculadorDeImposto
    {

        public void RealizarCalculo(Orcamento orcamento,Imposto imposto)
        {

            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);

        }
    }
}
