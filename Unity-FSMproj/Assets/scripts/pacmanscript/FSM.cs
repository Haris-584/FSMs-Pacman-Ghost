using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FSM : MonoBehaviour
{
    public PacManState PacmanCurrentState;

    public Color color;
    // Pacman fsm states (enum)
    public enum PacManState
    {
        Start_Pacman,
        Super_Pacman,
        DEAD,
        LEVELUP,
        GAMEOVER,
    }
    // Pacman fsm events (enum)
    public enum PacManEvents
    {
        EatCheese,
        Eat_SuperTablet,
        Eaten_by_ghost,
        ToEatLastCheeze,
        LifeLeft,
        NoLifeLeft,
        Pacman_Eats_Sacred_Ghost,
        Brave_Ghost_Eats_Pacman,
        SuperPacman_Timeout,
        NextLevel,
        LastLevel

    }

    public void Start()
    {
    }

    public void update()
    {
    }

    //get current state of pacman
    public FSM(PacManState initial_State)
    {
        this.PacmanCurrentState = initial_State;

    }

    public bool inValid = false;

    //pac fire event function
    public void pacFireEvent(PacManEvents e)
    {
        if (this.PacmanCurrentState == PacManState.Start_Pacman)
        {
            switch (e)
            {
                case PacManEvents.EatCheese:
                    this.PacmanCurrentState = PacManState.Start_Pacman;
                    this.color = Color.green;
                    break;
                case PacManEvents.Eat_SuperTablet:
                    this.PacmanCurrentState = PacManState.Super_Pacman;
                    this.color = Color.blue;
                    break;
                case PacManEvents.Eaten_by_ghost:
                    this.PacmanCurrentState = PacManState.DEAD;
                    this.color = Color.red;
                    break;
                case PacManEvents.ToEatLastCheeze:
                    this.PacmanCurrentState = PacManState.LEVELUP;
                    this.color = Color.yellow;
                    break;
                default:
                    this.PacmanCurrentState = PacManState.Start_Pacman;
                    this.color = Color.green;
                    break;
            }
        }
        else if (this.PacmanCurrentState == PacManState.Super_Pacman)
        {
            switch (e)
            {
                case PacManEvents.EatCheese:
                    this.PacmanCurrentState = PacManState.Super_Pacman;
                    this.color = Color.blue;
                    break;
                case PacManEvents.Eat_SuperTablet:
                    this.PacmanCurrentState = PacManState.Super_Pacman;
                    this.color = Color.blue;
                    break;
                case PacManEvents.ToEatLastCheeze:
                    this.PacmanCurrentState = PacManState.LEVELUP;
                    this.color = Color.yellow;
                    break;
                case PacManEvents.Pacman_Eats_Sacred_Ghost:
                    this.PacmanCurrentState = PacManState.Super_Pacman;
                    this.color = Color.blue;
                    break;
                case PacManEvents.Brave_Ghost_Eats_Pacman:
                    this.PacmanCurrentState = PacManState.DEAD;
                    this.color = Color.red;
                    break;
                case PacManEvents.SuperPacman_Timeout:
                    this.PacmanCurrentState = PacManState.Start_Pacman;
                    this.color = Color.green;
                    break;
                default:
                    this.PacmanCurrentState = PacManState.Super_Pacman;
                    this.color = Color.blue;
                    break;

            }
        }
        else if (this.PacmanCurrentState == PacManState.DEAD)
        {
            switch (e)
            {
                case PacManEvents.NoLifeLeft:
                    this.PacmanCurrentState = PacManState.GAMEOVER;
                    this.color = Color.black;
                    break;
                case PacManEvents.LifeLeft:
                    this.PacmanCurrentState = PacManState.Start_Pacman;
                    this.color = Color.green;
                    break;
                default:
                    this.PacmanCurrentState = PacManState.DEAD;
                    this.color = Color.red;
                    break;

            }
        }
        else if (this.PacmanCurrentState == PacManState.LEVELUP)
        {
            switch (e)
            {
                case PacManEvents.NextLevel:
                    this.PacmanCurrentState = PacManState.Start_Pacman;
                    this.color = Color.green;
                    break;
                case PacManEvents.LastLevel:
                    this.PacmanCurrentState = PacManState.GAMEOVER;
                    this.color = Color.black;
                    break;
                default:
                    this.PacmanCurrentState = PacManState.LEVELUP;
                    this.color = Color.yellow;
                    break;

            }
        }
        else
        {
            switch (e)
            {
                case PacManEvents.LastLevel:
                    this.PacmanCurrentState = PacManState.GAMEOVER;
                    this.color = Color.black;
                    break;
                default:
                    inValid = true;
                    break;

            }
        }
    }

   
}