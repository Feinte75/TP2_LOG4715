using UnityEngine;
using System.Collections;

public class HealingObject : MonoBehaviour {

	public int HP = 50 ;
	
	// Entre dans cette fonction lorsqu il y a une collision
	void OnCollisionEnter(Collision collision) {
		
		if(collision.gameObject.GetComponentInParent<CarStatus>() ){ 
			
			CarStatus car = collision.gameObject.GetComponent<CarStatus>() ;


			GameObject.Destroy (this.gameObject);
			
			car.recupererDegat(HP);
			
		}
		
	}
}
