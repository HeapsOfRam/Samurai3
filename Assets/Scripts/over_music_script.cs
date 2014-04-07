using UnityEngine;
using System.Collections;

public class over_music_script : MonoBehaviour {
    GameObject game_music, menu_music;

    void Awake()
    {
        game_music = GameObject.Find("game_music");

        if (game_music)
            Destroy(game_music);

        DontDestroyOnLoad(this.gameObject);
    }
}
