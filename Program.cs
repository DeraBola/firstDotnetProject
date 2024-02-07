 for (int i = 1; i <= 100; i++)
{
    int count = i;

    if ((count % 5 == 0 ) && (count % 3 == 0))
        Console.WriteLine($"{count} - FizzBuzz");
    else if (count % 3 == 0)
        Console.WriteLine($"{count} - Fizz");
    else if (count % 5 == 0)
        Console.WriteLine($"{count} - Buzz");
    else
        Console.WriteLine($"{count}");
}


// for (int i = 1; i < 101; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }