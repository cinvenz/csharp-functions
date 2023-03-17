var numbers = new int[] { 2, 4, 5, 9, 3, 1, };

StampaArray(numbers);

void StampaArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write("elemento " + number + ", ");
    }
}