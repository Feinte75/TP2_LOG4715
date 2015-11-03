using UnityEngine;
using System.Collections;

public class AutoReplacement : MonoBehaviour {

	public string tag = "Player";


	void OnTriggerEnter(Collider collider) {
		Transform player = collider.transform.parent.parent;

		Debug.Log (player);



	}

}
