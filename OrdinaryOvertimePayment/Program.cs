//Welcome message
Console.WriteLine("Ordinary Overtime Payment");
Console.WriteLine("-------------------------");

bool runAgain = true;
while(runAgain)
{
    Console.WriteLine();

    //Get user input
    Console.WriteLine("Considering 261 is your factor rate and 8 hours work per day...");
    Console.Write("Enter monthly basic salary: ");
    bool isValidSalary = decimal.TryParse(Console.ReadLine(), out decimal salary);

    Console.Write("How many overtime minutes you've worked? ");
    bool isValidOvertime = decimal.TryParse(Console.ReadLine(), out decimal overtime);

    bool areValidInputs = isValidSalary && isValidOvertime;

    //Process results
    if (areValidInputs == false)
    {
        Console.WriteLine();
        Console.WriteLine("You've entered an invalid input. Try again.");
        runAgain = true;
    }

    if (areValidInputs)
    {
        decimal hourlyRate = (salary * 12) / 261 / 8;
        decimal payment = hourlyRate * 1.25M * (overtime/60);
        Console.WriteLine();
        Console.WriteLine($"Your overtime payment is {payment.ToString("N")}.");

        Console.WriteLine();
        Console.Write("Enter \"yes\" to compute again: ");
        runAgain = Console.ReadLine()?.ToLower() == "yes";
    }
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();