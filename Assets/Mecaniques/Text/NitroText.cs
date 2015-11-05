using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NitroText : MonoBehaviour {

	public Text nitroText;
	
	// Update is called once per frame
	void Update ()
	{
		GameObject player = GameObject.Find("Joueur 1");
		if (player!=null)
		{
			CarStatus carStatus = player.GetComponent<CarStatus>();
			if (carStatus)
			{
				nitroText.text ="Nitro : " + (carStatus.Nitro).ToString ();
				
			}
		}
	}
}
