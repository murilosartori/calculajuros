using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceCalcTest.Controllers
{
    public class ServiceJurosCompostoController : Controller
    {
        [HttpGet("calculajuros")]
        public double JurosComposto(double valorinicial, int mes)
        {
            double juros = Double.MinValue;
            return juros;
        }
    }
}