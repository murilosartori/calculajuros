using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ServiceCalcTest.Controllers
{
    public class ServiceShowmethecodeController : Controller
    {
        /// <summary>
        /// Retorna o caminho do projeto no GitHub.
        /// </summary>
        [HttpGet("showmethecode")]
        public string Index()
        {
            return "https://github.com/murilosartori/calculajuros";
        }
    }
}