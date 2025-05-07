using Task2.Models;

// Boat Class
public class Boat : Vehicle
{
    public override void DisplayInfo()
    {
        Console.WriteLine("I'm a boat and I do not have wheels :(");
    }
}
