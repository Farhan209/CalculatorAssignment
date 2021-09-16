using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinForm
{
    class HttpArithmetics
    {
        public static int getCalculatorAdd(int firstInput, int secondInput)
        {
            string firstNumber = firstInput.ToString();
            string secondNumber = secondInput.ToString();
            var output = Task.Run(() => Add(firstNumber, secondNumber));
            return output.Result;
        }

        static async Task<int> Add(string firstNumber, string secondNumber)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:51955/");
                var resultAPI = await httpClient.GetAsync("api/Calculator/Add/?firstNum=" + firstNumber + "&secondNum=" + secondNumber);
                string resultString = await resultAPI.Content.ReadAsStringAsync();
                int resultInt = Convert.ToInt32(resultString);
                return resultInt;
            }
        }

        public static int getCalculatorSub(int firstInput, int secondInput)
        {
            string firstNumber = firstInput.ToString();
            string secondNumber = secondInput.ToString();
            var output = Task.Run(() => Sub(firstNumber, secondNumber));
            return output.Result;
        }

        static async Task<int> Sub(string firstNumber, string secondNumber)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:51955/");
                var resultAPI = await httpClient.GetAsync("api/Calculator/Sub/?firstNum=" + firstNumber + "&secondNum=" + secondNumber);
                string resultString = await resultAPI.Content.ReadAsStringAsync();
                int resultInt = Convert.ToInt32(resultString);
                return resultInt;
            }
        }
        public static int getCalculatorMult(int firstInput, int secondInput)
        {
            string firstNumber = firstInput.ToString();
            string secondNumber = secondInput.ToString();
            var output = Task.Run(() => Mult(firstNumber, secondNumber));
            return output.Result;
        }

        static async Task<int> Mult(string firstNumber, string secondNumber)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:51955/");
                var resultAPI = await httpClient.GetAsync("api/Calculator/Mult/?firstNum=" + firstNumber + "&secondNum=" + secondNumber);
                string resultString = await resultAPI.Content.ReadAsStringAsync();
                int resultInt = Convert.ToInt32(resultString);
                return resultInt;
            }
        }
        public static int getCalculatorDiv(int firstInput, int secondInput)
        {
            string firstNumber = firstInput.ToString();
            string secondNumber = secondInput.ToString();
            var output = Task.Run(() => Div(firstNumber, secondNumber));
            return output.Result;
        }

        static async Task<int> Div(string firstNumber, string secondNumber)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:51955/");
                var resultAPI = await httpClient.GetAsync("api/Calculator/Div/?firstNum=" + firstNumber + "&secondNum=" + secondNumber);
                string resultString = await resultAPI.Content.ReadAsStringAsync();
                int resultInt = Convert.ToInt32(resultString);
                return resultInt;
            }
        }
    }
}
