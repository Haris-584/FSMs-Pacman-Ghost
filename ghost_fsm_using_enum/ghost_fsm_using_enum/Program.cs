using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ghost_fsm_using_enum
{
    class Program
    {
        public enum States
        {
            chasePlayer,
            rise,
            die,
            runFromPlayer,
            randomMove

        }
        public enum Events
        {
            player_die,
            eat_pellet,
            timeout,
            respawn,
            new_generated,
            exit_centralRoom,
            eaten_by_player,
   
        }
        static void Main(string[] args)
        {
            string currentState = "";
            string inputevent = "";
            string menu = "";

            while (true)
            {
                if (currentState == "" || currentState == States.chasePlayer.ToString())
                {
                    currentState = FSM1.fire_event_chasePlayer(inputevent).Item1;
                    menu = FSM1.fire_event_chasePlayer(inputevent).Item2;
                }

                if (currentState == States.runFromPlayer.ToString())
                {
                    currentState = FSM1.fire_event_runFromPlayer(inputevent).Item1;
                    menu = FSM1.fire_event_runFromPlayer(inputevent).Item2;
                }
                if (currentState == States.die.ToString())
                {
                    currentState = FSM1.fire_event_die(inputevent).Item1; 
                    menu =FSM1.fire_event_die(inputevent).Item2;
                }
                if (currentState == States.randomMove.ToString())
                {
                    currentState = FSM1.fire_event_randomMove(inputevent).Item1;
                    menu = FSM1.fire_event_randomMove(inputevent).Item2;
                }
                if (currentState == States.rise.ToString())
                {
                   currentState = FSM1.fire_event_rise(inputevent).Item1;
                   menu = FSM1.fire_event_rise(inputevent).Item2;                    
                }
                Console.WriteLine(menu +"\n You are now in " + currentState);
                inputevent = Console.ReadLine();
            }
           
        
        }
    }
}
