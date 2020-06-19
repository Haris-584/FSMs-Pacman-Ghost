using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman_fsm_using_enums
{
    class MenuClass
    {
       
        private static string spawn_events = "------------------Spawn state Events number------------------\n ==> 0 for cheese \n ==> 1 for supertablet \n ==> 5 for eaten \n ==> 2 for levelup";
        private static string super_pacman_events = "------------------Super Pacman State Events are------------------\n ==> 0 for cheese \n ==> 1 for supertablet \n ==> 6 for eaten by brave ghost \n ==> 2 for levelup \n ==> 4 for timeout \n ==> 3 for eatghost"; // field
        private static string dead_events = "------------------Dead State Events are------------------\n ==> 7 for livesleft \n ==> 8 for no livesleft ";
        private static string levelup_events = "------------------levelup state Events are------------------\n ==> 9 for nextlevel \n ==> 10 for lastlevel ";
        private static string gameover_events = "------------------Gameover ba bye------------------- ";
        
        public static string spawnMenu   // property
        {
            get { return spawn_events; }   // get method
            set { spawn_events = value; }  // set method
        }
        public static string SuperpacmanMenu   // property
        {
            get { return super_pacman_events; }   // get method
            set { super_pacman_events = value; }  // set method
        }
        public static string levelupMenu   // property
        {
            get { return levelup_events; }   // get method
            set { levelup_events = value; }  // set method
        }
        public static string deadMenu   // property
        {
            get { return dead_events; }   // get method
            set { dead_events = value; }  // set method
        }
        public static string gameoverMenu   // property
        {
            get { return gameover_events; }   // get method
            set { gameover_events = value; }  // set method
        }
    }
    class FSM1
    {
           //Fire event spawnd
        public static Tuple<string, string> fire_event_spawnd(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "0":
                    value = Program.States.spwand.ToString();
                    menu = MenuClass.spawnMenu;

                    break;
                case "1":
                    value = Program.States.super_pacman.ToString();
                    menu = MenuClass.SuperpacmanMenu;
                    break;
                case "5":
                    value = Program.States.dead.ToString();
                    menu = MenuClass.deadMenu;
                    break;
                case "2":
                    value = Program.States.levelup.ToString();
                    menu = MenuClass.levelupMenu;
                    break;
                default:
                    value = Program.States.spwand.ToString();
                    menu = MenuClass.spawnMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);
           
        }

        //Fire event super pacman
        public static Tuple<string, string> fire_event_super_pacman(string inputevent)
        {
            string value, menu;
            switch (inputevent)
            {
                case "0":
                    value = Program.States.super_pacman.ToString();
                    menu = MenuClass.SuperpacmanMenu;
                    break;
                case "1":
                    value = Program.States.super_pacman.ToString();
                    menu = MenuClass.SuperpacmanMenu;
                    break;
                case "2":
                    value = Program.States.levelup.ToString();
                    menu = MenuClass.levelupMenu;
                    break;
                case "3":
                    value = Program.States.super_pacman.ToString();
                    menu = MenuClass.SuperpacmanMenu;
                    break;
                case "4":
                    value = Program.States.spwand.ToString();
                    menu = MenuClass.spawnMenu;
                    break;
                case "6":
                    value = Program.States.dead.ToString();
                    menu = MenuClass.deadMenu;
                    break;
                default:
                   // Console.WriteLine("Value didn’t match ");
                    value = Program.States.super_pacman.ToString();
                    menu = MenuClass.SuperpacmanMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);
        }
       
        //Fire event Dead
        public static Tuple<string,string> fire_event_dead(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "7":
                    value = Program.States.spwand.ToString();
                    menu = MenuClass.spawnMenu;
                   break;
                case "8":
                   value = Program.States.gameover.ToString();
                   menu = MenuClass.gameoverMenu;
                    break;
                default:
                    value = Program.States.dead.ToString();
                    menu = MenuClass.deadMenu;
                    break;

            }
            return new Tuple<string,string>(value,menu);
                    }
       
        // Fire event levelup
        public static Tuple<string, string> fire_event_levelup(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "9":
                    value = Program.States.spwand.ToString();
                    menu = MenuClass.spawnMenu;

                    break;
                case "10":
                    value = Program.States.gameover.ToString();
                    menu = MenuClass.gameoverMenu;
                    break;
                default:
                    value = Program.States.levelup.ToString();
                    menu = MenuClass.levelupMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);
        }

        //Fire event gameover
        public static Tuple<string, string> fire_event_gameover(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "11":
                    value = Program.States.gameover.ToString();
                    menu = MenuClass.gameoverMenu;
                    break;
                default:
                    value = Program.States.gameover.ToString();
                    menu = MenuClass.gameoverMenu;
                    Environment.Exit(0);
                    break;

            }
            return new Tuple<string, string>(value, menu);
            
                  } 
        
    }
}
