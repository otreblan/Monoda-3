using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiaEscena : MonoBehaviour {

	// Use this for initialization
	public void cambio(string escena)
	{
		SceneManager.LoadScene(escena);
	}
}
