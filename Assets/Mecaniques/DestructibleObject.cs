﻿using UnityEngine;
using System.Collections;

public class DestructibleObject : MonoBehaviour {

	public int damage = 20 ;

	public bool destructible = true;

	public float explosionForce = 2;
	// Entre dans cette fonction lorsqu il y a une collision
	void OnCollisionEnter(Collision collision) {
			
		if(collision.gameObject.GetComponent<CarStatus>() ){ 

			CarStatus car = collision.gameObject.GetComponent<CarStatus>() ;

			GameObject prefabexplosion = Resources.Load("Explosion") as GameObject;
			ExplosionPhysicsForce epf = prefabexplosion.GetComponent<ExplosionPhysicsForce>();
			epf.explosionForce = explosionForce;
			car.transform.position = this.transform.position;
			GameObject explosion = Instantiate (prefabexplosion) as GameObject ;
			GameObject.Destroy(explosion,3);

			if(destructible){
				GameObject.Destroy (this.gameObject);
			}

			car.infligerDegat(damage);
		
		}
		
	}
	
	
	
}
