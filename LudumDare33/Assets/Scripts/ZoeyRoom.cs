using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ZoeyRoom : MonoBehaviour {

	InteractionManager im;
	int clicks;
	Text screentext;
	int day = 0;
	// Use this for initialization
	void Start () {
		im = GameObject.Find ("InteractionManager").GetComponent<InteractionManager> ();
		screentext = GameObject.Find ("Canvas").GetComponentsInChildren<Text>()[0];
		clicks = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Interact(){
		//Debug.Log ("Interact Number of clicks: " + clicks); //got here
		List<string> dialoglist = im.zoeyRoom.dialogMap [1];
		//foreach (string str in dialoglist) {
			//Debug.Log ("string is:" + str);
		//}
		//Debug.Log ("print something goofy");
		//Debug.Log ("print something goofy + this: " + dialoglist.ToString () + " " + dialoglist.Count);
	
		if (clicks < dialoglist.Count) {
			screentext.text = dialoglist.ToArray()[clicks];
			clicks++;
			Debug.Log (clicks);
		} else {
			clicks = 0;
		}

	}
}
