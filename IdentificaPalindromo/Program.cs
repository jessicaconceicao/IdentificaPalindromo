//Dada uma entrada identificar se ela é palíndromo ou não, e, caso não seja, determinar quantas alterações precisariam ser feitas pra ela se tornar  palíndromo.

string entrada = Console.ReadLine();
var entradaChar = entrada.ToLower().ToCharArray();
var entradaReversa = entrada.Reverse().ToArray();
int diferem = 0;

for (int i = 0; i <= (entradaReversa.Length - 1) / 2; i++)
{
    if (entradaReversa[i] != entradaChar[i])
    {
        diferem++;
    }
}

if (diferem == 0)
{
    Console.WriteLine("A entrada é um palíndromo.");
}
else if (diferem == 1)
{
    Console.WriteLine($"É necessária {diferem} mudança para que a entrada se torne palindroma.");
}
else
{
    Console.WriteLine($"São necessárias {diferem} mudanças para que a entrada se torne palindroma.");
}
