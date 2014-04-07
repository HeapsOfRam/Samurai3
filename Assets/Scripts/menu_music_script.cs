using UnityEngine;
using System.Collections;

public class menu_music_script : MonoBehaviour {
    GameObject over_music;

    void Awake()
    {
        over_music = GameObject.Find("over_music");

        if (over_music)
            Destroy(over_music);

        DontDestroyOnLoad(this.gameObject);
    }
}
