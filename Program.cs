string? readResult;
string stringValue = "";
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter a number from 5 to 10");

do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        stringValue = readResult;
    }
    validNumber = int.TryParse(stringValue, out numericValue);
    if (validNumber == true)
    {
        if (numericValue <= 5 || numericValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
        }else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    }

} while (validNumber == false);