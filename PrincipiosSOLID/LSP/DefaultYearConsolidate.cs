namespace PrincipiosSOLID.LSP
{
    public class DefaultYearConsolidate
    {
        private readonly SimpleAverageGradeCalculator _calculator;

        public DefaultYearConsolidate(SimpleAverageGradeCalculator simpleAverageGradeCalculator)
        {
            this._calculator = simpleAverageGradeCalculator;
        }

        public void Consolidate()
        {
            _calculator.Calculate(new int[] { 1, 2, 3, 4 });
        }
    }

    public class SchoolService
    {
        public void ConsolidateClass()
        {
            // Mediante a herança errada, eu posso criar uma instância de WeightAverageGradeCalculator sem erros de compilação, entretanto, resultará em um calculo errado
                // var averageGradeCalculator = new WeightAverageGradeCalculator("Portuges", 2023, 1);
                // var defaultConsolidateService = new DefaultYearConsolidate(averageGradeCalculator);

            var averageGradeCalculator = new SimpleAverageGradeCalculator("Portuges", 2023, 1);
            var defaultConsolidateService = new DefaultYearConsolidate(averageGradeCalculator);

            defaultConsolidateService.Consolidate();
        }
    }
}
