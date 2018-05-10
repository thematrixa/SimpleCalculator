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

namespace SimpleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 1;
        double number2 = 0;
        string sign = "";
        double result = 0;
        bool isNumber2Active = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void sevenBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "7";
        }

        private void nineBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "9";
        }

        private void eightBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "8";
        }
        private void sixBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "6";

        }
        private void fiveBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "5";

        }
        private void fourBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "4";
        }
        private void threeBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "3";

        }
        private void twoBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "2";
        }
        private void oneBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "1";
        }

        private void divBut_Click(object sender, RoutedEventArgs e)
        {
            if (valueBox.Text.Equals("") || isNumber2Active)
            {
                return;
            }
            this.getNumber();
            this.switchNumbers();
            this.clearTextBox();
            this.sign = "/";
            this.refreshCurrentEquationBox(number1.ToString());
            this.refreshCurrentEquationBox(this.sign);

        }

        private void mulBut_Click(object sender, RoutedEventArgs e)
        {
            if (valueBox.Text.Equals("") || isNumber2Active)
            {
                return;
            }
            this.getNumber();
            this.switchNumbers();
            this.clearTextBox();
            this.sign = "*";
            this.refreshCurrentEquationBox(number1.ToString());
            this.refreshCurrentEquationBox(this.sign);
        }

        private void subBut_Click(object sender, RoutedEventArgs e)
        {
            if (valueBox.Text.Equals("") || isNumber2Active)
            {
                return;
            }
            this.getNumber();
            this.switchNumbers();
            this.clearTextBox();
            this.sign = "-";
            this.refreshCurrentEquationBox(number1.ToString());
            this.refreshCurrentEquationBox(this.sign);
        }

        private void addBut_Click(object sender, RoutedEventArgs e)
        {
            if (valueBox.Text.Equals("") || isNumber2Active)
            {
                return;
            }
            this.getNumber();
            this.switchNumbers();
            this.clearTextBox();
            this.sign = "+";
            this.refreshCurrentEquationBox(number1.ToString());
            this.refreshCurrentEquationBox(this.sign);
        }

        private void equalsBut_Click(object sender, RoutedEventArgs e)
        {
            if (valueBox.Text.Equals(""))
            {
                return;
            }
            this.getNumber();
            this.refreshCurrentEquationBox(this.number2.ToString());
            this.solveEquation();
            this.clearTextBox();
            //this.showResult();
            this.switchNumbers();
            this.refreshCurrentEquationBox("=");
            this.refreshCurrentEquationBox(this.result.ToString());
        }

        private void clearBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text ="";
        }

        private void pointBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += ".";
        }

        private void switchNumbers() {
            if (isNumber2Active==true)
            {
                isNumber2Active = false;
            }
            else {
                isNumber2Active = true;
            }
        }


        private void getNumber() {
            
            if (isNumber2Active == true)
            {
                number2 = double.Parse(valueBox.Text);
            }
            else
            {
                number1 = double.Parse(valueBox.Text);
            }
        }

        private void zeroBut_Click(object sender, RoutedEventArgs e)
        {
            valueBox.Text += "0";
        }

        private void clearTextBox() {
            valueBox.Text = "";
        }

        private void solveEquation() {
            if (this.sign.Equals("/")) {
                this.result = this.number1 / this.number2;
            }
            if (this.sign.Equals("*"))
            {
                this.result = this.number1 * this.number2;
            }
            if (this.sign.Equals("+"))
            {
                this.result = this.number1 + this.number2;
            }
            if (this.sign.Equals("-"))
            {
                this.result = this.number1 - this.number2;
            }
        }

        private void showResult() {
            this.valueBox.Text = result.ToString();
        }


        private void refreshCurrentEquationBox(string textToAdd) {
                currentEquationBox.Text += textToAdd;
        }
    }
}
