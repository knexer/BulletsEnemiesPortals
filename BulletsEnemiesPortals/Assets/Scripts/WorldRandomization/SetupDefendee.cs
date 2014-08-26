using UnityEngine;
using System.Collections;

public class SetupDefendee : MonoBehaviour {

	void Start () {
        Instantiate(OptionsDictionary.instance.friendlyWorld.defendee, transform.position, transform.rotation);
        Destroy(gameObject);
	}
}
