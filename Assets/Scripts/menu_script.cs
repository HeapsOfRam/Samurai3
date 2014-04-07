using UnityEngine;
using System.Collections;

public class menu_script : MonoBehaviour {

    public float start_button_x_pos, start_button_y_pos;
    public float story_button_x_pos, story_button_y_pos;
    public float instruction_button_x_pos, instruction_button_y_pos;
    private const int BEGIN_LEVEL = 4, STORY_LEVEL = 2, INS_LEVEL = 3;    
    float button_x_size = Screen.width * .1f;
    float button_y_size = Screen.height * .1f;
    GUIStyle button_font;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}

    void OnGUI()
    {
        button_font = new GUIStyle("button");
        button_font.fontSize = 30;

        if (GUI.Button(new Rect(Screen.width * start_button_x_pos, Screen.height * start_button_y_pos, button_x_size, button_y_size), "Start", button_font))
        {
            Application.LoadLevel(BEGIN_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * story_button_x_pos, Screen.height * story_button_y_pos, button_x_size, button_y_size), "Story", button_font))
        {
            Application.LoadLevel(STORY_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * instruction_button_x_pos, Screen.height * instruction_button_y_pos, button_x_size, button_y_size), "Help", button_font))
        {
            Application.LoadLevel(INS_LEVEL);
        }
    }
}
