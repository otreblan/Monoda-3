using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondoScript : MonoBehaviour {

	public Transform sigue; //a lo que sigue

	[Range(1.0f, 2.0f)]
	public float magnitud; //Cuanto se moverá(funciona mejor entre 1.0 y 2.0)

	/// <summary>
	/// LateUpdate is called every frame, if the Behaviour is enabled.
	/// It is called after all Update functions have been called.
	/// </summary>
	void LateUpdate()
	{
		transform.position = new Vector3(sigue.position.x,sigue.position.y,transform.position.z)/magnitud;
		//transform.localPosition = sigue.position/magnitud;
	}
}
