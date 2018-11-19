using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteControScript : MonoBehaviour {
//Este script controla el spawn y el despawn de los asteroides

	public float distan;
	public float tiempo;

	public int parts = 1;

	static public GameObject[] astes;
	// Use this for initialization
	void Start () {
		StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	IEnumerator spawn()
	{
		yield return new WaitUntil(() => astes != null);
		int size = astes.Length;
		while(true)
		{
			for(int ii = 0; ii < parts; ii++)
			{
				//print("ii"+ii);
				//print(size*ii/parts);
				for(int jj = size*ii/parts; jj < size*(ii+1)/parts; jj++)
				{
					//print("jj"+jj);
					if(!astes[jj])
					{
						continue;
					}
					if ((astes[jj].transform.position - transform.position).magnitude > distan)
					{
						astes[jj].SetActive(false);
					}
					else
					{
						astes[jj].SetActive(true);
					}
				}
				yield return null;
			}
			
			yield return new WaitForSecondsRealtime(tiempo);
		}
	}
}
