using System;
ClasseFilha filha = new();
filha.Verifica_Acesso();

Console.ReadKey();
public class ClasseFilha : ClassePaizao
{
    public void Verifica_Acesso()
    {
        PublicAcess();
        ProtectedAcess();
        InternalAcess();
        //PrivateAcess();
        ProtectedInternalAcess();
        Console.WriteLine("acesso ao campo private usando propriedade");
        private_ = 10;
        var soma = public_var + protected_var + internal_var + private_;
        Console.WriteLine(soma);
    }
}
public class ClassePaizao
{
    //campos
    public int public_var = 0;
    protected int protected_var = 1;
    internal int internal_var = 2;
    private int private_var = 3;
    //para podermos acessar o campo private_var, precisamos de uma propriedade
    public int private_ 
    {
        get { return private_var; }
        set { private_var = value; }
    }
    public void PublicAcess()
    {
        Console.WriteLine("PublicAcess");
    }
    protected void ProtectedAcess()
    {
        Console.WriteLine("ProtectedAcess");
    }
    internal void InternalAcess()
    {
        Console.WriteLine("InternalAcess");
    }
    private void PrivateAcess()
    {
        Console.WriteLine("PrivateAcess");
    }
    protected internal void ProtectedInternalAcess()
    {
        Console.WriteLine("ProtectedInternalAcess");
    }
}