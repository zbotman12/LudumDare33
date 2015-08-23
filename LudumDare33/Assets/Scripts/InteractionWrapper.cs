using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractionWrapper : MonoBehaviour {

	InteractionManager im;
	int clicks;
	// Use this for initialization
	void Start () {
		im = GameObject.Find ("InteractionManager").GetComponent<InteractionManager> ();
		clicks = 0;
	}

	void Interact(){
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		/*if (gameObject.name == "ZoeyBasement") {
			List<string> dialoglist = im.zoeyBasement.dialogMap [1];
			clicks = im.zoeyBasement.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.Amanda.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}
		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}		if (gameObject.name == "ZoeyRoom") {
			List<string> dialoglist = im.zoeyRoom.dialogMap [1];
			clicks = im.zoeyRoom.Interact (dialoglist, clicks);
		}*/


	}
}
