using UnityEngine;
using System.Collections;

public class BouncingProjectile : Projectile {
	
	public int maxBouncing = 1;
	public int bouncing = 0;

	void Start () {
		Rigidbody rigidbody =  this.GetComponent<Rigidbody>();
		rigidbody.velocity = GameObject.Find("projectileSpawn").transform.up * 80;

	}


	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Wall" && bouncing<maxBouncing){
			//rigidbody.velocity = GameObject.Find("projectileSpawn").transform.up * 80;
			rigidbody.velocity = Vector3.Reflect(rigidbody.velocity,collision.collider.transform.position.normalized);
			bouncing++;

		}
		else{ 		
		if(collision.gameObject.GetComponent<CarStatus>()!=null){  
		
			CarStatus car = collision.gameObject.GetComponent<CarStatus>();
			car.infligerDegat(20);
		}

		GameObject prefabexplosion = Resources.Load("Explosion") as GameObject;
		ExplosionPhysicsForce epf = prefabexplosion.GetComponent<ExplosionPhysicsForce>();
		epf.explosionForce = 1;
		prefabexplosion.transform.position = this.transform.position;
		GameObject explosion = Instantiate (prefabexplosion) as GameObject ;

		GameObject.Destroy(this.gameObject);

		GameObject.Destroy(explosion,3);
		
		}
	

	
	}
}
