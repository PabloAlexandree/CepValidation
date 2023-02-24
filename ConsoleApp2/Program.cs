using ConsoleApp2.verification;
using System.Security;


public class Program
{
    public static void Main()
    {
        Verification p = new Verification();
        p.Cep = "123456-78";  ;
        p.CepVerification();
    }
}