using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class Reports
    {
        private static Trainer[] trainers;

        private static Listing[] listings; 
               static public void PrintAllTrainers(){
                Trainer[] trainers = TrainerUtility.GetTrainers();
            for(int i = 0; i < TrainerUtility.GetCount(); i++){
                if(trainers[i].GetEnlistTrainer() == true){
                    System.Console.WriteLine(trainers[i].ToString());
                }
            }
        }

          static public void PrintAllListings()
          {
            Listing[] listings = ListingUtility.GetListings();
            for(int i = 0; i < ListingUtility.GetCount(); i++){
                if(listings[i].GetUsableListing() == true){
                    System.Console.WriteLine(listings[i].ToString());
                 }
            }
        }
        
    
    }
}