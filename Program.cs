using System;

//Goal 1 - Create a database of the different parkings lots and streets we wish to use within our program.
//Goal 2 - Create a program that marks the percentages of parking lots in regard to how full they are.
//Goal 3 - Locations
//Goal 4 - User Login Features
//Goal 5 - Information attached to each parking lot, nearby businesses and food places.

namespace tigerhacks{

    class Program
    {
        static void Main(string[] args)
    {
        string location = "";
        Console.WriteLine("Where are you parking today? Type the name of one of the parking lots below!");
        Console.WriteLine("");
        string[] parkinglots = { "Virginia Ave", "Conley", "10th & Cherry", "Hitt Street", "Turner Ave", "5th & Walnut", "Short Street Garage", "8th & Cherry", "6th & Cherry", "8th & Walnut", "UM Hospital", "William Street Garage", "UM Lot A", "UM Lot AV8", "UM Lot AV11", "UM Lot G", "Lot J"};
        List<string> lotsRange = new List<string>(parkinglots);

        Console.WriteLine(String.Join("\n", parkinglots));

        location = Console.ReadLine();

        Console.WriteLine("You have selected {0} as your parking spot!", location);

        string fileName = location.ToLower();

        

        Console.WriteLine(fileName);
        
    }
}
}