using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sigueScript : MonoBehaviour {

	public Transform sigue;
	public float tiempo = 0.5f;
	public Vector2 vel = Vector2.zero;
	Vector2 sigueVect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		//Vector2.ler
		//sigueVect = Vector2.Lerp(transform.position, sigue.position, Time.deltaTime*tiempo);
		sigueVect = Vector2.SmoothDamp(transform.position, sigue.position,ref vel,tiempo);
		transform.position = new Vector3(sigueVect.x, sigueVect.y, transform.position.z);
	}
	/* static Vector2 lerp(Vector2 a, Vector2 b, float t)
	{
		return new Vector2(Mathf.Lerp(a.x, b.x, t),Mathf.Lerp(a.y, b.y, t));
	}*/
}
