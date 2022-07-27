// string? inputOne = Console.ReadLine();

// if(inputOne != null)
// {
//     int inputNamber = int.Parse(inputOne);
//     int chetNamber = int.Parse(inputOne);
//     int startNamber = (1);

//     string lineOutput = "";
    
//         if(chetNamber%2 == 0)
//     lineOutput = startNamber + chetNamber + ", ";
//         startNamber++;
    
//          while (chetNamber < inputNamber)
        
    
//     lineOutput = lineOutput + chetNamber;
//  Console.WriteLine(lineOutput);
// }

foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1))
Console.WriteLine(i << 1);