using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

//Goal 1 - Create a database of the different parkings lots and streets we wish to use within our program.
//Goal 2 - Create a program that marks the percentages of parking lots in regard to how full they are.
//Goal 3 - Locations
//Goal 4 - User Login Features
//Goal 5 - Information attached to each parking lot, nearby businesses and food places.

namespace tigerhacks{

    class Program
    {
        static void Main(string[] args){
            string location = getLocation();
            string percentage = getPercentages();

            Console.WriteLine(percentage);
        

        
        }

        static string getLocation(){
            string fileName = "";
            
            while(true){
                string location = "";
                Console.WriteLine("Where are you parking today? Type the name of one of the parking lots below!");
                Console.WriteLine("");
                string[] parkinglots = { "Virginia Ave", "Conley", "10th & Cherry", "Hitt Street", "Turner Ave", "5th & Walnut", "Short Street Garage", "8th & Cherry", "6th & Cherry", "8th & Walnut", "UM Hospital", "William Street Garage", "UM Lot A", "UM Lot AV8", "UM Lot AV11", "UM Lot G", "Lot J"};
                List<string> lotsRange = new List<string>(parkinglots);
                Console.WriteLine(String.Join("\n", parkinglots));
                location = Console.ReadLine();
                lotsRange = lotsRange.ConvertAll(d => d.ToLower());
                fileName = location.ToLower();

                if(lotsRange.Contains(fileName) == false){
                    Console.WriteLine("Error: Please enter a parking lot on the List!");
                    continue;
                }else{
                    Console.WriteLine("You have selected {0} as your parking spot!", fileName);
                    break;
                }


    }
            return setName(fileName);
    }

        static string setName(string locationName){
            return locationName + ".txt";
    }

        static string getPercentages(){
            string userPercent;

            while(true){
                string percent;
                Console.WriteLine("On a scale of 0% to 100%, full does the parking lot seem to you?");
                Console.WriteLine("");
                percent = Console.ReadLine();

                if(percent.EndsWith("%")){
                    userPercent = percent.Remove(percent.Length - 1, 1);
                    continue;
                }else{
                    userPercent = percent;
                    break;
                }

                

            }

            while(true){
                var test = int.Parse(userPercent);

                var percentList = Enumerable.Range(0, 100).ToList();
                if(percentList.Contains(test) == false){
                    Console.WriteLine("Error: Please enter a number from 0-100!");
                    continue;
                }else{
                    Console.WriteLine("You have estimated your parking lot to be {0}% full!", userPercent);
                    break;
                }
            }
                
                return userPercent;
    }

    }

    
}
