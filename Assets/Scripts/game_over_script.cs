using UnityEngine;
using System.Collections;

public class game_over_script : MonoBehaviour {
    public float retry_button_x_pos, retry_button_y_pos;
    public float menu_button_x_pos, menu_button_y_pos;
    const int BEGIN_LEVEL = 4;
    const int MENU_LEVEL = 0;
    float button_x_size = Screen.width * .1f;
    float button_y_size = Screen.height * .1f;
    GUIStyle button_font;

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

        if (GUI.Button(new Rect(Screen.width * retry_button_x_pos, Screen.height * retry_button_y_pos, button_x_size, button_y_size), "Retry", button_font))
        {
            Application.LoadLevel(BEGIN_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width * menu_button_x_pos, Screen.height * menu_button_y_pos, button_x_size, button_y_size), "Menu", button_font))
        {
            Application.LoadLevel(MENU_LEVEL);
        }
    }
}
