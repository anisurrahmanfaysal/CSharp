for (int i = 0;; i++)
{
    var input = int.Parse(Console.ReadLine());
    if (input == 2002)
    {
        Console.WriteLine("Acesso Permitido");
        return;
    }
    else
        Console.WriteLine("Senha Invalida");
}
