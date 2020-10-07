using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculator_api.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace calculator_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {

        private CalculatorService service;

        public CalculatorController()
        {
            service = new CalculatorService();
        }

        [HttpPost]
        [Route("calculate")]
        public Sum Calculate(Sum sum)
        {
            sum.Answer = service.Calculate(sum.Num1, sum.Num2, sum.OperatorString);
            return sum;
        }

    }
}
