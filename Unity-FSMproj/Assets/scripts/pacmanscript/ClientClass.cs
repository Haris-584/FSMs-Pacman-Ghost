
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClientClass : MonoBehaviour
{

    FSM p = new FSM(0);
    // Use this for initialization
    public static char[] inputchar = { 'q', 'w', 'e', 'r', 'a', 's', 'd', 'f', 'z','x','c' }; 
    void Start()
    {
        setMenu();

    }

    public void setMenu()
    {
        Text currentState = GameObject.Find("Canvas/currentState").GetComponent<Text>();
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        currentState.text = "" + p.PacmanCurrentState;
        Text menu = GameObject.Find("Canvas/MenuText").GetComponent<Text>();
        menu.text = "Menu\n\n";
        for (int i = 0; i < System.Enum.GetNames(typeof(FSM.PacManEvents)).Length; i++)
        {
            menu.text += "Press  '" + inputchar[i] + "'  for " + (FSM.PacManEvents)i + "\n\n";
        }  
         
    }

     void Update()
    {

        Text currentState = GameObject.Find("Canvas/currentState").GetComponent<Text>();
        char a = System.Convert.ToChar(Input.inputString);
        for (int i = 0; i < inputchar.Length;i++ )
        {
            if(a == inputchar[i])
            {
                p.pacFireEvent((FSM.PacManEvents)i);
                break;
            }
        }
            currentState.text = "" + p.PacmanCurrentState;
            gameObject.GetComponent<Renderer>().material.color = p.color;
        

    }
}
