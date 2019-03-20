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
        public IActionResult Index()
        {
            return Ok("https://github.com/murilosartori/calculajuros");
        }
    }
}