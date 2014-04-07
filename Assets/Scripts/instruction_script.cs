using UnityEngine;
using System.Collections;

public class instruction_script : MonoBehaviour {
    public float start_button_x_pos, start_button_y_pos;
    public float menu_button_x_pos, menu_button_y_pos;
    public float instruction_button_x_pos, instruction_button_y_pos;
    private const int BEGIN_LEVEL = 4, MENU_LEVEL = 0, STORY_LEVEL = 2;
    float button_x_size = Screen.width * .1f;
    float button_y_size = Screen.height * .1f;
    private GUIStyle button_font;

    // Use this for initialization
    void Start()
    {
        
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

        if (GUI.Button(new Rect(Screen.width * menu_button_x_pos, Screen.height * menu_button_y_pos, button_x_size, button_y_size), "Back", button_font))
        {
            Application.LoadLevel(MENU_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * instruction_button_x_pos, Screen.height * instruction_button_y_pos, button_x_size, button_y_size), "Story", button_font))
        {
            Application.LoadLevel(STORY_LEVEL);
        }
    }
}
