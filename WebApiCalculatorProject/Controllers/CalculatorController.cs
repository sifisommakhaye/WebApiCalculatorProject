using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCalculatorProject.Models;

namespace WebApiCalculatorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        // Addition
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        [HttpGet]
        // Subtraction 
        public int Substract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        [HttpGet]
        // Multliply
        public int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        [HttpGet]
        // Divide
        public int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

    }
}
