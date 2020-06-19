using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ghostFSM : MonoBehaviour
{
    public GhostStates GhostCurrentState;

    public Color color;
    // Pacman fsm states (enum)
    public enum GhostStates
    {
        chase_pacman,
        random_move,
        run_from_player,
        rise,
        die,
    }
    // Pacman fsm events (enum)
    public enum GhostEvents
    {
        pacman_eaten,
        respawn,
        eat_supertablet,
        timeout,
        ghost_eaten,
        new_generated,
        exit_room

    }

    //get current state of pacman
    public ghostFSM(GhostStates initial_State)
    {
        this.GhostCurrentState = initial_State;

    }

    public bool inValid = false;

    //pac fire event function
    public void pacFireEvent(GhostEvents e)
    {
        if (this.GhostCurrentState == GhostStates.chase_pacman)
        {
            switch (e)
            {
                case GhostEvents.pacman_eaten:
                    this.GhostCurrentState = GhostStates.random_move;
                    this.color = Color.blue;
                    break;
                case GhostEvents.eat_supertablet:
                    this.GhostCurrentState = GhostStates.run_from_player;
                    this.color = Color.yellow;
                    break;
                default:
                    this.GhostCurrentState = GhostStates.chase_pacman;
                    this.color = Color.green;
                    break;
            }
        }
        else if (this.GhostCurrentState == GhostStates.random_move)
        {
            switch (e)
            {
                case GhostEvents.respawn:
                    this.GhostCurrentState = GhostStates.chase_pacman;
                    this.color = Color.green;
                    break;
                default:
                    this.GhostCurrentState = GhostStates.random_move;
                    this.color = Color.blue;
                    break;

            }
        }
        else if (this.GhostCurrentState == GhostStates.run_from_player)
        {
            switch (e)
            {
                case GhostEvents.timeout:
                    this.GhostCurrentState = GhostStates.chase_pacman;
                    this.color = Color.green;
                    break;
                case GhostEvents.ghost_eaten:
                    this.GhostCurrentState = GhostStates.die;
                    this.color = Color.black;
                    break;
                default:
                    this.GhostCurrentState = GhostStates.run_from_player;
                    this.color = Color.yellow;
                    break;

            }
        }
        else if (this.GhostCurrentState == GhostStates.die)
        {
            switch (e)
            {
                case GhostEvents.new_generated:
                    this.GhostCurrentState = GhostStates.rise;
                    this.color = Color.cyan;
                    break;
                
                default:
                    this.GhostCurrentState = GhostStates.die;
                    this.color = Color.black;
                    break;

            }
        }
        else
        {
            switch (e)
            {
                case GhostEvents.exit_room:
                    this.GhostCurrentState = GhostStates.chase_pacman;
                    this.color = Color.green;
                    break;
                default:
                    inValid = true;
                    break;

            }
        }
    }

   
}