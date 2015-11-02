using UnityEngine;
using System.Collections;

public class ProjectileLauncher : MonoBehaviour {

	public CarStatus carstatus;

	public GameObject prefab;
	void Start () {
		prefab = Resources.Load("Projectile_prefab") as GameObject;
		carstatus = this.GetComponent<CarStatus>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && carstatus.hasbouncingprojectile) {
			GameObject.Instantiate(prefab, GameObject.Find("projectileSpawn").transform.position,  GameObject.Find("projectileSpawn").transform.rotation);
			carstatus.hasbouncingprojectile = false ;
		}

	}


}
