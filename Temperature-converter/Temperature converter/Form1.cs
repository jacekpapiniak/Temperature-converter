using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_converter
{
    public partial class Form1 : Form
    {
        private double _parsedTemperatureInCelcius = 0;
        private double _farenheit = 0;
        private string _temperatureText = string.Empty;
        private string _firstNameText = string.Empty;
        private string _lastNameText = string.Empty;
        private string _resultText = string.Empty;

        public Form1()
        {
            InitializeComponent();
            ResultLabel.Text = string.Empty;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var nameTextBox = (TextBox)sender;
           _firstNameText = nameTextBox.Text ;

            PrintResults();
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var lastNameTextBox = (TextBox)sender;
            _lastNameText = lastNameTextBox.Text;

            PrintResults();
        }

        private void TemperatureTextBox_TextChanged(object sender, EventArgs e)
        {
            var temperatureTextBox = (TextBox)sender;
            _temperatureText = temperatureTextBox.Text;

            if (double.TryParse(_temperatureText, out var converted))
            {
                _parsedTemperatureInCelcius = converted;
                _farenheit = TemperatureConverter.ConvertToFarenheit(_parsedTemperatureInCelcius);
            }

            PrintResults();
        }

        private void PrintResults()
        {
            ResultLabel.Text = $"Imię: {_firstNameText} \nNazwisko: {_lastNameText} \nTemperatura w C°:{_parsedTemperatureInCelcius.ToString("F2")} \nTemperatura w F°:{_farenheit.ToString("F2")}";
        }
    }
}
