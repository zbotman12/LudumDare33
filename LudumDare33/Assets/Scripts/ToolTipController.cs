using UnityEngine;
using System.Collections;

public class ToolTipController : MonoBehaviour {
	
	private Vector3 offset;
	public float textHeight = 10;
	//public Time delay;
	// Use this for initialization
	void Start () {
		//offset = transform.position - Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Input.mousePosition.x,textHeight, Input.mousePosition.y);
	}
}
