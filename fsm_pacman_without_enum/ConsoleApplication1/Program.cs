using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {

            Program program = new Program();
            string currentstate = "spawn";
            Console.WriteLine("------------------Game Start Enter Event number------------------\n ==> 0 for cheese \n ==> 1 for supertablet \n ==> 2 for eaten \n ==> 3 for levelup");
            Console.WriteLine("------------------Spawn state Events number------------------\n ==> 0 for cheese \n ==> 1 for supertablet \n ==> 2 for eaten \n ==> 3 for levelup");
            Console.WriteLine("------------------Super Pacman State Events are------------------\n ==> 0 for cheese \n ==> 1 for supertablet \n ==> 2 for eaten \n ==> 3 for levelup \n ==> 4 for timeout \n ==> 9 for eatghost");
            Console.WriteLine("------------------Dead State Events are------------------\n ==> 5 for livesleft \n ==> 6 for no livesleft ");
            Console.WriteLine("------------------levelup state Events are------------------\n ==> 7 for nextlevel \n ==> 8 for lastlevel ");

                        


            while (currentstate != "gameover")
            {
                Console.WriteLine("You are now in " + currentstate);
                string inputevent = Console.ReadLine();
               

                if (currentstate == "spawn")
                {
                    currentstate = program.spawnState(inputevent);


                }
                if (currentstate == "super_pacmanState")
                {
                   
                    currentstate = program.super_pacmanState(inputevent);
                                   }
                if (currentstate == "deadState")
                {
                    currentstate = program.deadState(inputevent);
                }
                if (currentstate == "gameoverState")
                {
                    currentstate = program.gameoverState(inputevent);
                }
                if (currentstate == "levelupState")
                {
                    currentstate = program.levelupState(inputevent);
                }
            }
        }

        public string spawnState(string inputevent)
        {
            
            string value;
            switch (inputevent)
            {

                case "0": //cheese
                    value = "spawn";
                    break;
                case "1": //supertablet
                    value = "super_pacmanState";
                    break;
                case "2": //eaten
                    value = "deadState";
                    break;
                case "3": //levelupcheese
                    value = "levelupState";
                    break;
                default:
                    Console.WriteLine("Value didn’t match ");
                    value = "spawn";
                    break;
            }
            return value;


        }
        public string super_pacmanState(string inputevent)
        {
 
            string value;
            switch (inputevent)
            {

                case "0": //cheese
                    value = "super_pacmanState";
                    break;
                case "1": //supertablet
                    value = "super_pacmanState";
                    break;
                case "4": //timeout
                    value = "spawn";
                    break;
                case "9"://eatghost
                    value = "super_pacmanState";
                    break;
                case "2": //eaten
                    value = "deadState";
                    break;
                case "3": //levelupcheese
                    value = "levelupState";
                    break;

                default:
                    Console.WriteLine("Value didn’t match ");
                    value = "super_pacmanState";
                    break;

            }
            return value;


        }
        public string deadState(string inputevent)
        {
                      string value;
            switch (inputevent)
            {
                case "2": //eaten
                    value = "deadState";
                    break;
                case "5":  //livesleft
                    value = "spawn";
                    break;
                case "6": //no livesleft
                    value = "gameoverState";
                    break;
                default:
                    Console.WriteLine("Value didn’t match ");
                    value = "deadState";
                    break;
            }
            return value;


        }
        public string levelupState(string inputevent)
        {
            
            string value;
            switch (inputevent)
            {

                case "3": //levelupcheese
                    value = "levelupState";
                    break;

                case "7": //nextlevel
                    value = "spawn";
                    break;
                case "8": //last level
                    value = "gameoverState";
                    break;
                default:
                    Console.WriteLine("Value didn’t match ");
                    value = "levelupState";
                    break;
            }
            return value;


        }
        public string gameoverState(string inputevent)
        {
            Console.WriteLine("************GameOver************");
            Console.Read();
            
            Environment.Exit(5000);
           
            string value = null;
           
            return value;

            
        }



    }
}
