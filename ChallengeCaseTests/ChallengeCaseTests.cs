using ChallengeCase;

namespace ChallengeCaseTests
{

    public class ChallengeCaseTests
    {
        [Test]
        public void TestGetFileName()
        {
            string expected = Parameter.NEW_FOLDER_NAME;
            string directoryPath = "";
            FileManager fileManager = new FileManager(directoryPath, "");

            fileManager.GetFileName();
            
            var result = fileManager.GetFileName().ToString().Trim();
            Assert.That(result, Is.EqualTo(expected));
            
        }

        [Test]
        public void TestCalculateCostTotal()
        {
            Calculator calculator = new Calculator();
            double operationQuantity = 10;
            double operationUnitCost = 10;
            double expected = 100;

            var result = calculator.CalculateCostTotal(operationQuantity, operationUnitCost);
            Assert.That(result, Is.EqualTo(expected));
            
        }

        [Test]
        public void TestCalculateWeightedAverageZero()
        {
            Calculator calculator = new Calculator();
            double costTotal = 10;
            double amountAssetsTotal = 0;
            double operationQuantity = 0;
            double operationUnitCost = 10;
            double expected = 10;

            var result = calculator.CalculateWeightedAverage(costTotal, amountAssetsTotal, operationQuantity, operationUnitCost);
            Assert.That(result, Is.EqualTo(expected));
        }

        public void TestCalculateWeightedAverageAny()
        {
            Calculator calculator = new Calculator();
            double costTotal = 25;
            double amountAssetsTotal = 10;
            double operationQuantity = 3;
            double operationUnitCost = 2;
            double expected = 5;

            var result = calculator.CalculateWeightedAverage(costTotal, amountAssetsTotal, operationQuantity, operationUnitCost);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestDefaulTaxtValue()
        {
            Calculator calculator = new Calculator();
            double profitPerSale = 50;
            double weightedEstimatedProfit = 10;
            double deductionValue = 5;
            double expected = 35;

            var result = calculator.DefaulTaxtValue(profitPerSale, weightedEstimatedProfit, deductionValue);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}