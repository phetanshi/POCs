using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMLApp.Helper
{
    public class TestRunner
    {
        public static void RunTest()
        {
            while (true)
            {
                Console.Write("Please enter some comment : ");
                string input = Console.ReadLine();
                Console.Write("\n");
                if (string.IsNullOrWhiteSpace(input))
                {
                    return;
                }

                //Load sample data
                var sampleData = new SentimentModel.ModelInput()
                {
                    Col0 = input,
                };

                //Load model and predict output
                var predictionResult = SentimentModel.Predict(sampleData);

                Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...");

                string label = "---";

                if (predictionResult.PredictedLabel == 1)
                {
                    label = "Positive";
                }
                else if(predictionResult.PredictedLabel == 0)
                {
                    label = "Negetive";
                }

                Console.WriteLine($"\n\nPredicted Col1: \"{label}\"\n\n");
            }
        }
    }
}
