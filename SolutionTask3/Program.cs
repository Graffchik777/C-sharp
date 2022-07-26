string? inputLkneOne = Console.ReadLine();

if(inputLkneOne != null)
{
    int inputNamber = int.Parse(inputLkneOne);

    int startNamber = (inputNamber * -1);

    string lineOutput = "";

    while (startNamber < inputNamber)
    {
        lineOutput = lineOutput + startNamber + ", ";
        startNamber++;
    }

    lineOutput = lineOutput + inputNamber;
 Console.WriteLine(lineOutput);
}