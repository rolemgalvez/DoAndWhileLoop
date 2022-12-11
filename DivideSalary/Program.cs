//Welcome message
Console.WriteLine("Divide Salary");
Console.WriteLine("-------------");

bool areValidInputs;
bool runAgain = false;
do
{
    //Get user input
    Console.WriteLine();
    Console.Write("Enter salary: ");
    string? salaryText = Console.ReadLine();
    bool isValidSalary = decimal.TryParse(salaryText, out decimal salary);

    Console.Write("Enter number of times to divide it: ");
    string? divisorText = Console.ReadLine();
    bool isValidDivisor = decimal.TryParse(divisorText, out decimal divisor);

    areValidInputs = isValidSalary && isValidDivisor;

    //Process results
    Console.WriteLine();
    if (areValidInputs == false)
    {
        Console.WriteLine("Make sure to enter valid input.");
        runAgain = true;
    }

    if (divisor <= 0)
    {
        Console.WriteLine("Divisor should be greater than 0.");
        runAgain = true;
    }

    if (areValidInputs && divisor > 0)
    {
        decimal quotient = salary / divisor;
        string output = $"{salary.ToString("N")} / {divisor.ToString("N")} = {quotient.ToString("N")}";
        Console.WriteLine(output);

        //Ask to rerun program
        Console.WriteLine();
        Console.Write("Enter \"yes\" to compute again: ");
        runAgain = Console.ReadLine()?.ToLower() == "yes";
    }

} while (areValidInputs == false || runAgain);

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();