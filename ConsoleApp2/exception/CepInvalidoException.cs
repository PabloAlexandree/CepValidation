using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.exception
{
    public class CepInvalidoException : Exception
    {
        public CepInvalidoException(string mensagem) : base(mensagem)
        {

        }
    }
}
