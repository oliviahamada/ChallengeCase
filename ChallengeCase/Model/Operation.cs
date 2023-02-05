using System.Text.Json.Serialization;

namespace ChallengeCase.Model
{
    public class Operation
    {
        [JsonPropertyName("operation")]
        public string operationType { get; set; }

        [JsonPropertyName("unit-cost")]
        public float operationUnitCost { get; set; }

        [JsonPropertyName("quantity")]
        public float operationQuantity { get; set; }
    }
}
