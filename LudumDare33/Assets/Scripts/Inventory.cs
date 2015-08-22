using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public GameObject slots;
	float initalx;
	float initaly;

	// Use this for initialization
	void Start () {
		initalx = GetComponent<RectTransform>().anchoredPosition3D.x;
		initaly = GetComponent<RectTransform>().anchoredPosition3D.y;

		float x = initalx;
		float y = initaly;

		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				GameObject slot = (GameObject)Instantiate(slots);
				slot.transform.SetParent(this.gameObject.transform);
				slot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0);
				x = x + 55;
			}
			y = y - 55;
			x=initalx;
		}

	}

}