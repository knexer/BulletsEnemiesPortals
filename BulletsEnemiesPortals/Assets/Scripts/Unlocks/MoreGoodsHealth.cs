using UnityEngine;
using System.Collections;

public class MoreGoodsHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject[] goods = GameObject.FindGameObjectsWithTag("Good");
        foreach (GameObject good in goods)
        {
            TakeDamage hp = good.GetComponent<TakeDamage>();
            hp.HP = hp.HP * 2;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
