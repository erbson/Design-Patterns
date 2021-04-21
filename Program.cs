using System;

namespace Padrao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();
            //Imposto novoImposto = new ICCC();
            //Orcamento orcamento = new Orcamento(1500.00);

            //CalculadorDeImposto calcula = new CalculadorDeImposto();
            //calcula.RealizarCalculo(orcamento, iss);
            //calcula.RealizarCalculo(orcamento, icms);
            //calcula.RealizarCalculo(orcamento, novoImposto);

            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();


            //orcamento.AdicionaItem(new Item("CANETA", 250.0));
            //orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            //orcamento.AdicionaItem(new Item("BORRACHA", 250.0));
            //orcamento.AdicionaItem(new Item("APONTADOR", 250.0));

            //orcamento.AdicionaItem(new Item("GIZ", 250.0));
            //orcamento.AdicionaItem(new Item("CADERNO", 250.0));



            //double desconto = calculador.Calcula(orcamento);



            //Console.WriteLine(desconto);







            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            Orcamento orcamento = new Orcamento(500.0);

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);


            //Console.WriteLine("Hello World!");
            Console.ReadKey();



        }
    }
}
