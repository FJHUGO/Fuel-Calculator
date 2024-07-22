class Program
{
    static void Main()
    {
        // Average fuel consumption in liters per 100km
        double avgFuelConsumption = 7;

        Console.Write("Enter the distance you plan to drive in kilometers: ");
        string distanceInput = Console.ReadLine();

        Console.Write("Enter the current cost of fuel per liter: ");
        string costInput = Console.ReadLine();

        if (double.TryParse(distanceInput, out double distance) && double.TryParse(costInput, out double cost))
        {
            // Calculate the fuel consumption
            double fuelNeeded = Math.Ceiling(((distance / 100) * avgFuelConsumption) * 100) / 100;
            // Calculate the total cost
            double totalCost = Math.Ceiling((fuelNeeded * cost) * 100) / 100;

            Console.WriteLine($"\nThe average fuel needed for {distance} kilometers is {fuelNeeded} liters.");
            Console.WriteLine($"The total cost of fuel will be {totalCost}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
    }
}
