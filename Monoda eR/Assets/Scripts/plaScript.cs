using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plaScript : MonoBehaviour {

	public Text text;

	public float vel = 1f;

	public int Aste
	{
		get
		{
			return aste;
		}
		set
		{
			aste = value;
			text.text = "aste: "+value.ToString();
		}
	}
	int aste = 0;

	Vector3 distan;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distan = Vector3.ClampMagnitude(new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0f),1.0f)*(Time.deltaTime*vel);;
		transform.position += distan;
	}
}
