using UnityEngine;
using System.Collections;

public class SetupBulletWorld : MonoBehaviour {

	void Start () {
        this.GetComponent<SpriteRenderer>().sprite = OptionsDictionary.instance.bulletWorld.background;
	}
}
