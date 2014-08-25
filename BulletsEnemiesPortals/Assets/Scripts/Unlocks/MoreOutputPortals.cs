using UnityEngine;
using System.Collections;
using System.Linq;

public class MoreOutputPortals : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //find the out portal
        GameObject OutPortal = GameObject.Find("OutPortal");

        //make new out portals
        GameObject rightClone = (GameObject)Instantiate(OutPortal, OutPortal.transform.position + new Vector3(1, 0, 0), Quaternion.identity);
        GameObject leftClone = (GameObject)Instantiate(OutPortal, OutPortal.transform.position + new Vector3(-1, 0, 0), Quaternion.identity);

        //find the in portal
        InPortal inPortal = FindObjectOfType<InPortal>();

        //link them to the in portal
        inPortal.pairs = new OutPortal[3] { inPortal.pairs[0], rightClone.GetComponent<OutPortal>(), leftClone.GetComponent<OutPortal>() };
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
