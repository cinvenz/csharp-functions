//var numbers = new int[] { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Quanti numeri vuoi inserire?");
int insertNum = int.Parse(Console.ReadLine());

int[] numbers = new int[insertNum];
for (int i = 0; i < insertNum; i++)
{
    Console.WriteLine($"Inserisci il {i + 1}° numero:");
    numbers[i] = int.Parse(Console.ReadLine());
    int quadrato = Quadrato(numbers[i]);
    Console.WriteLine($"Il quadrato di {numbers[i]} è {quadrato}");
}

StampaArray(numbers);



int[] squaredNumbers = ElevaArrayAlQuadrato(numbers);
StampaArray(squaredNumbers);

int somma = sommaElementiArray(numbers);
Console.WriteLine($"La somma degli elementi è {somma}");

int sommaQuadrati = sommaElementiArray(squaredNumbers);
Console.WriteLine($"La somma dei quadrati degli elementi è {sommaQuadrati}");

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

int sommaElementiArray(int[] numbers)
{
    int somma = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        somma += numbers[i];
    }
    return somma;
}