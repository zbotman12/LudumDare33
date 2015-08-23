using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ZoeyRoom : MonoBehaviour {

	InteractionManager im;
	int clicks;
	// Use this for initialization
	void Start () {
		im = GameObject.Find ("InteractionManager").GetComponent<InteractionManager> ();
		clicks = 0;
	}

	void Interact(){
		List<string> dialoglist = im.zoeyRoom.dialogMap [1];
		clicks = im.zoeyRoom.Interact(dialoglist, clicks);
	}
}
