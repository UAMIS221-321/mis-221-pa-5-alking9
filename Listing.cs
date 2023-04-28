using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class Listing
    {
        private int listingID;
        private string trainerName;
        private string dateOfSession;
        private string timeOfSession;
        private string costOfSession;
        private bool usableListing;
        private bool sessionTaken;
        static private int ID = 0;
        

        static private int count = 0;



            //no arg constructor
        public Listing()
        {

        } 

        public  Listing(string trainerName, string dateOfSession, string timeOfSession, string costOfSession, bool sessionTaken, bool usableListing){
            // paramter has been taken out also this.listingID = listingID;
            this.listingID = ID;
            ID++;
            this.trainerName = trainerName;
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.sessionTaken = sessionTaken;
            this.usableListing = usableListing;


        }

        public void SetListingID(int listingID){
            this.listingID = listingID;   
        }
        public int GetListingID(){
            return listingID;
        } 
        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }

        public string GetTrainerName(){
            return trainerName;
        } 
        public void SetDateOfSession(string dateOfSession){
            this.dateOfSession = dateOfSession;   
        }
        public string GetDateOfSession(){
            return dateOfSession;
        } public void SetTimeOfSession(string timeOfSession){
            this.timeOfSession = timeOfSession;   
        }
        public string GetTimeOfSession(){
            return timeOfSession;
        } public void SetCostOfSession(string costOfSession){
            this.costOfSession = costOfSession;   
        }
        public string GetCostOfSession(){
            return costOfSession;
        }
        public void SessionTaken(bool sessionTaken){
            this.sessionTaken = sessionTaken;
        }
        public void SessionNotTaken(bool sessionTaken){
            this.sessionTaken = false;
        }
        public bool GetSessionTaken(){
            return sessionTaken;
        }
        static public void SetCount(int count){
            ListingUtility.count = count;
        }
        static public void IncCount(){
            ListingUtility.count++;
        }
        static public int GetCount(){
            return count;
        }
        public void SetUsableListing(bool usableListing){
            this.usableListing = usableListing;
        }

        public void SetNotusableListing(bool usableListing){
            this.usableListing = false;
        }
        public bool GetUsableListing(){
            return usableListing;
        }

       public override string ToString()
        {
            return ($"Listing ID-- {listingID}. Trainer Name-- {trainerName}. Date of Session-- {dateOfSession}. Time of Session-- {timeOfSession}. Session In Use? {sessionTaken}. Cost of the Session-- {costOfSession}");
        }
        public string ToFile(){
            return $"{trainerName}#{dateOfSession}#{timeOfSession}#{costOfSession}#{sessionTaken}#{usableListing}";
        }
   
    }
}