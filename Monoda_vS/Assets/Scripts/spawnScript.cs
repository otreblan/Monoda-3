using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class spawnScript : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	public void spawnPlayer()
	{
		StartCoroutine(coSpawnPlayer());
	}

	IEnumerator coSpawnPlayer()
	{
		yield return new WaitForSecondsRealtime(1.0f);
		GameObject pla = Instantiate(player);
		
		yield return null;
	}
}
