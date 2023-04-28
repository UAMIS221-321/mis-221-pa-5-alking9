using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mis_221_pa_5_alking9
{
    public class Trainer
    {
       private int trainerID = 0; 
        private string trainerName;

        private string mailingAddress;
        private string emailAddress;
        private bool enlistTrainer;


        static private int count;
        
        //no arg constructor
        public Trainer(){

        }
        //arg constructor
        public Trainer( int trainerID, string trainerName, string mailingAddress, string emailAddress, bool enlistTrainer){
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.emailAddress = emailAddress;
            this.enlistTrainer = enlistTrainer;
        }

        public void SetTrainerId(int trainerID){
            this.trainerID = trainerID;
        }
        public int GetTrainerID(){
            return trainerID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }
        public string GetTrainerName(){
            return trainerName;
        }

         public void SetMailingAddress(string mailingAddress)
        {
            this.mailingAddress = mailingAddress;
        }
        public string GetMailingAddress(){
            return mailingAddress;
        }
         public void SetEmailAddress(string emailAddress){
            this.emailAddress = emailAddress;
        }
        public string GetEmailAddress(){
            return emailAddress;
        }

    //    static public void SetCount(int count){
    //         Trainer.count = count;
    //     }

    //     static public void IncCount(){
    //         Trainer.count++;
    //     }
    //     static public int GetCount(){
    //         return count;
    //     }

        public void SetEnlistTrainer(bool enlistTrainer){
            this.enlistTrainer = true;
        }

        public void SetNotEnlistTrainer(bool enlistTrainer){
            this.enlistTrainer = false;
        }

        public bool GetEnlistTrainer(){
            return enlistTrainer;
        }
        public override string ToString()
        {
            return $"ID--{trainerID}. Trainer Name-- {trainerName}. Emaling Address-- {emailAddress}. Mailing Address-- {mailingAddress}, Trainer Added? True/False: {enlistTrainer}.";
        }

        public string ToFile(){
            return $"{trainerName}#{mailingAddress}#{emailAddress}#{enlistTrainer}";
        }
    }
}