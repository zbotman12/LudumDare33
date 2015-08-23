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
			dialog.text = "Hey Mr. Devins. Do you need my dad for something? He's probably in his office down stairs.";//this is afternoon dialog
		}
		if (this.gameObject.name == "Larry") {
			dialog.text = "Oh hey there Mike! How's it going?";
		}
		if (this.gameObject.name == "Melissa"){
			dialog.text = "Oh, hello dearie! How are you doing today?";
		}
		if (this.gameObject.name == "DankManJoe"){
			dialog.text = "I don't exist!";
		}
		if (this.gameObject.name == "Frank") {
			dialog.text = "Mike. What do want? You break something again?";
		}
		if (this.gameObject.name == "Claire") {
			dialog.text = "Hello Mike. Frank is in his office, thankfully.";
		}
		if (this.gameObject.name == "Drake"){
			dialog.text = "Hey Mike. How's your work going?";
		}
		if (this.gameObject.name == "Ashton") {
			dialog.text = "Hey Man, what's up?";
		}
	}
}