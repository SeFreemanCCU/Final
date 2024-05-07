while (true)
{
    Console.WriteLine("Please input your birthday in the form mm/dd/yyyy.");
    var response = Console.ReadLine();
    if (DateTime.TryParse(response, out var birthday))
    {
        var days = (DateTime.Now - birthday).TotalDays;
        Console.WriteLine($"You are {(int)days} days old.");
        break;
    }
    else
    {
        Console.WriteLine("Please input a valid date.");
    }
}