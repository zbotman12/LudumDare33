using UnityEngine;
using System.Collections;

public class CharacterNavMesh : MonoBehaviour {

	NavMeshAgent agent;

	void Start () {
		agent = GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit, 1000000)){
				agent.SetDestination(hit.point);
			}
		}

	}
}
