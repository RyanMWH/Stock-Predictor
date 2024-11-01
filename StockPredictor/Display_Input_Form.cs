// Ryan Hanner
// U69082659
// Stock Predictor for COP4365
using System; // Importing System namespace
using System.Collections.Generic; // Importing Collections.Generic namespace
using System.ComponentModel; // Importing ComponentModel namespace
using System.Windows.Forms; // Importing Windows.Forms namespace
using System.Windows.Forms.DataVisualization.Charting; // Importing DataVisualization.Charting namespace

namespace StockPredictor // Declaring namespace
{
    // Form to display the candlestick and volume charts, and the data grid view
    public partial class Display_Input_Form : Form
    {
        private List<Candlestick> candlesticks; // List to hold candlestick data
        private string filename; // Filename of the stock data

        // Constructor to initialize the form with candlestick data and filename
        public Display_Input_Form(List<Candlestick> candlesticks, string filename)
        {
            InitializeComponent(); // Initialize form components
            this.candlesticks = candlesticks; // Assign candlestick data
            this.filename = filename; // Assign filename

            // Debug: Print the number of candlesticks loaded
            Console.WriteLine("Candlesticks Count: " + candlesticks.Count);
            foreach (var candle in candlesticks) // Print each candlestick
            {
                Console.WriteLine(candle.ToString());
            }

            LoadCandleStickData(); // Load candlestick data into charts and data grid view
        }

        // Method to load candlestick, volume chart, and data grid view
        private void LoadCandleStickData()
        {
            SetupChart(); // Set up the candlestick chart
            SetupVolumeChart(); // Set up the volume chart
            SetupDataGridView(); // Set up the data grid view
        }

        // Method to set up the candlestick chart
        private void SetupChart()
        {
            Chart_stock.Series.Clear(); // Clear existing series
            Series series = new Series(filename) // Create new series with filename
            {
                ChartType = SeriesChartType.Candlestick, // Set chart type to candlestick
                XValueType = ChartValueType.DateTime // Set X value type to DateTime
            };

            // Loop through each candlestick and add data points to the series
            foreach (var candle in candlesticks)
            {
                var dataPoint = new DataPoint(candle.Date.ToOADate(), new double[] { (double)candle.High, (double)candle.Low, (double)candle.Open, (double)candle.Close });
                if (candle.IsBullish())
                {
                    dataPoint.Color = System.Drawing.Color.Lime; // Green for bullish
                }
                else
                {
                    dataPoint.Color = System.Drawing.Color.Red; // Red for bearish
                    dataPoint.BackSecondaryColor = System.Drawing.Color.Red;
                }
                series.Points.Add(dataPoint); // Add data point to series
            }

            Chart_stock.Series.Clear(); // Clear existing series again for safety
            Chart_stock.Series.Add(series); // Add new series
            Chart_stock.DataBind(); // Bind data to chart

            if (Chart_stock.Legends.Count > 0)
            {
                Chart_stock.Legends[0].Enabled = false; // Disable legend if it exists
            }

            // Debug: Print if chart is added
            Console.WriteLine("Chart updated with series points count: " + series.Points.Count);
        }

        // Method to set up the volume chart
        private void SetupVolumeChart()
        {
            chart_volume.Series.Clear(); // Clear existing series
            Series volumeSeries = new Series("Volume") // Create new series for volume
            {
                ChartType = SeriesChartType.Column, // Set chart type to column
                XValueType = ChartValueType.DateTime // Set X value type to DateTime
            };

            // Loop through each candlestick and add volume data points to the series
            foreach (var candle in candlesticks)
            {
                var datapoint = new DataPoint(candle.Date.ToOADate(), (double)candle.Volume);
                volumeSeries.Points.Add(datapoint);
            }

            chart_volume.Series.Add(volumeSeries); // Add new series
            chart_volume.DataBind(); // Bind data to chart
        }

        // Method to set up the data grid view
        private void SetupDataGridView()
        {
            DataGridView_stock.DataSource = new BindingList<Candlestick>(candlesticks); // Bind candlestick list to data grid view

            // Debug: Print if DataGridView is updated
            Console.WriteLine("DataGridView updated with rows count: " + DataGridView_stock.Rows.Count);
        }

        // Load event handler for the form
        private void Display_Input_Form_Load(object sender, EventArgs e)
        {
        }
    }
}