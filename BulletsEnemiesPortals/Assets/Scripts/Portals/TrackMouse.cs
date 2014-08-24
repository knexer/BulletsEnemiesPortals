using UnityEngine;
using System.Collections;

public class TrackMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale != 0) {
            Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            Vector3 worldOffset = Camera.main.ScreenToWorldPoint(mouseDelta) - Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
            transform.position += worldOffset * 2;
        }
	}
}
