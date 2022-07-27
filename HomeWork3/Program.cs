string? inputLine = Console.ReadLine();

 if(inputLine != null)
{
int inputNamber = int.Parse(inputLine);

    int lineOutputNamber = inputNamber%2;
    if(inputNamber%2 == 0)

    Console.WriteLine("Четное");
    else 
    {
        Console.WriteLine("Не четное");
    }
}