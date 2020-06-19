
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ghostClientClass : MonoBehaviour
{
    ghostFSM p = new ghostFSM(0);
   
    
    // Use this for initialization
    public static char[] inputchar = { 'q', 'w', 'e', 'r', 'a', 's', 'd' };
    void Start()
    {
        setMenu();

    }
    //private GameObject Cube;
    public void setMenu()
    {
        Text currentState = GameObject.Find("Canvas/currentState").GetComponent<Text>();
        gameObject.GetComponent<Renderer>().material.color = Color.green;
       //Cube.transform.Rotate(5.0f, 5.0f, 0.0f, Space.Self);
        currentState.text = "" + p.GhostCurrentState;
        Text menu = GameObject.Find("Canvas/MenuText").GetComponent<Text>();
        menu.text = "Menu\n\n";
        for (int i = 0; i < System.Enum.GetNames(typeof(ghostFSM.GhostEvents)).Length; i++)
        {
            menu.text += "Press  '" + inputchar[i] + "'  for " + (ghostFSM.GhostEvents)i + "\n\n";
        }

    }

    void Update()
    {

        Text currentState = GameObject.Find("Canvas/currentState").GetComponent<Text>();
        char a = System.Convert.ToChar(Input.inputString);
        for (int i = 0; i < inputchar.Length; i++)
        {
            if (a == inputchar[i])
            {
                p.pacFireEvent((ghostFSM.GhostEvents)i);
                break;
            }
        }
        currentState.text = "" + p.GhostCurrentState;
        currentState.color = p.color;
        
        gameObject.GetComponent<Renderer>().material.color = p.color;


    }
}

