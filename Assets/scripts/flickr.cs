using UnityEngine;
using System.Collections;

public class flickr : MonoBehaviour {

	public Light t;
	public float max;
	public float min;


	// Use this for initialization
	void Start () {
		t = GetComponent < Light>();

		StartCoroutine (Flashing());
	
	}
	
	IEnumerator Flashing()
	{
		while (true) 
		{
			yield return new WaitForSeconds (Random.Range(max,min));
			t.enabled = !t.enabled;
		}
	}
}
