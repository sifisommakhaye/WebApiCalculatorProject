using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCalculatorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        [HttpGet]
        // Addition
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpGet]
        // Subtraction 
        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        [HttpGet]
        // Multliply
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        [HttpGet]
        // Divide
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        [HttpGet]
        public string Get()
        {
            return "default";
        }
    }
}
