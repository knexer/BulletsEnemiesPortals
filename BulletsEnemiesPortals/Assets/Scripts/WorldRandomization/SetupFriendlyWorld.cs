using UnityEngine;
using System.Collections;

public class SetupFriendlyWorld : MonoBehaviour {

	void Start () {
        this.GetComponent<SpriteRenderer>().sprite = OptionsDictionary.instance.friendlyWorld.upper_background;
	}
}
