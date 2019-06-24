using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {

	public Light t;

	void Start () {
		t = GetComponent < Light>();
	}
	

	void Update () 
	{
		if (Input.GetKeyDown ("f")) 
		{
			t.enabled = !t.enabled;
		}
	}
}
