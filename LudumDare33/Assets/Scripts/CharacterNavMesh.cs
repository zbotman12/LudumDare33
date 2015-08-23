using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterNavMesh : MonoBehaviour {

	NavMeshAgent agent;
	public GameObject ToolText;
	private bool isActive = false;
	[HideInInspector]
	public int status = 0;
	static Text dialogbox;
	IEnumerator textfade;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		dialogbox = GameObject.Find ("Canvas").GetComponentsInChildren<Text> () [0];
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		GameObject text = GameObject.Find ("Tooltip3d(Clone)");

		if (Physics.Raycast (ray, out hit, 1000000)) {

			//DIALOG and WALKING
			if (Input.GetMouseButtonDown (0)) {
				if (hit.transform.tag == "NPC" || hit.transform.tag == "Interactable") {  
					hit.transform.gameObject.SendMessage ("Interact");
					dialogbox.SendMessage ("Show");
					if (textfade != null) {
						StopCoroutine (textfade);
						textfade = null;
					}
						textfade = MyEvent (4f);
						StartCoroutine (textfade);
					} else {
						agent.SetDestination (hit.point);
					}
				}
				//TOOLTIPS
				if (hit.transform.tag == "NPC" && !isActive) {
					isActive = true;
					Instantiate (ToolText, new Vector3 (hit.point.x, 10, hit.point.z), Quaternion.identity);
					//text.transform.localPosition = new Vector3(hit.point.x,10,hit.point.z);
				} else if (hit.transform.tag != "NPC") {
					isActive = false;
					Destroy (GameObject.Find ("Tooltip3d(Clone)"));
					text = null;
				}
				if (text != null) {
					text.transform.localPosition = hit.point;//new Vector3(hit.point.x,10,hit.point.z);
					text.GetComponent<TextMesh> ().text = hit.transform.gameObject.name;
					text.GetComponent<TextMesh> ().fontSize = 60;
				}
		
			}
	}

	public static IEnumerator MyEvent(float waittime)
	{
		while(true){
			yield return new WaitForSeconds(waittime);
			dialogbox.SendMessage("Fade");

		}

	}
}

