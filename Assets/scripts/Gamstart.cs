using UnityEngine;
using System.Collections;

public class Gamstart : MonoBehaviour {

	public Animation a;

	void Start()
	{
		a=GetComponent < Animation>();
	}

	public void changescene()
	{
		a.Play ();
		//yield return new WaitForSeconds(a.clip.length*2);
		Application.LoadLevel (01);

	}
}
