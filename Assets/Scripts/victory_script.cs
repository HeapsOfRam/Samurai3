using UnityEngine;
using System.Collections;

public class victory_script : MonoBehaviour {
    public float retry_button_x_pos, retry_button_y_pos;
    public float menu_button_x_pos, menu_button_y_pos;
    const int BEGIN_LEVEL = 4;
    const int MENU_LEVEL = 0;
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
        GUI.Label(new Rect(Screen.width / 2 - 40, 150, 80, 50), "VICTORY!");

        if (GUI.Button(new Rect(Screen.width / 2 - retry_button_x_pos, Screen.height / 2 - retry_button_y_pos, button_x_size, button_y_size), "Retry"))
        {
            Application.LoadLevel(BEGIN_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - menu_button_x_pos, Screen.height / 2 - menu_button_y_pos, button_x_size, button_y_size), "Menu"))
        {
            Application.LoadLevel(MENU_LEVEL);
        }
    }
}
