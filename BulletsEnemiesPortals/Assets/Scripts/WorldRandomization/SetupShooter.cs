using UnityEngine;
using System.Collections;

public class SetupShooter : MonoBehaviour {

	void Start () {
        this.GetComponent<Shooter>().bullet = OptionsDictionary.instance.bulletWorld.bullet;
	}
}
