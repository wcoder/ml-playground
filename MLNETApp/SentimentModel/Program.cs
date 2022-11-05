using static System.Console;

namespace SentimentModel.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...");

        var line = string.Empty;
        do
        {
            WriteLine("Write something to predict:");
            line = ReadLine();

            // Create single instance of sample data from first line of dataset for model input
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = line,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = SentimentModel.Predict(sampleData);

            WriteLine($"Predicted positivity: {predictionResult.PredictedLabel:F4} -> {predictionResult.PredictedLabel}\n\n");
        }
        while (!string.IsNullOrEmpty(line));
    }
}