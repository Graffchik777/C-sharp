string? inputlkeOne = Console.ReadLine();
string? inputlkeTwo = Console.ReadLine();

if(inputlkeOne != null && inputlkeTwo != null)
{
    int inputNamberOne = int.Parse(inputlkeOne);
    int inputNamberTwo = int.Parse(inputlkeTwo);

    if(inputNamberOne == inputNamberTwo * inputNamberTwo)
    // {
    //    Console.WriteLine ("yes");
    // }
    //        else{
    //            Console.WriteLine("No");
    //        }}

    if(inputNamberTwo == Math.Sqrt(inputNamberOne))
    {
        Console.WriteLine ("yes");
    }
    else {
        Console.WriteLine("no");
    }
}