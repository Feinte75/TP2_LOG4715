using UnityEngine;
using System.Collections;
using System;

public class Nitro : PowerUp {

	private int nitroValue;

	public override void Init ()
	{
		nitroValue = 5;	
	}

	public override void Execute (CarStatus car)
	{
		Debug.Log ("Nitro ! ");
		car.GetComponent<CarController> ().ChangeMaxSpeed (100);
	}
}
