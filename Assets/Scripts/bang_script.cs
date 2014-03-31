using UnityEngine;
using System.Collections;

public class bang_script : MonoBehaviour {

    public GameObject bang;
    public Vector3 spawn_position;
    float timer = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 5)
        {
            Instantiate(bang, spawn_position, Quaternion.identity);
        }
	}
}
