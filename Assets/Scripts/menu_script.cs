using UnityEngine;
using System.Collections;

public class menu_script : MonoBehaviour {

    public float start_button_x_pos, start_button_y_pos;
    public float story_button_x_pos, story_button_y_pos;
    public float instruction_button_x_pos, instruction_button_y_pos;

	// Use this for initialization
    private const int BEGIN_LEVEL = 2;
	void Start () {
	
	}
	
	// Update is called once per frame
	/*void Update () {
	
	}*/

    void OnGUI()
    {
        //GUI.Label(new Rect(Screen.width / 2 - 40, 150, 80, 50), "Game Over");
        if (GUI.Button(new Rect(Screen.width / 2 - start_button_x_pos, Screen.height / 2 - start_button_y_pos, 80, 50), "Start Game"))
        {
            Application.LoadLevel(BEGIN_LEVEL);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - story_button_x_pos, Screen.height / 2 - story_button_y_pos, 80, 50), "Story"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - instruction_button_x_pos, Screen.height / 2 - instruction_button_y_pos, 80, 50), "Instructions"))
        {
            Application.LoadLevel(1);
        }
    }
}
