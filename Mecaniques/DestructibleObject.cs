using UnityEngine;
using System.Collections;

public class DestructibleObject : MonoBehaviour {

	// Entre dans cette fonction lorsqu il y a une collision
	void OnCollisionEnter(Collision collision) {
	
		// Si l objet rentre en contact avec un projectile
		//if(collision.gameObject is Projectile){  
			Destroy(collision.gameObject); // Destruction du projectile (A verifier avec ceux l implementation du projectile)
			Destroy(this.gameObject); //Destruction de l obstacle ( Je pense a un bloc ou rocher )

		//}

		// Rajouter le cas pour les voitures pour qu il ralentisse a chaque degats

	}



}
