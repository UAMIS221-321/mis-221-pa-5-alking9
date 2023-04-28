using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class MainMenu
{
    // System.Console.WriteLine(@"");
    TrainerUtility trainerUtility;
    Reports Reports = new Reports();
     public MainMenu(TrainerUtility trainerUtility){
            this.trainerUtility = trainerUtility;
        } 
     public void HeadMenu(){
            TrainerUtility.GetTrainers();
            Reports.PrintAllTrainers();
            System.Console.WriteLine("1. Manage trainer data");
            System.Console.WriteLine("2. Manage listing data");
            System.Console.WriteLine("3. Manage customer booking data");
            System.Console.WriteLine("4. Run Reports");
            System.Console.WriteLine("5. Exit the application");
            string userInput = Console.ReadLine();
            Console.Clear();

            if(userInput == "1"){
                TrainingMenu();

            }
            if(userInput == "2"){
                ListingMenu();
            }
            if(userInput == "3"){
                BookingMenu();
            }
            if(userInput == "4"){
                
            }
            if(userInput == "5"){
                
            }
        }

    public void TrainingMenu(){
            TrainerUtility.GetTrainers();
            // TrainerUtility.GetAllTrainersFromFile();
            Reports.PrintAllTrainers();
            
            System.Console.WriteLine("1. Add a trainer");
            System.Console.WriteLine("2. Edit a trainer");
            System.Console.WriteLine("3. Delete a trainer");
            System.Console.WriteLine("4. Go back to main menu");

            string userInput = Console.ReadLine();

            if(userInput == "1"){
                trainerUtility.AddUrTrainer();

            }
            else if(userInput == "2"){
                TrainerUtility.EditTrainer();
            }
            else if(userInput == "3"){
                TrainerUtility.DeleteTrainer();
            }
            else if(userInput == "4"){
                HeadMenu();
            }
            else{
                System.Console.WriteLine("Invalid Input");
            }
        }

     public void ListingMenu(){
            ListingUtility.GetListings();
            ListingUtility.GetAllListingsFromFile();
            Reports.PrintAllListings();
            System.Console.WriteLine("1. Add a Listing");
            System.Console.WriteLine("2. Edit a Listing");
            System.Console.WriteLine("3. Delete a Listing");
            System.Console.WriteLine("4. Go back to main menu");
            string userInput = Console.ReadLine();

            if(userInput == "1"){
                ListingUtility.AddListing();
            }
            else if(userInput == "2"){
                ListingUtility.EditListing();
            }
            else if(userInput == "3"){
                ListingUtility.DeleteListing();
            }
            else if(userInput == "4"){
                HeadMenu();
            }
            else{
                System.Console.WriteLine("Invalid Input");
            }
        }    
    
      public void BookingMenu(){
            System.Console.WriteLine("1. Book a session");
            System.Console.WriteLine("2. Cancel a Booking");
            System.Console.WriteLine("3. Go back to main menu");

            string userInput = Console.ReadLine();

            if(userInput == "1"){
                BookingUtility.AddBooking();
            }
            else if(userInput == "2"){
                BookingUtility.DeleteBooking();
            }
            else if(userInput == "3"){
                HeadMenu();
            }
            
            else{
                System.Console.WriteLine("Invalid Input");
            }

        }
    }
}