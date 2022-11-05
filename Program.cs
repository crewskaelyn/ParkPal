using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace tigerhacks{

    class Program
    {
        static void Main(string[] args){




            string location = getLocation();
            string percentage = getPercentages();

            writeToData(location,percentage);


        
        }

        static string getLocation(){
            string lotLocation = "";
            
            while(true){
                string location = "";
                Console.WriteLine("Where are you parking today? Type the name of one of the parking lots below!");
                Console.WriteLine("");
                string[] parkinglots = { "Virginia Ave", "Conley", "10th & Cherry", "Hitt Street", "Turner Ave", "5th & Walnut", "Short Street Garage", "8th & Cherry", "6th & Cherry", "8th & Walnut", "UM Hospital", "William Street Garage", "UM Lot A", "UM Lot AV8", "UM Lot AV11", "UM Lot G", "Lot J"};
                List<string> lotsRange = new List<string>(parkinglots);
                Console.WriteLine(String.Join("\n", parkinglots));
                location = Console.ReadLine();
                lotsRange = lotsRange.ConvertAll(d => d.ToLower());
                lotLocation = location.ToLower();

                if(lotsRange.Contains(lotLocation) == false){
                    Console.WriteLine("Error: Please enter a parking lot on the List!");
                    continue;
                }else{
                    Console.WriteLine("You have selected {0} as your parking spot!", lotLocation);
                    break;
                }


    }
            return lotLocation;
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

        static void writeToData (string location, string percentage){

            StreamWriter sw = new StreamWriter("parkingData.txt", true);
            try{
                sw.WriteLine(location);
                sw.WriteLine(percentage);
                sw.Close();
            }catch(Exception err){
                Console.WriteLine("Exception: " + err.Message);
            }finally{
                if (sw != null){
                    sw.Close();
                }
                Console.WriteLine($"\n{"parkingData.txt"} was successfully saved.");
            }
        }
    

    

    }

    
}
