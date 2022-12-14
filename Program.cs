using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace tigerhacks{

    class Program
    {
        static void Main(string[] args){

            string choice = "test";
            Console.WriteLine("======================================================================");
            Console.WriteLine("");
            Console.WriteLine("Select 1 For Parking Lot Information, or Select 2 if you are Parking.");
            Console.WriteLine("");
            Console.WriteLine("======================================================================");
            choice = Console.ReadLine();
            

            if(choice == "2"){

                string location = getLocation();
                string percentage = getPercentages();

                writeToData(location,percentage);

            }

            if(choice == "1"){
                string location = getLocation();
                getArray(location);
            }



        
        }

        static string getLocation(){
            string lotLocation = "";
            
            while(true){
                string location = "";
                Console.WriteLine("======================================================================");
                Console.WriteLine("");
                Console.WriteLine("Where are you parking today? Type the name of one of the parking lots below!");
                Console.WriteLine("");
                Console.WriteLine("======================================================================");
                string[] parkinglots = { "Virginia Ave", "Conley", "10th & Cherry", "Hitt Street", "Turner Ave", "5th & Walnut", "Short Street Garage", "8th & Cherry", "6th & Cherry", "8th & Walnut", "UM Hospital", "William Street Garage", "UM Lot A", "UM Lot AV8", "UM Lot AV11", "UM Lot G", "Lot J"};
                List<string> lotsRange = new List<string>(parkinglots);
                Console.WriteLine(String.Join("\n", parkinglots));
                Console.WriteLine("======================================================================");
                Console.WriteLine("");
                location = Console.ReadLine();
                
                lotsRange = lotsRange.ConvertAll(d => d.ToLower());
                lotLocation = location.ToLower();

                if(lotsRange.Contains(lotLocation) == false){
                    Console.WriteLine("Error: Please enter a parking lot on the List!");
                    continue;
                }else{
                    Console.WriteLine("======================================================================");
                    Console.WriteLine("");
                    Console.WriteLine("You have selected {0} as your parking spot!", lotLocation);
                    Console.WriteLine("");

                    break;
                }


    }
            return addTxt(lotLocation);
    }

    static string addTxt(string FileName){
        return FileName+ ".txt";
    }

        static string getPercentages(){
            string userPercent;

            while(true){
                string percent;
            
                Console.WriteLine("");
                Console.WriteLine("On a scale of 0% to 100%, how full does the parking lot seem to you?");
                Console.WriteLine("");
                Console.WriteLine("======================================================================");
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
                    
                    Console.WriteLine("======================================================================");
                    Console.WriteLine("");
                    Console.WriteLine("You have estimated your parking lot to be {0}% full!", userPercent);
                    Console.WriteLine("");
                    break;
                }
            }
                
                return userPercent;
        }

        static void writeToData (string FileName, string percentage){

            var text = File.ReadAllText(FileName);  
            var textArray = text.Split(" ");
            text = String.Join(" ", textArray);

            StreamWriter sw = new StreamWriter(FileName, true);
            try{
                sw.WriteLine(percentage);
                sw.Close();
            }catch(Exception err){
                Console.WriteLine("Exception: " + err.Message);
            }finally{
                if (sw != null){
                    sw.Close();
                }
                
                Console.WriteLine("");
                Console.WriteLine("Parking data was successfully saved.");
                Console.WriteLine("");
                Console.WriteLine("======================================================================");
            }

        }

    static void getArray (string FileName){


    string fileContents = File.ReadAllText(FileName);
            string newline = '\r'.ToString() + '\n'.ToString();
            fileContents = fileContents.Replace(newline, '\n'.ToString());  
            
    string[] array = fileContents.Split(new char[] {'\n'});
            int[] intArray = new int[array.Length];
            for(int i = 0; i < intArray.Length; i++)
            {
                int.TryParse(array[i], out intArray[i]);
            }
            
    double avg = Queryable.Average(intArray.AsQueryable());
    

    Console.WriteLine("======================================================================");
    Console.WriteLine("");
    Console.WriteLine("This lot is estimated to be {0:0.00}% full!", avg);
    Console.WriteLine("");
    Console.WriteLine("======================================================================");
        


        
    

    

    }}}

    

