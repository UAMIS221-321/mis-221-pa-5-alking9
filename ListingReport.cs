// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace mis_221_pa_5_alking9
// {
//     public class ListingReport
//     {
//         Listing [] listings;

//         public ListingReport(Listing [] listings){
//             this.listings = listings;
//         }

//         public void PrintAllListingsFromFile(){
//             for(int i = 0; i < ListingUtility.GetCount(); i++){
//                 if(listings[i].GetUsableListing() == true){
//                     System.Console.WriteLine(listings[i].ToString());
//                 }
//             }
//         }
//     }
// }