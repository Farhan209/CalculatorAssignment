using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorAPI.Controllers
{
    // ../api/Calculator
    public class CalculatorController : ApiController
    {
        // ../api/Calculator/Add
        [HttpGet]
        public int Add(int firstNum, int secondNum) {
            return firstNum + secondNum;
        }

        // ../api/Calculator/Sub
        [HttpGet]
        public int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        // ../api/Calculator/Mult
        [HttpGet]
        public int Mult(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        // ../api/Calculator/Div
        [HttpGet]
        public int Div(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }

        // ../api/Controller
        [HttpGet]
        public string Get()
        {
            return "Select One Of The Arithmetics (Add/Sub/Mult/Div)";
        }
    }
}
