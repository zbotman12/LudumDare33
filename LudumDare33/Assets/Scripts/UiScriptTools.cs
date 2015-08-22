using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class UiScriptTools : MonoBehaviour {

	private bool tipActive = false;

	public GameObject tooltip;
	// Use this for initialization
	void Start () {
	}

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		GameObject toolTipTextObj = null;
		
		if (Physics.Raycast (ray, out hit, 1000000)) {
			if (hit.transform.tag == "NPC" && !tipActive) {
				tipActive = true;
				toolTipTextObj = Instantiate (tooltip, Input.mousePosition, transform.rotation) as GameObject;
				toolTipTextObj.transform.SetParent (transform);
			}else if(hit.transform.tag != "NPC"){
				tipActive = false;
				if(toolTipTextObj != null){
					Destroy(toolTipTextObj.gameObject);
					toolTipTextObj = null;
				}
			}
		}
	}
}
