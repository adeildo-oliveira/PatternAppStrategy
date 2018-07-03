using System;

namespace PatternAppStrategy.ImpostosEstrategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculoDoImposto(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
