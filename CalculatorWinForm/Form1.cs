﻿using System;
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
            var resultNumber = getCalculatorAdd(firstNumber, secondNumber);
            resultOutput.Text = resultNumber.ToString();
        }

        public int getCalculatorAdd(int firstInput, int secondInput) {
             string firstNumber = firstInput.ToString();
             string secondNumber = secondInput.ToString();
             var output = Task.Run(() => Add(firstNumber, secondNumber));
             return output.Result;
        }

        static async Task<int> Add(string firstNumber, string secondNumber) {
            using (var httpClient = new HttpClient()) {
                httpClient.BaseAddress = new Uri("http://localhost:51955/");
                var resultAPI = await httpClient.GetAsync("api/Calculator/Add/?firstNum=" + firstNumber + "&secondNum=" + secondNumber);
                string resultString = await resultAPI.Content.ReadAsStringAsync();
                int resultInt = Convert.ToInt32(resultString);
                return resultInt;
            }
        }

    }
}
