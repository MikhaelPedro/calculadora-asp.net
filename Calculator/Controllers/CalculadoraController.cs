using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(CalculadoraViewModel calculadoraViewModel)
        {
            ModelState.Clear();
            if (calculadoraViewModel.Operador.Equals("+"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 + calculadoraViewModel.Num2;
            }
            else
            if (calculadoraViewModel.Operador.Equals("-"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 - calculadoraViewModel.Num2;
            }
            else
            if (calculadoraViewModel.Operador.Equals("*"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 * calculadoraViewModel.Num2;
            }
            else    
            if (calculadoraViewModel.Operador.Equals("/"))
            {
                calculadoraViewModel.Resultado = calculadoraViewModel.Num1 / calculadoraViewModel.Num2;
            }
            
            return View(calculadoraViewModel);
        }
    }
}