var numbers = new int[] { 2, 4, 5, 9, 3, 1, };

StampaArray(numbers);

Console.Write("Inserisci un numero: ");
int numero = int.Parse(Console.ReadLine());
int quadrato = Quadrato(numero);
Console.WriteLine($"Il quadrato di {numero} è {quadrato}");

int[] squaredNumbers = ElevaArrayAlQuadrato(numbers);
StampaArray(squaredNumbers);

void StampaArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]);
        if (i != numbers.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


int Quadrato(int numero)
{
    return numero * numero;
}


int[] ElevaArrayAlQuadrato(int[] numbers)
{
    int[] newArray = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        newArray[i] = numbers[i] * numbers[i];
    }
    return newArray;
}