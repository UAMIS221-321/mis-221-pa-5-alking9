using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class Booking
    {
      private int sessionID;
      private string customerName;
      private string customerEmail;
      private string trainingDate;
      private int trainerID;
      private string trainerName;

      private bool bookingStatus;


      static private int count = 0; 

      static private int ID;

    // no arg constructor
     public Booking(){

      }
    
    public Booking(int sessionID, string customerName, string customerEmail, string trainingDate, string trainerName, bool bookingStatus){
        this.sessionID = ID;
        ID++;
        this.customerName = customerName;
        this.customerEmail = customerEmail;
        this.trainingDate = trainingDate;
        this.trainerName = trainerName;
        this.bookingStatus = bookingStatus;
      }

    public void SetSessionID(int sessionID){
        this.sessionID = sessionID;
    }

    public int GetSessionID(){
        return sessionID;
    } 

    public void SetCustomerName(string customerName){
        this.customerName = customerName;
    } 

    public string GetCustomerName(){
        return customerName;
    }

    public void SetCustomerEmail(string customerEmail){
        this.customerEmail = customerEmail;
    }

    public string GetCustomerEmail(){
        return customerEmail;
    }

    public void SetTrainingDate(string trainingDate){
        this.trainingDate = trainingDate;
    }

    public string GetTrainingDate(){
        return trainingDate;
    }

    public void SetTrainerID(int trainerID){
        this.trainerID = trainerID;
    }

    public int GetTrainerID(){
        return trainerID;
    }

    public void SetTrainerName(string trainerName){
        this.trainerName = trainerName;
    }

    public string GetTrainerName(){
        return trainerName;
    }

    static public void SetCount(int count){
        Booking.count = count;
    }

    static public void IncCount(){
        Booking.count++;
    }
    static public int GetCount(){
        return count;
    }

    public void BookingStatus(bool bookingStatus){
        this.bookingStatus = bookingStatus;
    }

    public void NotBookableStatus(bool bookingStatus){
        this.bookingStatus = false;
    }

    public bool GetBookingStatus(){
        return bookingStatus;
    }

    public override string ToString()
        {
            return $"Session ID: {sessionID} Customer Name: {customerName} Customer Email: {customerEmail} Training Date: {trainingDate}, Trainer Name: {trainerName} Booking Status: {bookingStatus}";
        }

    public string ToFile(){
        return $"{sessionID}#{customerName}#{customerEmail}#{trainingDate}#{trainerName}#{bookingStatus}";
    }
    }
}