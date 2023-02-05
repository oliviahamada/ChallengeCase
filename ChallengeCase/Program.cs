using System.Text.Json;
using System;
using ChallengeCase.Model;
using ChallengeCase;
using System.IO;
using System.Collections.Generic;
using System.Text.Json.Nodes;

Console.WriteLine("Insira um diretório válido:");
var directoryPath = @"" + Console.ReadLine();

if (!Directory.Exists(directoryPath))
{
    Console.WriteLine("Diretório '{0}' inválido.", directoryPath);
}

if (Directory.Exists(directoryPath))
{
    DirectoryInfo pathDirectory = new DirectoryInfo(directoryPath);
    FileInfo[] readAllDirectoryFiles = pathDirectory.GetFiles();

    foreach(var file in readAllDirectoryFiles)
    {
        FileManager fileManager = new FileManager(directoryPath, file.Name);
        JsonArray jsonResults = new JsonArray();

        string readTextJson = File.ReadAllText(@""+file);
        object[] rowsFile = JsonSerializer.Deserialize<object[]>(readTextJson);

        // Percorre lista de operações 
        foreach (object row in rowsFile)
        {
            List<Result> resultsReturnJson = new List<Result>();
            Calculator calculator = new Calculator();

            Operation[] operations = JsonSerializer.Deserialize<Operation[]>(row.ToString());

            double newWeightedAverage = 0.00;
            double amountAssetsTotal = 0.00;

            double costTotal = 0.00;
            double deductionValue = 0.00;

            // Percorre cada lista de operação
            foreach (Operation operation in operations)
            {

                Result result = new Result();

                // Operação de compra
                if (operation.operationType == Parameter.BUY)
                {
                    costTotal += calculator.CalculateCostTotal(operation.operationQuantity, operation.operationUnitCost);

                    newWeightedAverage = calculator.CalculateWeightedAverage(costTotal, amountAssetsTotal, operation.operationQuantity, operation.operationUnitCost);

                    amountAssetsTotal += operation.operationQuantity;

                    // Compra não paga imposto/taxa
                    result.tax = 0.00;
                }
                
                if(operation.operationType == Parameter.SELL)
                {

                    double lucro_acao_valor_total = amountAssetsTotal * newWeightedAverage;
                    double weightedEstimatedProfit = newWeightedAverage * operation.operationQuantity;
                    double profitPerSale = operation.operationUnitCost * operation.operationQuantity;

                    if (profitPerSale - weightedEstimatedProfit < 0)
                    {
                        // indica que houve prejuízo na venda
                        deductionValue += weightedEstimatedProfit - profitPerSale;
                        result.tax = 0.00;
                    }

                    if (profitPerSale - weightedEstimatedProfit >= 0) {

                        // Valor mínimo a ser pago
                        if ((profitPerSale - deductionValue) <= Parameter.MIN_VALUE)
                        {
                            result.tax = 0.00;
                        }
                        else
                        {
                            // Cálculo da taxa de imposto 
                            double defaulTaxtValue = calculator.DefaulTaxtValue(profitPerSale,weightedEstimatedProfit,deductionValue);
                            defaulTaxtValue = (((defaulTaxtValue) * Parameter.IMPOSTO_PERCENT) / 100);
                            result.tax = Math.Round(defaulTaxtValue, 2);
                        }

                        if (profitPerSale > weightedEstimatedProfit)
                        {

                            if (deductionValue > 0)
                            {
                                // Remove parte do valor de dedução
                                var restante = profitPerSale - weightedEstimatedProfit;
                                if (deductionValue - restante>0)
                                {
                                    deductionValue = deductionValue - restante;
                                }
                                else
                                {
                                    deductionValue = restante - deductionValue;
                                } 
                            }
                        }
                    }

                    amountAssetsTotal -= operation.operationQuantity;

                    costTotal -= deductionValue;
                }
                
                resultsReturnJson.Add(result);
            }
            
            jsonResults.Add(resultsReturnJson);
        }

        File.WriteAllText(fileManager.GetFileName(), (JsonSerializer.Serialize<object>(jsonResults)));
    }
}