
string? firstName;
bool isInvalid;
int dumb;

List<string> firstNames = new List<string>();

do
{
    Console.Write("Add a first name (or exit): ");

    firstName = Console.ReadLine();

    isInvalid = int.TryParse(firstName, out dumb);

    if (isInvalid || string.IsNullOrEmpty(firstName)) Console.WriteLine("Please enter a valid name");

    if (!isInvalid && firstName != "exit" && !string.IsNullOrEmpty(firstName)) firstNames.Add(firstName);

    if (firstName == "exit")
    {
        foreach (string name in firstNames)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }

} while (firstName != "exit");

