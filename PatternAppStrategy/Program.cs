using PatternAppStrategy.ImpostosEstrategy;
using System;

namespace PatternAppStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var orcamento = new Orcamento(3000.0);
            var calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculoDoImposto(orcamento, new ISS());
            calculador.RealizaCalculoDoImposto(orcamento, new ICMS());
            calculador.RealizaCalculoDoImposto(orcamento, new ICCC());

            Console.ReadKey();
        }
    }
}
