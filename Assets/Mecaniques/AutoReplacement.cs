using UnityEngine;
using System.Collections;

public class AutoReplacement : MonoBehaviour {

	public string tag = "Player";

	public Transform replacementPoint;


	void OnTriggerEnter(Collider collider) { // Rajouter aussi pour projectile
		Transform player = collider.transform.parent.parent;

		Debug.Log (collider);

		if (player.tag == tag) {
			player.position = replacementPoint.position;
			player.rotation = replacementPoint.rotation;
			player.rigidbody.velocity = Vector3.zero;
			player.rigidbody.angularVelocity = Vector3.zero;
		
		} 
		else {



		}


	}

}
