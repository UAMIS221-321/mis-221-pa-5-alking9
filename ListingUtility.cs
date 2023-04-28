using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class ListingUtility
    {



    public ListingUtility(){
        
    }        
        // private Listing [] listings = new Listing[];

        // static int MAXID_COUNT = 100;
         private static int MAX_LISTING_SIZE = 100;
        private static Listing[] listings = new Listing[MAX_LISTING_SIZE];

        // public ListingUtility(Listing [] listings){
        //     this.listings = listings;
        // }
        static public int count;

        static public void SetCount(int count){
            ListingUtility.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            ListingUtility.count++;
        }

        static public void AddListing(){
            System.Console.WriteLine("Please enter your trainers ID");
            Listing newList = new Listing();
            newList.SetListingID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter your trainer name");
            newList.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the date of session");
            newList.SetDateOfSession(Console.ReadLine());
            System.Console.WriteLine("Please enter the time of your session");
            newList.SetTimeOfSession(Console.ReadLine());
            System.Console.WriteLine("Please enter the cost of session");
            newList.SetCostOfSession(Console.ReadLine());
            newList.SetUsableListing(true);
            newList.SessionNotTaken(true);
            listings[ListingUtility.GetCount()] = newList;
            ListingUtility.IncCount();

            SaveUrListing();

        }

    

        public static void SaveUrListing(){
            //open file
            StreamWriter outFile = new StreamWriter("listing.txt");

            for(int i = 0; i < ListingUtility.GetCount(); i++){
                outFile.WriteLine(listings[i].ToFile());
            }
            outFile.Close();
        }

        static public int FindListing(string searchVal){
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetListingID() == int.Parse(searchVal)){
                    return i;
                }
            }
            return -1;
        }

        static public void EditListing(){
            System.Console.WriteLine("What is the listing ID");
            string searchval = Console.ReadLine();
            int foundIndex = FindListing(searchval);

            if(foundIndex != -1){
                System.Console.WriteLine("Please enter the trainer name");
                listings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the date of the session");
                listings[foundIndex].SetDateOfSession(Console.ReadLine());
                System.Console.WriteLine("Please enter the time of the session");
                listings[foundIndex].SetTimeOfSession(Console.ReadLine());
                System.Console.WriteLine("Please enter the cost of the session");
                listings[foundIndex].SetCostOfSession(Console.ReadLine());
                System.Console.WriteLine("Enter 1 if the session is available. Enter 2 if the session is unavailable.");
                string userInput = Console.ReadLine();
                if(userInput == "1"){
                    listings[foundIndex].SessionNotTaken(true);
                }
                if(userInput == "2"){
                    listings[foundIndex].SessionTaken(true);
                }

                SaveUrListing();
            }
            else{
                System.Console.WriteLine("Listing not found!");
            }
        }

        static public void DeleteListing(){
            System.Console.WriteLine("Which listing would you like to delete?");
            string searchVal = Console.ReadLine();

            int foundIndex = FindListing(searchVal);

            if(foundIndex != -1){
                listings[foundIndex].SetNotusableListing(true);
                SaveUrListing();
            }
            else{
                System.Console.WriteLine("Invalid trainer :/");
            }
        }

        public static void GetAllListingsFromFile(){
                   StreamReader inFile = new StreamReader("listing.txt");

                    //process
                    ListingUtility.SetCount(0);

                    string line = inFile.ReadLine();
                    while(line != null && line != ""){
                        string[] temp = line.Split('#');
                        listings[ListingUtility.GetCount()] = new Listing((temp[0]), temp[1], (temp[2]), ((temp[3])), bool.Parse(temp[4]), bool.Parse(temp[5])); 
                        line = inFile.ReadLine();
                        ListingUtility.IncCount();
            
                    }
                    inFile.Close();
            }

            
        public static Listing[] GetListings()
        {
             return listings;
       }
    }
}
