using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghost_fsm_using_enum
{
    class MenuClass
    {

        private static string chasePlayer_events = "------------------Chase Player State Events number------------------\n ==> 0 for player die \n ==> 1 for eat pellet \n  ==> 3 for Timeout \n ==> 4 for eaten \n ==> 5 for new generated \n ==> 6 for exit central room \n ";
        private static string runFromPlayer_events = "------------------Run from Player State Events are------------------\n ==> 0 for player die \n ==> 1 for eat pellet \n  ==> 3 for Timeout \n ==> 4 for eaten \n ==> 5 for new generated \n ==> 6 for exit central room \n "; // field
        private static string die_events = "------------------Die State Events are------------------\n ==> 0 for player die \n ==> 1 for eat pellet \n ==> 3 for Timeout \n ==> 4 for eaten \n ==> 5 for new generated \n ==> 6 for exit central room \n  ";
        private static string rise_events = "------------------Rise state Events are------------------\n ==> 0 for player die \n ==> 1 for eat pellet \n  ==> 3 for Timeout \n ==> 4 for eaten \n ==> 5 for new generated \n ==> 6 for exit central room \n";
        private static string randomMove_events = "------------------Random Move state Events are------------------\n ==> 0 for player die \n ==> 1 for eat pellet \n  ==> 3 for Timeout \n ==> 4 for eaten \n ==> 5 for new generated \n ==> 6 for exit central room \n";


        public static string chasePlayerMenu   // property
        {
            get { return chasePlayer_events; }   // get method
            set { chasePlayer_events = value; }  // set method
        }
        public static string runFromPlayerMenu   // property
        {
            get { return runFromPlayer_events; }   // get method
            set { runFromPlayer_events = value; }  // set method
        }
        public static string riseMenu   // property
        {
            get { return rise_events; }   // get method
            set { rise_events = value; }  // set method
        }
        public static string dieMenu   // property
        {
            get { return die_events; }   // get method
            set { die_events = value; }  // set method
        }
        public static string randomMoveMenu   // property
        {
            get { return randomMove_events; }   // get method
            set { randomMove_events = value; }  // set method
        }
    }
    class FSM1
    {
        //Fire event chase player
        public static Tuple<string, string> fire_event_chasePlayer(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "0":
                    value = Program.States.randomMove.ToString();
                    menu = MenuClass.randomMoveMenu;

                    break;
                case "1":
                    value = Program.States.runFromPlayer.ToString();
                    menu = MenuClass.runFromPlayerMenu;
                    break;
                default:
                    //Console.WriteLine("invalid input");
                    value = Program.States.chasePlayer.ToString();
                    menu = MenuClass.chasePlayerMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);

        }

        //Fire event run from player
        public static Tuple<string, string> fire_event_runFromPlayer(string inputevent)
        {
            string value, menu;
            switch (inputevent)
            {
                case "3":
                    value = Program.States.chasePlayer.ToString();
                    menu = MenuClass.chasePlayerMenu;
                    break;
                case "4":
                    value = Program.States.die.ToString();
                    menu = MenuClass.dieMenu;
                    break;
                default:
                    value = Program.States.runFromPlayer.ToString();
                    menu = MenuClass.runFromPlayerMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);
        }

        //Fire event Dead
        public static Tuple<string, string> fire_event_die(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "5":
                    value = Program.States.rise.ToString();
                    menu = MenuClass.riseMenu;
                    break;
                default:
                    value = Program.States.die.ToString();
                    menu = MenuClass.dieMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);
        }

        // Fire event new rise
        public static Tuple<string, string> fire_event_rise(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "6":
                    value = Program.States.chasePlayer.ToString();
                    menu = MenuClass.chasePlayerMenu;
                    break;
                default:
                    value = Program.States.rise.ToString();
                    menu = MenuClass.riseMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);
        }

        //Fire event random move
        public static Tuple<string, string> fire_event_randomMove(string inputevent)
        {
            string value;
            string menu;
            switch (inputevent)
            {
                case "2":
                    value = Program.States.chasePlayer.ToString();
                    menu = MenuClass.chasePlayerMenu;
                    break;
                default:
                    value = Program.States.randomMove.ToString();
                    menu = MenuClass.randomMoveMenu;
                    break;

            }
            return new Tuple<string, string>(value, menu);

        }

    }
}
