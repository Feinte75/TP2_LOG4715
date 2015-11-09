using UnityEngine;
using System.Collections;
using System;

public class ProjectileLauncher : PowerUp {

	private CarStatus carStatus;
	private GameObject prefab;
	public string[] availablePrefab = {"ProjectilePrefab","HomingProjectilePrefab"};

	public override void Init ()
	{
		//TODO Use availablePrefab array to choose resource
		prefab = Resources.Load("HomingProjectilePrefab") as GameObject;
	}

	public override void Execute (CarStatus car)
	{
		GameObject.Instantiate(prefab, GameObject.Find("ProjectileSpawn").transform.position,  GameObject.Find("ProjectileSpawn").transform.rotation);
	}

	public override string GetSpriteName ()
	{
		return "Rocket-icon";
	}

}
