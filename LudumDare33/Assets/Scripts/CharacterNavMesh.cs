using UnityEngine;
using System.Collections;

public class CharacterNavMesh : MonoBehaviour {

	NavMeshAgent agent;
	public GameObject ToolText;
	private bool isActive = false;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		GameObject text = GameObject.Find("Tooltip3d(Clone)");

		if (Physics.Raycast (ray, out hit, 1000000)) {
			if (Input.GetMouseButtonDown (0)) {	
				agent.SetDestination (hit.point);
			}
			if (hit.transform.tag == "NPC" && !isActive) {
				isActive = true;
				Instantiate(ToolText, new Vector3(hit.point.x,10,hit.point.z), Quaternion.identity);
				//text.transform.localPosition = new Vector3(hit.point.x,10,hit.point.z);
			}else if (hit.transform.tag != "NPC"){
				isActive = false;
				Destroy(GameObject.Find("Tooltip3d(Clone)"));
				text = null;
			}
			if(text != null){
			text.transform.localPosition = hit.point;//new Vector3(hit.point.x,10,hit.point.z);
			}
			text.GetComponent<TextMesh>().text = hit.transform.gameObject.name;
			text.GetComponent<TextMesh>().fontSize = 60;
		}
	}
}


