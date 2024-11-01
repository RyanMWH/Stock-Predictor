// Ryan Hanner
// U69082659
// Stock Predictor for COP4365
using System; // Importing System namespace
using System.Collections.Generic; // Importing Collections.Generic namespace
using System.Linq; // Importing Linq namespace
using System.Text; // Importing Text namespace
using System.Threading.Tasks; // Importing Threading.Tasks namespace

namespace StockPredictor // Declaring namespace
{
    // Represents a single candlestick in a financial chart
    public class Candlestick
    {
        // Properties of the Candlestick
        public DateTime Date { get; set; } // The date of the candlestick
        public decimal Open { get; set; } // The opening price
        public decimal Close { get; set; } // The closing price
        public decimal High { get; set; } // The highest price
        public decimal Low { get; set; } // The lowest price
        public long Volume { get; set; } // The trading volume

        // Constructor to initialize a new candlestick with given values
        public Candlestick(DateTime date, decimal open, decimal close, decimal high, decimal low, long volume)
        {
            Date = date; // Assign the date
            Open = open; // Assign the opening price
            Close = close; // Assign the closing price
            High = high; // Assign the highest price
            Low = low; // Assign the lowest price
            Volume = volume; // Assign the trading volume
        }

        // Method to determine if the candlestick is bullish
        // A bullish candlestick has a higher closing price than the opening price
        public bool IsBullish()
        {
            return Close > Open; // Return true if close is greater than open
        }

        // Method to determine if the candlestick is bearish
        // A bearish candlestick has a lower closing price than the opening price
        public bool IsBearish()
        {
            return Close < Open; // Return true if close is less than open
        }

        // Method to calculate the range of the candlestick
        // The range is the difference between the highest and lowest prices
        public decimal Range()
        {
            return High - Low; // Return the difference between high and low
        }

        // Override ToString method for easy debugging
        // Provides a string representation of the candlestick
        public override string ToString()
        {
            // Return a string representing the candlestick details
            return $"{Date}: Open={Open}, Close={Close}, High={High}, Low={Low}, Volume={Volume}, Bullish={IsBullish()}";
        }
    }
}


