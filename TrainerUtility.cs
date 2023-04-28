using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis_221_pa_5_alking9
{
    public class TrainerUtility
    {
        static public int count;
        private static Trainer [] trainers;
        private static int MAX_TRAINER_SIZE = 100;
        // private static Trainer[] trainers = new Trainer[MAX_TRAINER_SIZE];
         public TrainerUtility(Trainer [] newTrainers){
            trainers = newTrainers;
        }
            static public void SetCount(int count){
            TrainerUtility.count = count;
        }

        static public void IncCount(){
            TrainerUtility.count++;
        }
        static public int GetCount(){
            return count;
        }

        
        public void AddUrTrainer(){
            TrainerUtility.GetTrainers();
            Reports.PrintAllTrainers();
            System.Console.WriteLine("Please enter the trainer name you want to add");
            Trainer urNewTrainer = new Trainer();
            urNewTrainer.SetTrainerName(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer email address");
            urNewTrainer.SetEmailAddress(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer mailing address");
            urNewTrainer.SetMailingAddress(Console.ReadLine());
            urNewTrainer.SetEnlistTrainer(true);
            trainers[TrainerUtility.GetCount()] = urNewTrainer;
            TrainerUtility.IncCount();
            // Reports.PrintAllTrainers();
            System.Console.WriteLine("Great you have been added!");

            SaveUrTrainer();
        }

        public static Trainer[] GetTrainers(){
             GetAllTrainersFromFile();
             return trainers;
             }





        static public void SaveUrTrainer(){
            StreamWriter outFile = new StreamWriter("trainers.txt");
            
            for(int i = 0; i < TrainerUtility.GetCount(); i++ ){
                outFile.WriteLine(trainers[i].ToFile());
            }
            outFile.Close();

        }

        public static int Find(string searchVal){
            for(int i = 0; i < TrainerUtility.GetCount(); i++ ){
                if(trainers[i].GetTrainerName().ToUpper() == searchVal.ToUpper()){
                    return i;
                }
            }
            return -1;
        }

         static public void EditTrainer(){
            System.Console.WriteLine("What is the trainer ID?");
            string searchval = Console.ReadLine();
            int foundIndex = Find(searchval);

            if(foundIndex != -1){
                System.Console.WriteLine("Please enter the trainer name");
                trainers[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the trainer emaling address");
                trainers[foundIndex].SetEmailAddress(Console.ReadLine());
                System.Console.WriteLine("Please enetr the trainer mailing address");
                trainers[foundIndex].SetMailingAddress(Console.ReadLine());

                SaveUrTrainer();
            }
            // else{
            //     System.Console.WriteLine("Invalid Trainer :/");
            // }
        }

        static public void DeleteTrainer(){
            System.Console.WriteLine("Which trainer would you like to delete?");
            string searchVal = Console.ReadLine();

            int foundIndex = Find(searchVal);

            if(foundIndex != -1){
                trainers[foundIndex].SetEnlistTrainer(true);
                SaveUrTrainer();
            }
            else{
                System.Console.WriteLine("Invalid trainer :/");
            }
        }

            static public void GetAllTrainersFromFile(){
                    StreamReader inFile = new StreamReader("trainers.txt");

                    //process
                    TrainerUtility.SetCount(0);

                    string line = inFile.ReadLine();
                    while(line != null){
                        string[] temp = line.Split('#');
                        trainers[TrainerUtility.GetCount()] = new Trainer(int.Parse(temp[0]), temp[1], (temp[2]), (temp[3]), bool.Parse(temp[4]));
                        
                        line = inFile.ReadLine();
                        TrainerUtility.IncCount();
                        
                    }
                    inFile.Close();
            }
        }




    }
