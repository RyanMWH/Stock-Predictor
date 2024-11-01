// Ryan Hanner
// U69082659
// Stock Predictor for COP4365
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPredictor
{
    // Form to handle user input for loading and filtering stock data
    public partial class Input_Form : Form
    {
        // Constructor to initialize the form
        public Input_Form()
        {
            InitializeComponent();

            // Initialize and configure the OpenFileDialog
            openFileDialog_load = new OpenFileDialog();
            openFileDialog_load.FileOk += OpenFileDialog_load_FileOk; // Event handler for file selection
            openFileDialog_load.Filter = "CSV Files (*.csv)|*.csv"; // Filter for CSV files
            openFileDialog_load.Title = "File Selection"; // Title of the file dialog
            openFileDialog_load.InitialDirectory = "C:\\"; // Initial directory for file dialog
            openFileDialog_load.RestoreDirectory = false; // Do not restore previous directory
            openFileDialog_load.ShowHelp = false; // Do not show help button
        }

        // Event handler for file selection
        private void OpenFileDialog_load_FileOk(object sender, CancelEventArgs e)
        {
            var filepath = openFileDialog_load.FileName; // Get the selected file path
            var fileName = Path.GetFileNameWithoutExtension(filepath); // Get the file name without extension

            // Load all candlestick data from the selected file
            List<Candlestick> allCandleSticks = CandlestickLoader.LoadFromCSV(filepath);

            // Properties
            DateTime startDate = DateTimePicker_start.Value; // Get the start date from the date picker
            DateTime endDate = DateTimePicker_end.Value; // Get the end date from the date picker

            // Filter candlesticks based on the selected date range
            List<Candlestick> filteredCandlesticks = FilteredCandlesticks(allCandleSticks, startDate, endDate);
            Console.WriteLine($"Loaded {filteredCandlesticks.Count} filtered candlesticks."); // Debug: Print the number of filtered candlesticks

            // Bind the filtered candlesticks to a BindingList
            BindingList<Candlestick> boundList = new BindingList<Candlestick>(filteredCandlesticks);

            // Create and display the input form with the filtered data
            Display_Input_Form display_Input_Form = new Display_Input_Form(filteredCandlesticks, fileName);
            display_Input_Form.Text = fileName; // Set the form title to the file name
            display_Input_Form.DataGridView_stock.DataSource = boundList; // Bind the data grid view to the filtered candlestick list
            display_Input_Form.Chart_stock.DataSource = boundList; // Bind the chart to the filtered candlestick list
            display_Input_Form.Show(); // Show the form
        }

        // Event handler for form load
        private void Input_Form_Load(object sender, EventArgs e)
        {
        }

        // Event handler for start time picker value change
        private void starttimepicker_ValueChanged(object sender, EventArgs e)
        {
        }

        // Event handler for end time picker value change
        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        // Event handler for load button click
        private void load_button_Click(object sender, EventArgs e)
        {
            openFileDialog_load.ShowDialog(); // Show the file dialog
        }

        // Method to filter candlesticks based on the selected date range
        public static List<Candlestick> FilteredCandlesticks(List<Candlestick> candlesticks, DateTime startDate, DateTime endDate)
        {
            var filteredCandlesticks = new List<Candlestick>(); // List to hold filtered candlesticks

            // Loop through each candlestick and filter by date range
            foreach (var candlestick in candlesticks)
            {
                if (candlestick.Date >= startDate && candlestick.Date <= endDate)
                {
                    filteredCandlesticks.Add(candlestick); // Add candlestick to filtered list if within date range
                }
                if (candlestick.Date >= endDate)
                {
                    break; // Stop filtering if the date exceeds the end date
                }
            }

            return filteredCandlesticks; // Return the filtered list
        }
    }
}
