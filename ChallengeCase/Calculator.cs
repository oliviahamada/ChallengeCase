namespace ChallengeCase
{
    public class Calculator
    {
        public double CalculateCostTotal(double operationQuantity, double operationUnitCost)
        {
            return (operationQuantity * operationUnitCost);
        }

        public double CalculateWeightedAverage(double costTotal, double amountAssetsTotal, double operationQuantity, double operationUnitCost)
        {
            return (amountAssetsTotal <= 0) ? operationUnitCost : (costTotal / (operationQuantity + amountAssetsTotal));
        }

        public double DefaulTaxtValue(double profitPerSale, double weightedEstimatedProfit, double deductionValue)
        {
            return (profitPerSale-weightedEstimatedProfit-deductionValue);
        }
    }
}
