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
Console.WriteLine($"La somma degli elementi del primo array è {somma}");

int sommaQuadrati = sommaElementiArray(squaredNumbers);
Console.WriteLine($"La somma dei quadrati degli elementi del secondo array è {sommaQuadrati}");

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

//BONUS "2
//Creare una funzione in grado di cercare il numero più piccolo all'interno di un array di interi positivi e maggiori di 0, senza la possibilità di usare cicli e senza variabili "globali"

int[] array = { 2, 6, 7, 5, 9, 3, 1};
CheckMinNumber(array);

int CheckMinNumber(int[] array)
{
    int sum = array[0] + array[1] + array[2] + array[3] + array[4] + array[5] + array[6];
    
    int a = sum - array[0];
    int b = sum - array[1];
    int c = sum - array[2];
    int d = sum - array[3];
    int e = sum - array[4];
    int f = sum - array[5];
    int g = sum - array[6];



    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    if (d > max) max = d;
    if (e > max) max = e;
    if (f > max) max = f;
    if (g > max) max = g;

    int numeroMinore = sum - max;
    Console.WriteLine("il numero minore è: " + numeroMinore);
    return numeroMinore;
}

