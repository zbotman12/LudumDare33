using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	Text text;
	Image panel;
	bool textfade;

	void Start(){
		text = GetComponent<Text> ();
		panel = GetComponentInChildren<Image> ();
	}

	public void Fade(){
			text.color = new Color (text.color.r, text.color.g, text.color.b, 0);
			panel.color = new Color (panel.color.r, panel.color.g, panel.color.b, 0);
	}

	public void Show(){
		text.color = new Color (text.color.r, text.color.g, text.color.b, 1f);
		panel.color =  new Color (panel.color.r, panel.color.g, panel.color.b, .4f);
	}
}
