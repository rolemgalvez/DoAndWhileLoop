//Welcome message
Console.WriteLine("Compounding Interest");
Console.WriteLine("--------------------");

bool runAgain;

do
{
    Console.WriteLine();
    runAgain = false;

    Console.Write("Enter current balance: ");
    bool isValidCurrentBalance = decimal.TryParse(Console.ReadLine(), out decimal currentBalance);

    Console.Write("Enter daily interest rate: ");
    bool isValidInterestRate = decimal.TryParse(Console.ReadLine(), out decimal interestRate);

    Console.Write("Enter number of days to show: ");
    bool isValidDaysNumber = int.TryParse(Console.ReadLine(), out int daysNumber);

    bool areValidInputs = isValidCurrentBalance && isValidInterestRate && isValidDaysNumber;

    if (areValidInputs == false)
    {
        Console.WriteLine();
        Console.WriteLine("You've entered an invalid input(s). Try again.");
        runAgain = true;
    }

    if (areValidInputs)
    {
        Console.WriteLine();
        decimal amountEarned = 0;
        decimal updatedBalance = currentBalance;
        int currentDay = 1;
        do
        {
            amountEarned = (1.00M / 365.00M) * (interestRate / 100) * updatedBalance;
            updatedBalance = updatedBalance + amountEarned - (amountEarned * 0.20M);
            Console.WriteLine($"Day {currentDay}: {updatedBalance.ToString("N")}");
            currentDay++;
            daysNumber--;
        } while (daysNumber > 0);
    }
} while (runAgain);

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();