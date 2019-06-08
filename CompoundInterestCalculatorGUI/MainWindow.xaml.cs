using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompoundInterestCalculatorGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator_v1 calc = new Calculator_v1();

        public MainWindow()
        {
            InitializeComponent();
        }

        private double ValidateValues(string txt)
        {
            double value;
            bool isDouble = Double.TryParse(txt, out value);
            if (!isDouble)
            {
                MessageBox.Show("Please enter valid values and try again.", "Error");
            }
            else if (isDouble)
            {
                return value = double.Parse(txt);
            }            
            return value = 0;       
        }

        private double ValidateYears(string txt)
        {
            int value;
            bool isInt = int.TryParse(txt, out value);
            if (!isInt)
            {
                MessageBox.Show("Please enter a valid value for 'Years to Compound' and try again.", "Error");
            }
            else if (isInt)
            {
                return value = int.Parse(txt);
            }            
            return value = 0;
            
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            calc._principal = ValidateValues(textBoxPrincipal.Text);
            calc._interest = ValidateValues(textBoxInterest.Text);
            calc._years = (int)ValidateYears(textBoxYears.Text);
            textBoxResult.Text = calc.CalculateInterest().ToString("C2");
        }
    }
}
