 string? inputEgLineOne = Console.ReadLine();
 string? inputEgLineTwo = Console.ReadLine();

if(inputEgLineOne != null && inputEgLineTwo != null)
{
    int inputLine1 = int.Parse(inputEgLineOne);
    int inputLine2 = int.Parse(inputEgLineTwo);

    if(inputLine1 > inputLine2) 
    {
    Console.WriteLine(inputEgLineOne);
    }
    else
    {
      Console.WriteLine(inputEgLineTwo);  
    }
}