using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ItemDatabase : MonoBehaviour {

	public List<Item> items = new List<Item>();

	// Use this for initialization
	void Start () {
	
		items.Add (new Item ("Some drugs", 0, "OOSDJFSDLKFJSDLK", Item.ItemType.drugs));
		items.Add (new Item ("Chicken", 0, "finger lickin gay", Item.ItemType.chicken));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
