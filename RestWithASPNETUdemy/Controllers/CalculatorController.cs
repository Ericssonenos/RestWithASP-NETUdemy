using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Models;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        [HttpGet("Sum/{firstNumber}/{secondNuber}")]
        public string Sum(string firstNumber, string secondNuber) 
        {
            var V = new appModel(firstNumber, secondNuber);

            if (V.Validation)
            {
                return "soma é :" + V.Result;

            }

            return "0";
        }
       
    }
}
