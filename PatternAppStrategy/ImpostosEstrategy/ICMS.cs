namespace PatternAppStrategy.ImpostosEstrategy
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.1;
    }
}
