using UnityEngine;
using System.Collections;

public class game_music_script : MonoBehaviour {
    GameObject menu_music, over_music;

    void Awake()
    {
        menu_music = GameObject.Find("menu_music");
        over_music = GameObject.Find("over_music");

        if (menu_music)
            Destroy(menu_music);
        if (over_music)
            Destroy(over_music);

        DontDestroyOnLoad(this.gameObject);
    }
}
