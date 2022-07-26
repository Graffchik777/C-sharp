string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNamber = int.Parse(inputLine);

    //int outNumber = inputNamber*inputNamber;
    int outNumber = (int)Math.Pow(inputNamber,2);
    Console.WriteLine(outNumber);
}