using UnityEngine;
using System.Collections;

public class menu_script : MonoBehaviour {

    public float start_button_x_pos, start_button_y_pos;
    public float story_button_x_pos, story_button_y_pos;
    public float instruction_button_x_pos, instruction_button_y_pos;
    private const int BEGIN_LEVEL = 4, STORY_LEVEL = 2, INS_LEVEL = 3;    
    int button_x_size = 80;
    int button_y_size = 50;

	// Use this for initialization
	void Start () {
	
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

        if (GUI.Button(new Rect(Screen.width * story_button_x_pos, Screen.height * story_button_y_pos, button_x_size, button_y_size), "Story"))
        {
            Application.LoadLevel(STORY_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * instruction_button_x_pos, Screen.height * instruction_button_y_pos, button_x_size, button_y_size), "Instructions"))
        {
            Application.LoadLevel(INS_LEVEL);
        }
    }
}
