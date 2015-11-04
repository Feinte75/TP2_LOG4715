using UnityEngine;
using System.Collections;
using System;

public class ProjectileLauncher : PowerUp {

	private CarStatus carStatus;
	private GameObject prefab;
	public string[] availablePrefab = {"ProjectilePrefab"};

	public override void Init ()
	{
		//TODO Use availablePrefab array to choose resource
		prefab = Resources.Load("ProjectilePrefab") as GameObject;
	}

	public override void Execute (CarStatus car)
	{
		GameObject.Instantiate(prefab, GameObject.Find("projectileSpawn").transform.position,  GameObject.Find("projectileSpawn").transform.rotation);
	}

}
