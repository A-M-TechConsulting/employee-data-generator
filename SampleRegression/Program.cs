
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace SampleRegression.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            SampleRegression.ModelInput sampleData = new SampleRegression.ModelInput()
            {
                Age = 33F,
                Gender = @"Female",
                Ethnicity = @"Black",
                Department = @"Engineering",
                JobTitle = @"Analyst",
                PerformanceScore = 5F,
                TenureYears = 9.7F,
                Location = @"New York",
            };


            Console.WriteLine("Using model to make single prediction -- Comparing actual Salary with predicted Salary from sample data...\n\n");


            Console.WriteLine($"Age: {33F}");
            Console.WriteLine($"Gender: {@"Female"}");
            Console.WriteLine($"Ethnicity: {@"Black"}");
            Console.WriteLine($"Department: {@"Engineering"}");
            Console.WriteLine($"JobTitle: {@"Analyst"}");
            Console.WriteLine($"PerformanceScore: {5F}");
            Console.WriteLine($"TenureYears: {9.7F}");
            Console.WriteLine($"Location: {@"New York"}");
            Console.WriteLine($"Salary: {225101F}");


            // Make a single prediction on the sample data and print results
            var predictionResult = SampleRegression.Predict(sampleData);

            Console.WriteLine($"\n\nPredicted Salary: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
