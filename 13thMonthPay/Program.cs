//Welcome message
Console.WriteLine("13th Month Pay");
Console.WriteLine("--------------");

bool runAgain = true;

while (runAgain)
{
    Console.WriteLine();

    //Get user inputs
    Console.Write("Enter your monthly basic salary: ");
    bool isValidSalary = decimal.TryParse(Console.ReadLine(), out decimal salary);

    Console.Write("In a year, how many months you have worked? ");
    bool isValidMonth = int.TryParse(Console.ReadLine(), out int monthsWorked);

    bool areValidInputs = isValidSalary && isValidMonth;

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
        decimal thirteenthMonthPay = (salary / 12) * monthsWorked;
        Console.WriteLine($"Your 13th month pay is {thirteenthMonthPay.ToString("N")}");

        //Ask to run again
        Console.WriteLine();
        Console.Write("Enter \"yes\" to run again: ");
        string? answer = Console.ReadLine();

        if (answer?.ToLower() == "yes")
        {
            runAgain = true;
        }
        else
        {
            runAgain = false;
        }
    }
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();