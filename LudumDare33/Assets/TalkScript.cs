using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TalkScript : MonoBehaviour {

	Canvas canvas;
	Text dialog;
	void Start(){
		canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
		dialog = canvas.GetComponentsInChildren<Text> ()[0];
	}

	void Interact(){
		if (this.gameObject.name == "Zoey") {
			dialog.text = "Hello!! I am be the zooeeeyy. IH asd fUCK you.";
		}
		if (this.gameObject.name == "Larry") {
			dialog.text = "Fuck you I'm larry.";
		}
		}
}
