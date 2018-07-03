namespace PatternAppStrategy.ImpostosEstrategy
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06;
    }
}
