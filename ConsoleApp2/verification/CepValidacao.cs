using System;
using System.Text.RegularExpressions;


namespace ConsoleApp2.verification
{
   public class cepvalidacao
    {
        public string cep { get; set; }

        public void verifica()
        {
            //Console.Write("digite o cep:");
            //string cep = Console.ReadLine();

            if (validacep())
            {
                Console.WriteLine("cep válido!");
            }
            else
            {
                Console.WriteLine("cep inválido!");
            }
        }

        public bool validacep()
        {
            Regex rgx = new Regex(@"^\d{5}-?\d{3}$");
            return rgx.IsMatch(this.cep);
        }
    }
}
