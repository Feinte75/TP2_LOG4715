using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BendDetector : MonoBehaviour {


	public Image image;
	bool detected = false;
	Transform[] waypoints;


	void Start () {
		waypoints = GameObject.Find ("Path A").GetComponent<WaypointCircuit> ().waypointList.items;
		
	}

	void Update() {
		
		BendIndication bend = null;
		float mindistance = 100;
		float threeshold = 40;
		foreach  (Transform wp in waypoints) {
			if(wp.GetComponent<BendIndication>()!=null){
				BendIndication bi = wp.GetComponent<BendIndication>();
				float distance =  Vector3.Distance(wp.transform.position, transform.position);
				float direction = wp.position.z- transform.position.z ;
				if(distance < mindistance  && direction > 0){
					
					mindistance = distance;
					bend = bi ;
					
					if(distance <= threeshold){
						detected = true ;
						break;
						
					}
				}
				else if(direction < 0){
					detected = false ;
					
				}

			}
			
			
		}

		Debug.Log ("BENDER " + bend);
		if (bend != null && detected) {
			Debug.Log ("BENDER DIR " + bend.turnDirection);
			if (bend.turnDirection == "Left") {
				image.sprite = Resources.Load ("turn-left", typeof(Sprite)) as Sprite;
				image.CrossFadeAlpha(1, 0.5f, false);

			} else if (bend.turnDirection == "Right") {
				image.sprite = Resources.Load ("turn-right", typeof(Sprite)) as Sprite;
				image.CrossFadeAlpha(1, 0.5f, false);
				
			}


		} else {

			image.CrossFadeAlpha(0, 0.5f, false);
		}
			
	}
}
