using System.ComponentModel.DataAnnotations;

namespace Calculator.Models
{
    public class CalculadoraViewModel
    {   /// <summary>
        /// Numero 1
        /// </summary>
        [Display(Name="Numero 1")]
        public int Num1 { get; set; }
        /// <summary>
        /// Numero 2
        /// </summary>
        [Display(Name = "Numero 2")]
        public int Num2 { get; set; }
        /// <summary>
        /// Operador + - * /
        /// </summary>
        public string Operador { get; set; }
        /// <summary>
        /// Resultado da operacao
        /// </summary>
        public int? Resultado { get; set; }
    }
}