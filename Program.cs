int contadorMaiusculas = 0;
int contadorMinusculas = 0;
string palavra;

Console.WriteLine("Digite uma string:");
palavra = Console.ReadLine();

foreach (char p in palavra)
{
    if (p == 'A')
    {
        contadorMaiusculas++;
    }
    if(p == 'a')
    {
        contadorMinusculas++;
    }
}

if (contadorMaiusculas > 0 || contadorMinusculas > 0)
{
    Console.WriteLine($"A letra 'a' apareceu. Sendo {contadorMaiusculas} vezes como maiúscilas e {contadorMinusculas} como minúsculas.");
}
else
{
    Console.WriteLine("A letra 'a' não foi encontrada na string.");
}