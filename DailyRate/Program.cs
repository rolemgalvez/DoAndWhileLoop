//Welcome message
Console.WriteLine("Daily Rate");
Console.WriteLine("----------");

bool runAgain = true;
while(runAgain)
{
    Console.WriteLine();

    //Get user input
    Console.Write("Enter monthly basic salary: ");
    bool isValidSalary = decimal.TryParse(Console.ReadLine(), out decimal salary);

    Console.Write("What factor rate are you using (days of work per year)? ");
    bool isValidFactorRate = decimal.TryParse(Console.ReadLine(), out decimal factorRate);

    bool areValidInputs = isValidSalary && isValidFactorRate;

    //Process results
    if (areValidInputs == false)
    {
        Console.WriteLine();
        Console.WriteLine("You've entered an invalid input. Try again.");
        runAgain = true;
    }

    if (areValidInputs)
    {
        Console.WriteLine();
        decimal dailyRate = (salary * 12) / factorRate;
        Console.WriteLine($"Your daily rate is {dailyRate.ToString("N")}.");

        Console.WriteLine();
        Console.Write("Enter \"yes\" to do computation again: ");
        runAgain = Console.ReadLine()?.ToLower() == "yes";
    }
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();