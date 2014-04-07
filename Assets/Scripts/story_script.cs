﻿using UnityEngine;
using System.Collections;

public class story_script : MonoBehaviour
{

    public float start_button_x_pos, start_button_y_pos;
    public float menu_button_x_pos, menu_button_y_pos;
    public float instruction_button_x_pos, instruction_button_y_pos;
    private const int BEGIN_LEVEL = 4, MENU_LEVEL = 0, INS_LEVEL = 3;    
    int button_x_size = 80;
    int button_y_size = 50;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    /*void Update () {
	
    }*/

    void OnGUI()
    {
        //GUI.Label(new Rect(Screen.width / 2 - 40, 150, 80, 50), "Game Over");
        if (GUI.Button(new Rect(Screen.width / 2 - start_button_x_pos, Screen.height / 2 - start_button_y_pos, button_x_size, button_y_size), "Start Game"))
        {
            Application.LoadLevel(BEGIN_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - menu_button_x_pos, Screen.height / 2 - menu_button_y_pos, button_x_size, button_y_size), "Back"))
        {
            Application.LoadLevel(MENU_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - instruction_button_x_pos, Screen.height / 2 - instruction_button_y_pos, button_x_size, button_y_size), "Instructions"))
        {
            Application.LoadLevel(INS_LEVEL);
        }
    }
}
