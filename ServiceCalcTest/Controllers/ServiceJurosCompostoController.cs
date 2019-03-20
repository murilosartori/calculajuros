using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCalcTest;
using Microsoft.AspNetCore.Mvc;

namespace ServiceCalcTest.Controllers
{
    public class ServiceJurosCompostoController : Controller
    {
        private readonly AppJurosComposto _AppJurosComposto = new AppJurosComposto();
        /// <summary>
        /// Efetua cálculo de juros composto.
        /// </summary>
        /// <param name="valorinicial">Valor inicial para base do cálculo.</param> 
        /// <param name="mes">Quantidade de meses que será aplicado o juros.</param> 
        [HttpGet("calculajuros")]
        public double JurosComposto(double valorinicial, int mes)
        {
            return _AppJurosComposto.CalculoJurosComposto(valorinicial, mes);
        }
    }
}