using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class BookingUtility
    {
         private static Booking [] bookings = new Booking[MAXID_COUNT];

        static int MAXID_COUNT = 100;

       
        static public int count;

        static public void SetCount(int count){
            BookingUtility.count = count;
        }

        static public int GetCount(){
            return count;
        }

        static public void IncCount(){
            BookingUtility.count++;
        }

        static public void AddBooking(){
            System.Console.WriteLine("Please enter your session ID");
            Booking newSession = new Booking();
            newSession.SetSessionID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter your name");
            newSession.SetCustomerName(Console.ReadLine());
            System.Console.WriteLine("Please enter your email");
            newSession.SetCustomerEmail(Console.ReadLine());
            System.Console.WriteLine("Please enter the the date of the training session");
            newSession.SetTrainingDate(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainers ID");
            newSession.SetTrainerID(int.Parse(Console.ReadLine()));
            System.Console.WriteLine("Please enter the trainers name");
            newSession.SetTrainerName(Console.ReadLine());
            newSession.BookingStatus(true);

            bookings[BookingUtility.GetCount()] = newSession;
            BookingUtility.IncCount();

            SaveUrBooking();

        }

    

        public static void SaveUrBooking(){
            //open file
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < BookingUtility.GetCount(); i++){
                outFile.WriteLine(bookings[i].ToFile());
            }
            outFile.Close();
        }

        public static int FindBookings(string searchVal){
            for(int i = 0; i < BookingUtility.GetCount(); i++){
                if(bookings[i].GetSessionID() == int.Parse(searchVal)){
                    return i;
                }
            }
            return -1;
        }

        public void EditBooking(){
            System.Console.WriteLine("What is the session ID");
            string searchval = Console.ReadLine();
            int foundIndex = FindBookings(searchval);

            if(foundIndex != -1){
                System.Console.WriteLine("Please enter your name");
                bookings[foundIndex].SetCustomerName(Console.ReadLine());
                 System.Console.WriteLine("Please enter your email");
                bookings[foundIndex].SetCustomerEmail(Console.ReadLine());
                System.Console.WriteLine("Please enter your trainer name");
                bookings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the date of the training session");
                bookings[foundIndex].SetTrainingDate(Console.ReadLine());
               
                
                System.Console.WriteLine("Enter 1 if the booking status is available. Enter 2 if the booking status is unavailable.");
                string userInput = Console.ReadLine();
                if(userInput == "1"){
                    bookings[foundIndex].BookingStatus(true);
                }
                if(userInput == "2"){
                    bookings[foundIndex].NotBookableStatus(true);
                }

                SaveUrBooking();
            }
            else{
                System.Console.WriteLine("Listing not found!");
            }
        }

        static public void DeleteBooking(){
            System.Console.WriteLine("Which session would you like to delete?");
            string searchVal = Console.ReadLine();

            int foundIndex = FindBookings(searchVal);

            if(foundIndex != -1){
                bookings[foundIndex].NotBookableStatus(true);
                SaveUrBooking();
            }
            else{
                System.Console.WriteLine("Invalid trainer :/");
            }
        }

        public void GetAllBookingsFromFile(){
                   StreamReader inFile = new StreamReader("transactions.txt");

                    //process
                    BookingUtility.SetCount(0);

                    string line = inFile.ReadLine();
                    while(line != null && line != ""){
                        string[] temp = line.Split('#');
                        bookings[BookingUtility.GetCount()] = new Booking(int.Parse(temp[0]), (temp[1]), (temp[2]), (temp[3]), (temp[4]), bool.Parse(temp[5])); 
                        line = inFile.ReadLine();
                        BookingUtility.IncCount();
                    }
                    inFile.Close();
            }
    }
    }
