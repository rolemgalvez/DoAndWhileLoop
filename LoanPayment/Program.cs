//Welcome message
Console.WriteLine("Loan Payment");
Console.WriteLine("------------");

bool runAgain;

do
{
    Console.WriteLine();
    runAgain = false;
    decimal accumulatedPayment = 0;
    int monthNumber = 0;

    //Get user input
    Console.Write("Enter total loan: ");
    bool isValidTotalLoan = decimal.TryParse(Console.ReadLine(), out decimal totalLoan);

    Console.Write("Enter amount of monthly payment: ");
    bool isValidMonthlyPayment = decimal.TryParse(Console.ReadLine(), out decimal monthlyPayment);

    bool areValidInputs = isValidTotalLoan && isValidMonthlyPayment;

    if (areValidInputs == false)
    {
        Console.WriteLine();
        Console.WriteLine("You've entered an invalid input(s).");
        runAgain = true;
    }

    //Process results
    if (areValidInputs)
    {
        Console.WriteLine();
        Console.WriteLine("Your acummulated payments are as follows:");
        do
        {
            if ((accumulatedPayment + monthlyPayment) >= totalLoan)
            {
                accumulatedPayment = totalLoan;
            }
            else
            {
                accumulatedPayment += monthlyPayment;
            }

            monthNumber++;
            Console.WriteLine($"Month {monthNumber}: {accumulatedPayment.ToString("N")}");

        } while (accumulatedPayment != totalLoan);
    }
} while (runAgain);

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();