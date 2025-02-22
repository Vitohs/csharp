using System;

try
{
    A.ProcessarA();
}
catch (Exception e) 
{
    Console.WriteLine("Tratado na main");
}

Console.ReadKey();

class A
{
    public static void ProcessarA()
    {
        try
        {
            B.ProcessarB();
        }
        catch (Exception ex)
        {
            throw ex;//aqui, eu estou lançando a exceção, porem é uma nova, ou seja, a exceção da classe C nao existe mais.
            Console.WriteLine("Tratado na A");
        }
    }
}
class B
{
    public static void ProcessarB()
    {
        try
        {
            C.ProcessarC();
        }
        catch (Exception e)
        {
            throw;//estou relançando a exceção, ela vai procurar algo para ser tratando nos niveis acima.. classe A ou main
            Console.WriteLine("tratado na B");
        }
    }
}
class C
{
    public static void ProcessarC()
    {
        throw new Exception("Erro no processamento");//lançando uma exceção
    }
}