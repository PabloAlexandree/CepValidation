using ConsoleApp2.verification;

class program
{
    static void Main(string[] args)
    {
        cepvalidacao Exemplo1 = new cepvalidacao();
        Exemplo1.cep = "26290-717";
        Exemplo1.verifica();
    }
}

//class program2
//{
//    static void Main(string[] args)
//    {
//        Verification exemplo2 = new Verification();
//        exemplo2.Cep = "26.290-717";
//        exemplo2.CepVerification();
//    }
//}
