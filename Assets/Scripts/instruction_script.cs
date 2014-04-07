using UnityEngine;
using System.Collections;

public class instruction_script : MonoBehaviour {
    public float start_button_x_pos, start_button_y_pos;
    public float menu_button_x_pos, menu_button_y_pos;
    public float instruction_button_x_pos, instruction_button_y_pos;
    private const int BEGIN_LEVEL = 4, MENU_LEVEL = 0, STORY_LEVEL = 2;
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
        if (GUI.Button(new Rect(Screen.width * start_button_x_pos, Screen.height * start_button_y_pos, button_x_size, button_y_size), "Start Game"))
        {
            Application.LoadLevel(BEGIN_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * menu_button_x_pos, Screen.height * menu_button_y_pos, button_x_size, button_y_size), "Back"))
        {
            Application.LoadLevel(MENU_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * instruction_button_x_pos, Screen.height * instruction_button_y_pos, button_x_size, button_y_size), "Story"))
        {
            Application.LoadLevel(STORY_LEVEL);
        }
    }
}
