using System.Reflection;
using Task1.Entities;

// Homework 5 - Task 1
// Anonymous methods and Advanced LINQ

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n Task1 - Homework 5\n");
Console.ResetColor();

// 1. Filter all cars that have origin from Europe and print them in console.

Console.WriteLine("\n === Filter all cars that have origin from Europe and print them in console. === \n");

List<Car> europeanCars = CarsData.Cars
    .Where(car => car.Origin == "Europe")
    .ToList();

foreach (Car car in europeanCars)
{
    Console.WriteLine(car.Model);
}


// 2. Filter all cars that have more that 6 Cylinders not including 6
//    After that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0.
//    Join them in one result and print them in console.

Console.WriteLine("\n === Filter all cars that have more that 6 Cylinders not including 6 \n After that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0.\n Join them in one result and print them in console. === \n");

List<Car> moreThan6CylindersCars = CarsData.Cars
    .Where(c => c.Cylinders > 6)
    .ToList();

List<Car> fourCylindersHighHP = CarsData.Cars
    .Where(c => c.Cylinders == 4 && c.HorsePower > 110)
    .ToList();

List<Car> combinedCars = moreThan6CylindersCars
    .Concat(fourCylindersHighHP)
    .ToList();

foreach (Car car in combinedCars)
{
    Console.WriteLine(car.Model);
}


// 3. Count all cars based on their Origin and print the result in console. Example output "US 10 models\n Eu 15 Models";

Console.WriteLine("\n === Count all cars based on their Origin and print the result in console. Example output \"US 10 models\\n Eu 15 Models\" === \n");

List<string> carsByOrigin = CarsData.Cars
    .GroupBy(c => c.Origin)
    .Select(group => $"{group.Key} {group.Count()} models")
    .ToList();

foreach (string origin in carsByOrigin)
{
    Console.WriteLine(origin);
}

// 4. Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;

Console.WriteLine("\n === Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console === \n");

List<Car> highHorsePowerCars = CarsData.Cars
    .Where(c => c.HorsePower > 200 && c.MilesPerGalon > 0)
    .ToList();

if (highHorsePowerCars.Any())
{
    double minMpg = highHorsePowerCars.Min(c => c.MilesPerGalon);
    double maxMpg = highHorsePowerCars.Max(c => c.MilesPerGalon);
    double avgMpg = highHorsePowerCars.Average(c => c.MilesPerGalon);

    Console.WriteLine($"Min: {minMpg}, Max: {maxMpg}, Avg: {avgMpg:F2}");
}
else
{
    Console.WriteLine("No cars with HP > 200 and valid MPG.");
}

// 5. Find the top 3 fastest accelerating cars:
//    Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list. Print the model of each of these top 3 cars.

Console.WriteLine("\n=== Find the top 3 fastest accelerating cars:\n Order cars by their AccelerationTime in ascending order. Take the top 3 cars from the ordered list. Print the model of each of these top 3 cars.=== \n");
List<string> top3FastestCars = CarsData.Cars
    .OrderBy(c => c.AccelerationTime)
    .Take(3)
    .Select(c => c.Model)
    .ToList();

foreach (string model in top3FastestCars)
{
    Console.WriteLine(model);
}


// 6. Calculate the total weight of cars with more than 6 cylinders:
//    Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight.

Console.WriteLine("\n=== Calculate the total weight of cars with more than 6 cylinders: \n// Filter cars that have more than 6 cylinders. Calculate the total weight of these cars. Print the total weight. ===\n");

double totalWeight = CarsData.Cars
    .Where(c => c.Cylinders > 6)
    .Sum(c => c.Weight);

Console.WriteLine($"Total weight of cars with >6 cylinders: {totalWeight}");

// 7. Find the average MilesPerGalon for cars with even number of cylinders:
//    Filter cars that have an even number of cylinders. Calculate the average MilesPerGalon for these cars. Print the average MilesPerGalon.

Console.WriteLine("\n=== Find the average MilesPerGalon for cars with even number of cylinders: \nFilter cars that have an even number of cylinders. Calculate the average MilesPerGalon for these cars. Print the average MilesPerGalon. ===\n");
double avgMpgEvenCyl = CarsData.Cars
    .Where(c => c.Cylinders % 2 == 0 && c.MilesPerGalon > 0)
    .Average(c => c.MilesPerGalon);

Console.WriteLine($"Average MPG of cars with even cylinders: {avgMpgEvenCyl:F2}");

Console.ReadLine();
