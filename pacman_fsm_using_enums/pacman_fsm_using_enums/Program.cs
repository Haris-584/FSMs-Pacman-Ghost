using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman_fsm_using_enums
{
    class Program
    {
        public enum States
        {
            spwand,
            super_pacman,
            dead,
            levelup,
            gameover

        }
        public enum Events
        {
            eat_cheese,
            eat_super_tablet,
            eat_levelup_cheese,
            eat_round_ghost,
            timeout_super_tablet,
            eaten,
            eaten_by_brave_ghost,
            liveleft,
            no_liveleft,
            nextlevel,
            lastlevel
        }
        static void Main(string[] args)
        {
            string currentState = "";
            string inputevent = "";
            string menu = "";
           
            while (true)
            {
                if (currentState == "" || currentState == States.spwand.ToString())
                {
                    currentState = FSM1.fire_event_spawnd(inputevent).Item1;
                    menu = FSM1.fire_event_spawnd(inputevent).Item2;
                }

                if (currentState == States.super_pacman.ToString())
                {
                    currentState = FSM1.fire_event_super_pacman(inputevent).Item1;
                    menu =FSM1.fire_event_super_pacman(inputevent).Item2;
                }
                if (currentState == States.dead.ToString())
                {
                    currentState = FSM1.fire_event_dead(inputevent).Item1; 
                    menu =FSM1.fire_event_dead(inputevent).Item2;
                }
                if (currentState == States.gameover.ToString())
                {
                    currentState = FSM1.fire_event_gameover(inputevent).Item1;
                    menu = FSM1.fire_event_gameover(inputevent).Item2;
                }
                if (currentState == States.levelup.ToString())
                {
                   currentState = FSM1.fire_event_levelup(inputevent).Item1;
                   menu = FSM1.fire_event_levelup(inputevent).Item2;                    
                }
                Console.WriteLine(menu +"\n You are now in " + currentState);
                inputevent = Console.ReadLine();
            }
           
        }

     
    }
}
