string? readResult;
string roleName = "";
bool validEntry = false;

do
{

    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        roleName = readResult.Trim();
    }
    if (roleName.Equals("administrator") || roleName.Equals("manager") || roleName.Equals("user"))
    {
        validEntry = true;
    }
      else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);