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
            string[] lots = { "lot1", "lot2" };
            var myLinqQuery = from lot in lots
                    where lot.Contains('a')
                    select lot;

            foreach (var lot in myLinqQuery){
                Console.WriteLine(lot);
        }
    }
}
}