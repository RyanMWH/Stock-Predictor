// Ryan Hanner
// U69082659
// Stock Predictor for COP4365
using System; // Importing System namespace
using System.Collections.Generic; // Importing Collections.Generic namespace
using System.Globalization; // Importing Globalization namespace
using System.IO; // Importing IO namespace
using System.Linq; // Importing Linq namespace
using System.Text; // Importing Text namespace
using System.Threading.Tasks; // Importing Threading.Tasks namespace

namespace StockPredictor // Declaring namespace
{
    // Static class to load candlestick data from a CSV file
    public static class CandlestickLoader
    {
        // Method to load candlestick data from a CSV file
        public static List<Candlestick> LoadFromCSV(string filePath)
        {
            var candlesticks = new List<Candlestick>(); // List to hold the candlestick data

            using (var reader = new StreamReader(filePath)) // Open the CSV file
            {
                string line; // Variable to hold each line read from the file
                while ((line = reader.ReadLine()) != null) // Read each line until the end
                {
                    var values = line.Split(','); // Split the line into values based on commas
                    values[0] = values[0].Trim('"'); // Remove quotes from the date value

                    Console.WriteLine("CSV Line: " + line); // Debug: Print the CSV line

                    // Try parsing each value and create a Candlestick object if successful
                    if (DateTime.TryParse(values[0], out DateTime dateTime) &&
                        decimal.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal open) &&
                        decimal.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal close) &&
                        decimal.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal high) &&
                        decimal.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal low) &&
                        long.TryParse(values[5], out long volume))
                    {
                        candlesticks.Add(new Candlestick(dateTime, open, close, high, low, volume)); // Add the candlestick to the list
                    }
                    else
                    {
                        Console.WriteLine("Failed to parse line: " + line); // Debug: Print if parsing fails
                    }
                }

                // Check if the list is in descending order by date
                if (candlesticks[0].Date > candlesticks[1].Date)
                {
                    candlesticks.Reverse(); // Reverse the list if it is in descending order
                }
            }

            Console.WriteLine("Total candlesticks loaded: " + candlesticks.Count); // Debug: Print total number of candlesticks loaded
            return candlesticks; // Return the list of candlesticks
        }
    }
}

