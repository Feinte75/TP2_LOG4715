using UnityEngine;
using System.Collections;

public class CarStatus : MonoBehaviour {

	public bool hasbouncingprojectile = false;

	public int currentHP = 100;

	public int maxHP = 100;

	public CarController car ;

	void Start () {

		car = GetComponent<CarController> ();

	}

	public void recupererDegat(int HP)
	{
		changeHP(HP);
		changeCarHealth ();
		
	}

	public void infligerDegat(int HP)
	{
		changeHP(-HP);
		changeCarHealth ();

	}

	public void changeCarHealth () { // Fummee + Vitesse
		if(currentHP < 0){
			car.ChangeMaxSpeed(0);

			GameObject prefabexplosion = Resources.Load("Explosion") as GameObject;
			ExplosionPhysicsForce epf = prefabexplosion.GetComponent<ExplosionPhysicsForce>();
			epf.explosionForce = 1;
			prefabexplosion.transform.position = this.transform.position;
			GameObject explosion = Instantiate (prefabexplosion) as GameObject ;

			GameObject.Destroy(explosion,3);

			Destroy(this.gameObject,3);
		}
		else if(currentHP >= 0 && currentHP<20){
			car.ChangeMaxSpeed(40);
		}
		else if(currentHP >= 20 && currentHP<40){
			car.ChangeMaxSpeed(50);
		}
		else if(currentHP >= 40 && currentHP<60){
			car.ChangeMaxSpeed(55);
		}
		else if(currentHP >= 60 && currentHP<80){
			car.ChangeMaxSpeed(60);
		}
		else if(currentHP >= 80){
			car.ChangeMaxSpeed(60);
		}

	}


	public void changeHP(int HP)
	{
		if (this.currentHP + HP < this.maxHP) {
			this.currentHP += HP;
		} else {
			this.currentHP = this.maxHP;
		}
	}

}
