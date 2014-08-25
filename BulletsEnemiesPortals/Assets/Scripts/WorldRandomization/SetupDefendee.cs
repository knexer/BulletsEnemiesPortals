using UnityEngine;
using System.Collections;

public class SetupDefendee : MonoBehaviour {

	void Start () {
        this.GetComponent<SpriteRenderer>().sprite = OptionsDictionary.instance.friendlyWorld.enemy.GetComponent<SpriteRenderer>().sprite;
	}
}
