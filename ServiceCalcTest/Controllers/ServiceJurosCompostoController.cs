using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceCalcTest.Controllers
{
    public class ServiceJurosCompostoController : Controller
    {
        /// <summary>
        /// Efetua cálculo de juros composto.
        /// </summary>
        /// <param name="valorinicial">Valor inicial para base do cálculo.</param> 
        /// <param name="mes">Quantidade de meses que será aplicado o juros.</param> 
        [HttpGet("calculajuros")]
        public double JurosComposto(double valorinicial, int mes)
        {
            double juros = Double.MinValue;
            return juros;
        }

        /// <summary>
        /// Retorna o caminho do projeto no GitHub.
        /// </summary>
        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return "https://github.com/murilosartori/calculajuros";
        }
    }
}