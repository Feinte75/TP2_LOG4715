using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		CarController car = other.transform.GetComponentInParent<CarController>();
		if (IsPlayer(car))
		{
			Debug.Log("Ok ! ");
			Destroy (this.gameObject);

		}
	}
	
	bool IsPlayer(CarController car)
	{
		return car.GetComponent<CarUserControlMP>() != null;
	}
}
