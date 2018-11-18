using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.API;
using GameJolt.UI;
using UnityEngine.UI;

public class usuarioScript : MonoBehaviour {

	// Use this for initialization
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
	void Start () {
		//yield return new WaitUntil(() => GameJoltAPI.Instance.HasUser);
		//User = GameJoltAPI.Instance.CurrentUser.Name;
		nombrePruebas.text = ">:v";
		
		#if UNITY_EDITOR
			GameJoltUI.Instance.ShowSignIn(signInSuccess => {
				if(signInSuccess) {
					//ShowTrophiesButton.interactable = true;
					Debug.Log("Logged In");
				} else {
					Debug.Log("Dismissed or Failed");
				}
			}, userFetchSuccess => {
				Debug.Log(string.Format("User's Information Fetch {0}.", userFetchSuccess ? "Successful" : "Failed"));
			});
			nombrePruebas.text = GameJoltAPI.Instance.CurrentUser.Name;
		#endif
		#if UNITY_WEBGL
			nombrePruebas.text = GameJoltAPI.Instance.CurrentUser.Name;
		#endif
		//yield return null;
	}
}
