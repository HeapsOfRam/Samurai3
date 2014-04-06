using UnityEngine;
using System.Collections;

public class start_button_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    /*GameObject GetClickedGameObject()
    {
        // Builds a ray from camera point of view to the mouse position 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        // Casts the ray and get the first game object hit 
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            return hit.transform.gameObject;
        else
            return null;
    }*/
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetMouseButtonDown(0))
            if (GetClickedGameObject() == this.gameObject)
                Application.LoadLevel(2);*/
        //if (Input.touchCount > 0)
        /*if (Input.GetMouseButtonDown(0))
            Application.LoadLevel(2);*/
	}
}
