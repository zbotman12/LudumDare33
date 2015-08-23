using UnityEngine;
using System.Collections;

public class lightflicker : MonoBehaviour {

	Light light;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		light.intensity =  Random.Range (2, 4);
	}
}
