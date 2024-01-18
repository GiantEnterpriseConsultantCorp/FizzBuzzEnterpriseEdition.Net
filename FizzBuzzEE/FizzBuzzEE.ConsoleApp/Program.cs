Enumerable
    .Range(1, 100)
    .ToList()
    .ForEach(x => 
        Console.WriteLine(
            x % 15 == 0 
                ? "FizzBuzz" 
                : x % 3 == 0 
                    ? "Fizz" 
                    : x % 5 == 0 
                        ? "Buzz" 
                        : x));
