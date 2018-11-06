using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plaScript : MonoBehaviour {

	#region variables
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
			text.text = "Aste: "+value.ToString();
		}
	}
	int aste = 0;
	Vector3 distan;
	#endregion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		distan = (Vector3)Vector2.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical")),1.0f)*(Time.deltaTime*vel);;
		transform.position += distan;
	}
	
}
