using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameJolt.API;

public class gameJoltUserScript : MonoBehaviour {
	string user = string.Empty;
	public Text nombrePruebas;
	public string User
	{
		get
		{
			return user;
		}
		set
		{
			nombrePruebas.text = "Hola, "+value;
			user = value;
		}
	}
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitUntil(() => GameJoltAPI.Instance.HasUser);
		User = GameJoltAPI.Instance.CurrentUser.Name;
		//yield return null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
