using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.verification
{
    public class Verification
    {
        public string Cep { get; set; }

        public void CepVerification()
        {
            //Console.Write("Digite seu cep: ");
           // string numerocep = Console.ReadLine();

            int contador = 0;
            foreach (var item in this.Cep)    
            {
                bool valor = char.IsDigit(item);

                if (valor == true)
                { 
                contador++;
                }
            }

            if (contador == 8)
                Console.WriteLine("Cep Válido");

            else
                Console.WriteLine("Cep Inválido");

        }
    }
}
// ver se tem caracteres especial faz o tratamento a valida  ou remova os caracteres