using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstInput.Text);
            int secondNumber = Convert.ToInt32(secondInput.Text);
            var resultNumber = HttpArithmetics.getCalculatorAdd(firstNumber, secondNumber);
            resultOutput.Text = resultNumber.ToString();
            var operatorA = "Add";
            DatabaseConnection.insertData(firstNumber, secondNumber, operatorA, resultNumber);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstInput.Text);
            int secondNumber = Convert.ToInt32(secondInput.Text);
            var resultNumber = HttpArithmetics.getCalculatorSub(firstNumber, secondNumber);
            resultOutput.Text = resultNumber.ToString();
            var operatorA = "Sub";
            DatabaseConnection.insertData(firstNumber, secondNumber, operatorA, resultNumber);
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstInput.Text);
            int secondNumber = Convert.ToInt32(secondInput.Text);
            var resultNumber = HttpArithmetics.getCalculatorMult(firstNumber, secondNumber);
            resultOutput.Text = resultNumber.ToString();
            var operatorA = "Mult";
            DatabaseConnection.insertData(firstNumber, secondNumber, operatorA, resultNumber);
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstInput.Text);
            int secondNumber = Convert.ToInt32(secondInput.Text);
            var resultNumber = HttpArithmetics.getCalculatorDiv(firstNumber, secondNumber);
            resultOutput.Text = resultNumber.ToString();
            var operatorA = "Div";
            DatabaseConnection.insertData(firstNumber, secondNumber, operatorA, resultNumber);
        }
    }
}
