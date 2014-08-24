using UnityEngine;
using System.Collections;

public class TakeDamage : MonoBehaviour {
    public int HP;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool takeDamage(int damage) {
        HP -= damage;
        Debug.Log(HP.ToString());
        if (HP <= 0) {
            Destroy(this);
            return true;
        }
        return false;
    }
}
